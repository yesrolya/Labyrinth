using Labyrinth.Schema;

namespace Labyrinth.Game.Builder
{
    /// <summary>
    /// Строитель
    /// </summary>
    public class MazeGameBuilder
    {
        private IMazeBuilder _builder;

        /// <summary>
        /// Строитель
        /// </summary>
        public MazeGameBuilder(IMazeBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Построение лабиринта с использованием строителя
        /// </summary>
        /// <param name="builder">Builder</param>
        public Maze CreateLabyrinth()
        {
            _builder.BuildMaze();
            _builder.BuildRoom(1);
            _builder.BuildRoom(2);
            _builder.BuildDoor(1, 2);
            return _builder.GetMaze();
        }
    }
}
