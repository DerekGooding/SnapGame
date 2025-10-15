namespace SnapGame.Classes;

public class Player(int id, string name)
{
    public int ID { get; set; } = id;
    public string Name { get; set; } = name;
    public int CardsCollected { get; set; }
}