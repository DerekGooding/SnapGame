using SnapGame.Classes;
using System.Collections.Generic;

namespace SnapGame.Interfaces
{
    internal interface IPlayCardGame
    {
        List<Player> PlayGame();

        GameResultDto DeclareResult();
    }
}