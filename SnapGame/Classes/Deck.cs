using System;
using System.Collections.Generic;

namespace SnapGame.Classes;

internal class Deck
{
    /// <summary>
    /// Return shuffled deck to play
    /// </summary>
    public Queue<Card> SetupDeck(int numberOfDecks)
        => numberOfDecks <= 0
            ? throw new InvalidOperationException("No. of deck should be atleast one")
            : ShuffleDeck(CreateDeck(numberOfDecks));

    /// <summary>
    /// Create deck to play based on input no. of decks
    /// </summary>
    /// <param name="numberOfDecks">No. of deck</param>
    private static List<Card> CreateDeck(int numberOfDecks)
    {
        var lstCards = new List<Card>();
        var lstFaceValues = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        var lstSuits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
        for (var i = 0; i < numberOfDecks; i++)
        {
            foreach (var suit in lstSuits)
            {
                foreach (var faceValue in lstFaceValues)
                {
                    lstCards.Add(new Card(suit, faceValue));
                }
            }
        }

        return lstCards;
    }

    /// <summary>
    /// Shuffle deck in random order
    /// </summary>
    /// <param name="lstCards">Deck to shuffle</param>
    private static Queue<Card> ShuffleDeck(List<Card> lstCards)
    {
        var rand = new Random();
        for (var i = lstCards.Count - 1; i > 0; i--)
        {
            var j = rand.Next(i + 1);
            (lstCards[j], lstCards[i]) = (lstCards[i], lstCards[j]);
        }
        return new Queue<Card>(lstCards);
    }
}