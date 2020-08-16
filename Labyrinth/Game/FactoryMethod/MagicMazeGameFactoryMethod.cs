using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.PlayerData;
using Labyrinth.Schema;

namespace Labyrinth.Game.FactoryMethod
{
    /// <summary>
    /// Волшебный лабиринт
    /// </summary>
    public class MagicMazeGameFactoryMethod : AbstractMazeGameFactoryMethod
    {
        private Player _player;

        /// <summary>
        /// Волшебный лабиринт
        /// </summary>
        public MagicMazeGameFactoryMethod()
        {
            _player = new Player();
        }

        public override Maze MakeMaze()
        {
            return new Maze();
        }
        public override Wall MakeWall()
        {
            return new Wall();
        }

        public override Room MakeRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public override AbstractDoor MakeDoor(Room roomFrom, Room roomTo)
        {
            return new MagicDoor(roomFrom, roomTo, _player);
        }
    }
}
