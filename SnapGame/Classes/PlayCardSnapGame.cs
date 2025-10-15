using SnapGame.Enums;
using SnapGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapGame.Classes;

internal class PlayCardSnapGame : IPlayCardGame
{
    private int NumberOfDecks { get; }
    private int NumberOfPlayers { get; }
    private MatchingCondition MatchingCondition { get; }

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
        Players = [];
        var deck = new Deck();

        var deckOfCards = deck.SetupDeck(NumberOfDecks);

        for (var i = 0; i < NumberOfPlayers; i++)
        {
            Players.Add(new Player(i + 1, $"Player {i + 1}"));
        }

        var isGameFinished = false;
        var playedCards = new List<Card>();

        var currentPlayerID = 1;

        while (!isGameFinished)
        {
            playedCards.Add(deckOfCards.Dequeue());

            if (playedCards.Count < 2)
            {
                currentPlayerID = NumberOfPlayers > currentPlayerID ? currentPlayerID + 1 : 1;
                playedCards.Add(deckOfCards.Dequeue());
            }

            if (IsSnap(playedCards[^1], playedCards[^2], MatchingCondition))
            {
                Players.Single(x => x.ID == currentPlayerID).CardsCollected += playedCards.Count;
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

    public GameResultDto DeclareResult()
    {
        Players = [.. Players.OrderByDescending(X => X.CardsCollected)];
        var winner = Players.FirstOrDefault();
        var isMatchDraw = !Players.Any(X => X.CardsCollected < winner.CardsCollected);

        return new GameResultDto
        {
            IsDraw = isMatchDraw,
            WinnerName = isMatchDraw ? null : winner.Name,
            PlayerResults = Players.ConvertAll(x => new PlayerResultDto
            {
                Name = x.Name,
                CardsCollected = x.CardsCollected
            })
        };
    }

    private static bool IsSnap(Card card1, Card card2, MatchingCondition matchingCondition) => matchingCondition switch
    {
        MatchingCondition.Suit => card1.Suit == card2.Suit,
        MatchingCondition.FaceValue => card1.FaceValue == card2.FaceValue,
        MatchingCondition.Both => card1.Suit == card2.Suit && card1.FaceValue == card2.FaceValue,
        _ => false,
    };
}