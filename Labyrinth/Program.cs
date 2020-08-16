using Labyrinth.Game;
using Labyrinth.Game.Builder;
using Labyrinth.Game.Factory;
using Labyrinth.Game.FactoryMethod;
using System;

namespace Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new MazeFactory();
            var patternFactory = new MazeGameFactory(factory).CreateLabyrinth();

            var builder = new StandardMazeBuilder();
            var patternBuilder = new MazeGameBuilder(builder).CreateLabyrinth();

            var patternFactoryMethod = new MagicMazeGameFactoryMethod().CreateLabyrinth();
        }
    }
}
