using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.Components.Properties;
using Labyrinth.PlayerData;
using Labyrinth.Schema;

namespace Labyrinth.Game
{
    public abstract class AMazeGameFactoryMethod
    {
        public Maze CreateMaze()
        {
            var maze = MakeMaze();
            var r1 = MakeRoom(1);
            var r2 = MakeRoom(2);
            var door = MakeDoor(r1, r2);

            r1.SetSide(Direction.North, door);
            r1.SetSide(Direction.West, MakeWall());
            r1.SetSide(Direction.East, MakeWall());
            r1.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.West, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, door);

            return maze;
        }

        // далее идут фабричные методы

        public abstract Maze MakeMaze();

        public abstract Wall MakeWall();

        public abstract Room MakeRoom(int roomNumber);

        public abstract AbstractDoor MakeDoor(Room roomFrom, Room roomTo);
    }

    /// <summary>
    /// Создание лабиринта с использованием фабричных методов.
    /// Фабричные методы избавляют от new и помогают выбрать нужный класс
    /// </summary>
    public class MazeGameFactoryMethod: AMazeGameFactoryMethod
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

    public class MagicMazeGameFactoryMethod : AMazeGameFactoryMethod
    {
        private Player _player;

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
