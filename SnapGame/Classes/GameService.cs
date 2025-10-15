using SnapGame.Enums;
using SnapGame.Factory;
using SnapGame.Interfaces;

namespace SnapGame.Classes;

public class GameService : IGameService
{
    public GameResultDto PlayGame(GameType gameType, int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition)
    {
        var game = CardGameFactory.GetGame(gameType, numberOfDecks, numberOfPlayers, matchingCondition);
        game.PlayGame();
        return game.DeclareResult();
    }
}