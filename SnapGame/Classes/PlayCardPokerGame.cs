using SnapGame.Enums;
using SnapGame.Interfaces;
using System.Collections.Generic;

namespace SnapGame.Classes;

internal class PlayCardPokerGame : IPlayCardGame
{
    public PlayCardPokerGame(int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition)
    {
    }

    public GameResultDto DeclareResult()
    {
        return null;    // Implementation pending
    }

    public List<Player> PlayGame()
    {
        return null; // Implementation pending
    }
}