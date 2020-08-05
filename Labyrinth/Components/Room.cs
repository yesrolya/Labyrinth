using Labyrinth.Components.Properties;
using System.Collections.Generic;

namespace Labyrinth.Components
{
    /// <summary>
    /// Комната лабиринта
    /// </summary>
    public class Room: IMapSite
    {
        public bool Enter() => false;
        public void SetSide(Direction direction, IMapSite mapSite) 
        {
            if (Sides.ContainsKey(direction))
                Sides[direction] = mapSite;
            else
                Sides.Add(direction, mapSite);
        }

        public IMapSite GetSide(Direction direction) => Sides[direction];

        /// <summary>
        /// Уникальный номер комнаты в лабиринте
        /// </summary>
        public int RoomNumber { get; }
        /// <summary>
        /// Стены
        /// </summary>
        private IDictionary<Direction, IMapSite> Sides { get; set; } = new Dictionary<Direction, IMapSite>(SidesCount);

        private const int SidesCount = 4;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }
}
