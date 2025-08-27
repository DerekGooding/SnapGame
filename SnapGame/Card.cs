namespace SnapGame
{
    internal class Card
    {
        internal string Suit { get; set; }
        internal string FaceValue { get; set; }

        internal Card(string suit, string faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }
    }
}