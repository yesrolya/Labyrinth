using Labyrinth.PlayerData;
using System;

namespace Labyrinth.Components.Doors
{
    /// <summary>
    /// Злая дверь, которая бьет игроков
    /// </summary>
    public class MagicDoor : AbstractDoor
    {
        private Player _player;

        public override bool Enter()
        {
            _player.Hit(DateTime.Now.Second);

            return !_player.IsOver;
        }

        public override Room OtherSideFrom(Room someRoom) => null;

        public MagicDoor(Room roomFrom, Room roomTo, Player player): base(roomFrom, roomTo) 
        {
            _player = player;
        }
    }
}
