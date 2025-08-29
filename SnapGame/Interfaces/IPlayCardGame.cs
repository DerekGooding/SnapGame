using System.Collections.Generic;
using SnapGame.Classes;

namespace SnapGame.InterFaces
{
    internal interface IPlayCardGame
    {
        List<Player> PlayGame();

        string DeclareResult();
    }
}