using SnapGame.Classes;
using SnapGame.Enums;
using SnapGame.Interfaces;
using System;

namespace SnapGame.Factory
{
    internal class CardGameFactory
    {
        public static IPlayCardGame GetGame(GameType gateType, int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition)
        {
            switch (gateType)
            {
                case GameType.Snap:
                    return new PlayCardSnapGame(numberOfDecks, numberOfPlayers, matchingCondition);

                case GameType.Poker:
                    return new PlayCardPokerGame(numberOfDecks, numberOfPlayers, matchingCondition);

                default:
                    throw new ArgumentException($"Unsupported game type, game type: {gateType}");
            }
        }
    }
}