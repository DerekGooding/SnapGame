using System.Collections.Generic;

namespace SnapGame.Classes;

public class GameResultDto
{
    public bool IsDraw { get; set; }
    public string WinnerName { get; set; }
    public List<PlayerResultDto> PlayerResults { get; set; }
}

public class PlayerResultDto
{
    public string Name { get; set; }
    public int CardsCollected { get; set; }
}