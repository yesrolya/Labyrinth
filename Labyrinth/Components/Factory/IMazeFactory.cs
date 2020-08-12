using Labyrinth.Components.Doors;
using Labyrinth.Schema;

namespace Labyrinth.Components.Factory
{
    /// <summary>
    /// Интерфейс фабрики лабиринта.
    /// Паттерн абстрактная фабрика
    /// </summary>
    public interface IMazeFactory
    {
        /// <summary>
        /// Создать лабиринт
        /// </summary>
        public Maze MakeMaze();

        /// <summary>
        /// Создать стену
        /// </summary>
        public Wall MakeWall();

        /// <summary>
        /// Создать комнату
        /// </summary>
        /// <param name="roomNumber">Уникальный идентифкатор комнаты в лабиринте</param>
        public Room MakeRoom(int roomNumber);

        /// <summary>
        /// Создать дверь между комнатами
        /// </summary>
        /// <param name="roomFrom">Комната 1</param>
        /// <param name="roomTo">Комната 2</param>
        public AbstractDoor MakeDoor(Room roomFrom, Room roomTo);
    }
}
