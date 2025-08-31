using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapGame.Classes;
using SnapGame.InterFaces;
using SnapGame.Enums;

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
                    return new PlayCardPokerGame();

                default:
                    return null;
            }
        }
    }
}