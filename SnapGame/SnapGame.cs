using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnapGame
{
    public partial class SnapGame : Form
    {
        public SnapGame()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int numberOfDeck = Convert.ToInt32(txtNoOfDeck.Text);
            var matchingCondition = (MatchingCondition)Enum.Parse(typeof(MatchingCondition), ddlMatchingCondition.SelectedItem.ToString());

            var lstCards = new List<Card>();
            var lstFaceValues = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            var lstSuits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
            var rand = new Random();
            var isGameFinished = false;
            int player1Cards = 0, player2Cards = 0;
            var nonSnappedCards = new List<Card>();

            // Create Deck
            for (int i = 0; i < numberOfDeck; i++)
            {
                foreach (var suit in lstSuits)
                {
                    foreach (var faceValue in lstFaceValues)
                    {
                        lstCards.Add(new Card(suit, faceValue));
                    }
                }
            }

            // Shuffle deck
            var pileCards = new Queue<Card>(lstCards.OrderBy(X => rand.Next()));

            while (!isGameFinished)
            {
                var player1Card = pileCards.Dequeue();
                var player2Card = pileCards.Dequeue();
                nonSnappedCards.Add(player1Card);
                nonSnappedCards.Add(player2Card);

                if (IsSnap(player1Card, player2Card, matchingCondition))
                {
                    var randomPlayerNumber = rand.Next(1, 3);
                    if (randomPlayerNumber == 1)
                    {
                        player1Cards += nonSnappedCards.Count;
                    }
                    else
                    {
                        player2Cards += nonSnappedCards.Count;
                    }
                    nonSnappedCards.Clear();
                }

                if (pileCards.Count == 0)
                {
                    isGameFinished = true;
                }
            }
            if (player1Cards == player2Cards)
            {
                lblResult.Text = $"Match is Draw, Player 1 cards: {player1Cards}, Player 2 cards: {player2Cards}";
            }
            else if (player1Cards > player2Cards)
            {
                lblResult.Text = $"Player 1 Won, Player 1 cards: {player1Cards}, Player 2 cards: {player2Cards}";
            }
            else
            {
                lblResult.Text = $"Player 2 Won, Player 1 cards: {player1Cards}, Player 2 cards: {player2Cards}";
            }
        }

        private bool IsSnap(Card player1Card, Card player2Card, MatchingCondition matchingCondition)
        {
            switch (matchingCondition)
            {
                case MatchingCondition.Suit:
                    return player1Card.Suit == player2Card.Suit;

                case MatchingCondition.FaceValue:
                    return player1Card.FaceValue == player2Card.FaceValue;

                case MatchingCondition.Both:
                    return player1Card.Suit == player2Card.Suit && player1Card.FaceValue == player2Card.FaceValue;

                default: return false;
            }
        }
    }
}