using System;
using System.Collections.Generic;

namespace SnapGame.Classes;

internal class Deck
{
    /// <summary>
    /// Return shuffled deck to play
    /// </summary>
    /// <param name="numberOfDecks"></param>
    /// <returns></returns>
    public Queue<Card> SetupDeck(int numberOfDecks)
    {
        if (numberOfDecks <= 0)
        {
            throw new InvalidOperationException("No. of deck should be atleast one");
        }
        return ShuffleDeck(CreateDeck(numberOfDecks));
    }

    /// <summary>
    /// Create deck to play based on input no. of decks
    /// </summary>
    /// <param name="numberOfDecks">No. of deck</param>
    /// <returns></returns>
    private List<Card> CreateDeck(int numberOfDecks)
    {
        var lstCards = new List<Card>();
        var lstFaceValues = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        var lstSuits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
        for (int i = 0; i < numberOfDecks; i++)
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
    /// <returns></returns>
    private Queue<Card> ShuffleDeck(List<Card> lstCards)
    {
        var rand = new Random();
        for (int i = lstCards.Count - 1; i > 0; i--)
        {
            var j = rand.Next(i + 1);
            var temp = lstCards[i];
            lstCards[i] = lstCards[j];
            lstCards[j] = temp;
        }
        return new Queue<Card>(lstCards);
    }
}