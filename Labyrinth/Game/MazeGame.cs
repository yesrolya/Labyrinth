using Labyrinth.Components;
using Labyrinth.Components.Properties;
using Labyrinth.Schema;

namespace Labyrinth.Game
{
    public class MazeGame
    {
        public static Maze CreateLabyrinth()
        {
            var maze = new Maze();
            var r1 = new Room(1);
            var r2 = new Room(2);

            var door12 = new Door(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, door12);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, door12);

            return maze;
        }
    }
}
