namespace Labyrinth.Components
{
    public class Door: IMapSite
    {
        public bool Enter() => false;

        public Room OtherSideSideFrom(Room someRoom) => null;

        private Room RoomFrom { get; set; }
        private Room RoomTo { get; set; }
        private bool IsOpen { get; set; }

        public Door(Room roomFrom, Room roomTo)
        {
            RoomFrom = roomFrom;
            RoomTo = roomTo;
        }
    }
}
