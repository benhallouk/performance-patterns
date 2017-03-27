using DesignPatterns.Flyweight.Implementation;
using DesignPatterns.Flyweight.Implementation.Players;
using NUnit.Framework;

namespace DesignPatterns.Flyweight
{
    [TestFixture]
    public class FlyweigthTests
    {
        [Test]
        public void When_Flywieight_Not_Implemented()
        {
            for (int index = 1; index < 1000001; index++)
            {
                IPlayer player;
                if (index == 1)
                {
                    player = new GoalKeeper
                    {
                        Name = $"Player {index}",
                        Number = index + 1
                    };
                }
                else
                if (index % 2 == 0)
                {
                    player = new Attacker
                    {
                        Name = $"Player {index}",
                        Number = index + 1
                    };
                }
                else
                    player = new Defender
                    {
                        Name = $"Player {index}",
                        Number = index + 1
                    };
            }
        }

        [Test]
        public void When_Flywieight_Is_Implemented()
        {
            for (int index = 1; index < 1000001; index++)
            {
                IPlayer player;

                if (index == 1)
                {
                    player = PlayerFactory.GetPlayer(PlayerType.GoalKeeper);

                }
                else
                if (index % 2 == 0)
                {
                    player = PlayerFactory.GetPlayer(PlayerType.Attacker);
                }
                else
                    player = PlayerFactory.GetPlayer(PlayerType.Defender);

                player.Name = $"Player {index}";
                player.Number = index + 1;
            }

            Assert.AreEqual(3, PlayerFactory.PlayersCount);
        }
    }
}