namespace DesignPatterns.Flyweight.Implementation.Players
{
    public class Attacker : IPlayer
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get { return PlayerType.Attacker; } }
    }
}
