namespace DesignPatterns.Flyweight.Implementation.Players
{
    public interface IPlayer
    {
        int Number { get; set; }
        string Name { get; set; }
        PlayerType Type { get; }
    }
}
