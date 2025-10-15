using SnapGame.Classes;
using SnapGame.Enums;
using SnapGame.Interfaces;
using System;

namespace SnapGame.Factory;

public class CardGameFactory
{
    public static IPlayCardGame GetGame(GameType gateType, int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition) => gateType switch
    {
        GameType.Snap => new PlayCardSnapGame(numberOfDecks, numberOfPlayers, matchingCondition),
        GameType.Poker => new PlayCardPokerGame(numberOfDecks, numberOfPlayers, matchingCondition),
        _ => throw new ArgumentException($"Unsupported game type, game type: {gateType}"),
    };
}