using SnapGame.Classes;
using System.Collections.Generic;

namespace SnapGame.Interfaces
{
    public interface IPlayCardGame
    {
        List<Player> PlayGame();

        GameResultDto DeclareResult();
    }
}