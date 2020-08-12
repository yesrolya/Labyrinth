using Labyrinth.Components;
using Labyrinth.Components.Factory;
using Labyrinth.Components.Properties;
using Labyrinth.Game.Builder;
using Labyrinth.Schema;

namespace Labyrinth.Game
{
    public class MazeGame
    {
        private readonly IMazeFactory _factory;

        public MazeGame(IMazeFactory factory)
        {
            _factory = factory;
        }

        /// <summary>
        /// Построение лабиринта с использованием фабрики
        /// </summary>
        public Maze CreateLabyrinth()
        {
            var maze = _factory.MakeMaze();
            var r1 = _factory.MakeRoom(1);
            var r2 = _factory.MakeRoom(2);

            var door12 = _factory.MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, _factory.MakeWall());
            r1.SetSide(Direction.East, door12);
            r1.SetSide(Direction.South, _factory.MakeWall());
            r1.SetSide(Direction.West, _factory.MakeWall());

            r2.SetSide(Direction.North, _factory.MakeWall());
            r2.SetSide(Direction.East, _factory.MakeWall());
            r2.SetSide(Direction.South, _factory.MakeWall());
            r2.SetSide(Direction.West, door12);

            return maze;
        }

        /// <summary>
        /// Построение лабиринта с использованием строителя
        /// </summary>
        /// <param name="builder">Builder</param>
        public static Maze CreateLabyrinth(IMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            return builder.GetMaze();
        }
    }
}
