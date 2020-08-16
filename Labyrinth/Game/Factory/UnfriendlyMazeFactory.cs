using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.PlayerData;
using Labyrinth.Schema;

namespace Labyrinth.Game.Factory
{
    /// <summary>
    /// Недружелюбный лабиринт, предметы в нем могут нанести увечья
    /// </summary>
    public class UnfriendlyMazeFactory : IMazeFactory
    {
        private Player _player;
        public UnfriendlyMazeFactory(Player player)
        {
            _player = player;
        }

        public Maze MakeMaze() => new Maze();

        public Wall MakeWall() => new Wall();

        public Room MakeRoom(int roomNumber) => new Room(roomNumber);

        public AbstractDoor MakeDoor(Room roomFrom, Room roomTo) => new MagicDoor(roomFrom, roomTo, _player);
    }
}

