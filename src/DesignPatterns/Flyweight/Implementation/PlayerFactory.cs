using DesignPatterns.Flyweight.Implementation.Players;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight.Implementation
{
    public static class PlayerFactory
    {
        public static int PlayersCount { get; private set; }

        private static Dictionary<PlayerType, IPlayer> _players;

        public static IPlayer GetPlayer(PlayerType type)
        {
            if (_players == null) _players = new Dictionary<PlayerType, IPlayer>();

            if (_players.ContainsKey(type))
            {
                return _players[type];
            }

            IPlayer player = null;
            PlayersCount++;
            switch (type)
            {
                case PlayerType.GoalKeeper:
                    player = new GoalKeeper();
                    break;
                case PlayerType.Attacker:
                    player = new Attacker();
                    break;
                case PlayerType.Defender:
                    player = new Defender();
                    break;
            }

            _players.Add(type, player);
            return player;
        }
    }
}
