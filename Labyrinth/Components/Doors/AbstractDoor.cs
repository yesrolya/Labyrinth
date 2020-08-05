namespace Labyrinth.Components.Doors
{
    /// <summary>
    /// Класс дверей
    /// </summary>
    public abstract class AbstractDoor: IMapSite
    {
        public abstract bool Enter();

        public abstract Room OtherSideFrom(Room someRoom);

        protected Room RoomFrom { get; set; }

        protected Room RoomTo { get; set; }

        public bool IsOpen { get; set; }

        public AbstractDoor(Room roomFrom, Room roomTo)
        {
            RoomFrom = roomFrom;
            RoomTo = roomTo;
        }
    }
}
