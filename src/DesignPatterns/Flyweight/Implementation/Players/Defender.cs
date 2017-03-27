namespace DesignPatterns.Flyweight.Implementation.Players
{
    public class Defender : IPlayer
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get { return PlayerType.Defender; } }
    }
}
