using SnapGame.Enums;
using SnapGame.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapGame.Classes
{
    internal class PlayCardSnapGame : IPlayCardGame
    {
        private int NumberOfDecks { get; set; }
        private int NumberOfPlayers { get; set; }
        private MatchingCondition MatchingCondition { get; set; }

        private List<Player> Players { get; set; }

        public PlayCardSnapGame(int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition)
        {
            if (numberOfPlayers < 2)
            {
                throw new InvalidOperationException("No. of players should be atleast two");
            }
            if (numberOfDecks <= 0)
            {
                throw new InvalidOperationException("No. of deck should be atleast one");
            }

            NumberOfDecks = numberOfDecks;
            NumberOfPlayers = numberOfPlayers;
            MatchingCondition = matchingCondition;
        }

        public List<Player> PlayGame()
        {
            Players = new List<Player>();
            var deck = new Deck();

            var deckOfCards = deck.SetupDeck(NumberOfDecks);

            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Players.Add(new Player(i + 1, $"Player {i + 1}"));
            }

            var isGameFinished = false;
            var playedCards = new List<Card>();

            int currentPlayerID = 1;

            while (!isGameFinished)
            {
                playedCards.Add(deckOfCards.Dequeue());

                if (playedCards.Count < 2)
                {
                    currentPlayerID = NumberOfPlayers > currentPlayerID ? currentPlayerID + 1 : 1;
                    playedCards.Add(deckOfCards.Dequeue());
                }

                if (IsSnap(playedCards[playedCards.Count - 1], playedCards[playedCards.Count - 2], MatchingCondition))
                {
                    Players.SingleOrDefault(x => x.ID == currentPlayerID).CardsCollected += playedCards.Count;
                    playedCards.Clear();
                }

                if (deckOfCards.Count <= 1)
                {
                    isGameFinished = true;
                }
                currentPlayerID = NumberOfPlayers > currentPlayerID ? currentPlayerID + 1 : 1;
            }
            return Players;     // Returning Players data just in case caller wants to do some special handling, for pre defined cases, return value can be ignored
        }

        public string DeclareResult()
        {
            Players = Players.OrderByDescending(X => X.CardsCollected).ToList();
            var winner = Players.FirstOrDefault();
            var isMatchDraw = !Players.Any(X => X.CardsCollected < winner.CardsCollected);
            if (isMatchDraw)
            {
                return $"Match is Draw, {string.Join(", ", Players.Select(X => $"{X.Name} cards: {X.CardsCollected}"))}";
            }
            else
            {
                return $"{winner.Name} is won, {string.Join(", ", Players.Select(X => $"{X.Name} cards: {X.CardsCollected}"))}";
            }
        }

        private bool IsSnap(Card card1, Card card2, MatchingCondition matchingCondition)
        {
            switch (matchingCondition)
            {
                case MatchingCondition.Suit:
                    return card1.Suit == card2.Suit;

                case MatchingCondition.FaceValue:
                    return card1.FaceValue == card2.FaceValue;

                case MatchingCondition.Both:
                    return card1.Suit == card2.Suit && card1.FaceValue == card2.FaceValue;

                default: return false;
            }
        }
    }
}