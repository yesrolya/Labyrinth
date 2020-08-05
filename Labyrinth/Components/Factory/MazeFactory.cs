using Labyrinth.Components.Doors;
using Labyrinth.Schema;

namespace Labyrinth.Components.Factory
{
    /// <summary>
    /// Обычный лабиринт
    /// </summary>
    public class MazeFactory: IMazeFactory
    {
        public Maze MakeMaze() => new Maze();

        public Wall MakeWall() => new Wall();

        public Room MakeRoom(int roomNumber) => new Room(roomNumber);

        public AbstractDoor MakeDoor(Room roomFrom, Room roomTo) => new Door(roomFrom, roomTo);
    }
}
