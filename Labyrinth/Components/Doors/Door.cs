namespace Labyrinth.Components.Doors
{
    /// <summary>
    /// Обычная дверь
    /// </summary>
    public class Door: AbstractDoor
    {
        public override bool Enter() => false;

        public override Room OtherSideFrom(Room someRoom) => null;

        public Door(Room roomFrom, Room roomTo): base(roomFrom, roomTo) { }
    }
}
