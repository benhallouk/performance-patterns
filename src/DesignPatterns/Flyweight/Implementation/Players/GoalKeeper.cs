namespace DesignPatterns.Flyweight.Implementation.Players
{
    public class GoalKeeper : IPlayer
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get { return PlayerType.GoalKeeper; } }
    }
}
