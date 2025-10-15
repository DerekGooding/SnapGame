using SnapGame.Enums;
using SnapGame.Interfaces;
using System.Collections.Generic;

namespace SnapGame.Classes;

internal class PlayCardPokerGame(int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition) : IPlayCardGame
{
    public GameResultDto DeclareResult() => throw new System.NotImplementedException(); // Implementation pending

    public List<Player> PlayGame() => throw new System.NotImplementedException(); // Implementation pending
}