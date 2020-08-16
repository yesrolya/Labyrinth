using Labyrinth.Components;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth.Schema
{
    /// <summary>
    /// Лабиринт
    /// </summary>
    public class Maze
    {
        private IList<Room> Rooms { get; set; } = new List<Room>();

        /// <summary>
        /// Добавить комнату в лабиринт
        /// </summary>
        /// <param name="room">Комната</param>
        public void AddRoom(Room room) 
        {
            Rooms.Add(room);
        }

        /// <summary>
        /// Получить комнату по номеру
        /// </summary>
        /// <param name="roomNumber">Номер комнаты</param>
        public Room RoomNo(int roomNumber)
        {
            return Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
}
