using SnapGame.Classes;
using SnapGame.Enums;

namespace SnapGame.Interfaces;

public interface IGameService
{
    GameResultDto PlayGame(GameType gameType, int numberOfDecks, int numberOfPlayers, MatchingCondition matchingCondition);
}