using Labyrinth.Components;
using Labyrinth.Components.Doors;
using Labyrinth.Components.Properties;
using Labyrinth.Schema;
using System;

namespace Labyrinth.Game.Builder
{
    /// <summary>
    /// Реализация строителя для простого лабиринта.
    /// Работает по типу конвейера: есть порядок вызова функций, при нарушении которого, ничего нормального не получится
    /// </summary>
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _maze;
        public void BuildDoor(int roomFrom, int roomTo)
        {
            var r1 = _maze.RoomNo(roomFrom);
            var r2 = _maze.RoomNo(roomTo);

            if (r1 == null || r2 == null)
                return;
            
            var door = new Door(r1, r2);
            SetDoorAtEmptyWall(r1, door);
            SetDoorAtEmptyWall(r2, door);
        }

        /// <summary>
        /// В примере метод называется CommonWall и определяет общую стену для двух комнат,
        /// но, т.к. у меня нет никаких правил построения лабиринта и комнаты могут быть соединены между собой трубками для хомяков,
        /// беру любую свободную стену и впихивает в нее стену.
        /// Не стала возвращать Direction, потому что не хочу бросать исключение, если все стены заняты
        /// </summary>
        /// <param name="room">Комната</param>
        private bool SetDoorAtEmptyWall(Room room, Door door)
        {
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                if (room.GetSide(direction) is Wall)
                {
                    room.SetSide(direction, door);
                    return true;
                }
            }

            return false;
        }

        public void BuildMaze()
        {
            _maze = new Maze();
        }

        public void BuildRoom(int number)
        {
            if (_maze.RoomNo(number) != null)
                return;

            var room = new Room(number);
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.South, new Wall());
        }

        public Maze GetMaze()
        {
            return _maze;
        }
    }
}
