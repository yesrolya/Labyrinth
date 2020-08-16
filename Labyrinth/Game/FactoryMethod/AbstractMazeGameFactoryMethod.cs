using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.Components.Properties;
using Labyrinth.Schema;

namespace Labyrinth.Game.FactoryMethod
{
    // Создание лабиринта с использованием фабричных методов.
    // Фабричные методы избавляют от new и помогают выбрать нужный класс

    /// <summary>
    /// Абстрактный класс для реализации паттерна фабричный метод.
    /// Метод по созданию всего лабиринта одинаковый для всех классов.
    /// Переопределяются методы создания компонентов лабиринта
    /// </summary>
    public abstract class AbstractMazeGameFactoryMethod
    {
        /// <summary>
        /// Создание всего лабиринта
        /// </summary>
        public Maze CreateLabyrinth()
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

        /// <summary>
        /// Создать объект лабиринта
        /// </summary>
        public abstract Maze MakeMaze();

        /// <summary>
        /// Создать стену
        /// </summary>
        public abstract Wall MakeWall();

        /// <summary>
        /// Создать комнату
        /// </summary>
        /// <param name="roomNumber">Номер комнаты</param>
        public abstract Room MakeRoom(int roomNumber);

        /// <summary>
        /// Создать дверь между комнатами
        /// </summary>
        /// <param name="roomFrom">Комната 1</param>
        /// <param name="roomTo">Комната 2</param>
        public abstract AbstractDoor MakeDoor(Room roomFrom, Room roomTo);
    }
}
