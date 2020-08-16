using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.Schema;

namespace Labyrinth.Game.FactoryMethod
{
    /// <summary>
    /// Обычный лабиринт
    /// </summary>
    public class MazeGameFactoryMethod: AbstractMazeGameFactoryMethod
    {
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
            return new Door(roomFrom, roomTo);
        }
    }
}
