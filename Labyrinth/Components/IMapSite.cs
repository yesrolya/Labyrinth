namespace Labyrinth.Components
{
    /// <summary>
    /// Общий абстрактный класс для всех компонентов лабиринта
    /// </summary>
    public interface IMapSite
    {
        /// <summary>
        /// Реакция среды на игровое действие - удалось или нет пройти дальше
        /// </summary>
        public bool Enter();
    }
}
