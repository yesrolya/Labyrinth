using Labyrinth.Schema;

namespace Labyrinth.Game.Builder
{
    /// <summary>
    /// Интерфейс строителя лабиринта.
    /// Паттерн строитель
    /// </summary>
    public interface IMazeBuilder
    {
        /// <summary>
        /// Создать лабиринт
        /// </summary>
        void BuildMaze();

        /// <summary>
        /// Создать комнату лабиринта
        /// </summary>
        /// <param name="number">Номер комнаты</param>
        void BuildRoom(int number);

        /// <summary>
        /// Создать дверь между комнатами
        /// </summary>
        void BuildDoor(int roomFrom, int doorTo);

        /// <summary>
        /// Получиь созданный лабиринт
        /// </summary>
        Maze GetMaze();
    }
}
