namespace SnapGame.Classes
{
    internal class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CardsCollected { get; set; }

        public Player(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}