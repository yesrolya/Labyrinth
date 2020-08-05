using Labyrinth.Components.Factory;
using Labyrinth.Components.Properties;
using Labyrinth.Schema;

namespace Labyrinth.Game
{
    public class MazeGame
    {
        private IMazeFactory Factory { get; }

        public MazeGame(IMazeFactory factory)
        {
            Factory = factory;
        }

        public Maze CreateLabyrinth()
        {
            var maze = Factory.MakeMaze();
            var r1 = Factory.MakeRoom(1);
            var r2 = Factory.MakeRoom(2);

            var door12 = Factory.MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, Factory.MakeWall());
            r1.SetSide(Direction.East, door12);
            r1.SetSide(Direction.South, Factory.MakeWall());
            r1.SetSide(Direction.West, Factory.MakeWall());

            r2.SetSide(Direction.North, Factory.MakeWall());
            r2.SetSide(Direction.East, Factory.MakeWall());
            r2.SetSide(Direction.South, Factory.MakeWall());
            r2.SetSide(Direction.West, door12);

            return maze;
        }
    }
}
