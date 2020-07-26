using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void PrintGame(Game Sudoko)
        {
            Console.WriteLine(Sudoko);
        }
        static void Main(string[] args)
        {
            Game Sudoko = new Game(
                "Sudoko", 1, 5.5f, "Japan");
            Game Football = new Game()
            {
                _name = "Football",
                _numberOfPlayers = 22,
                _originCountry = "Englnd",
                _rating = 5.5f,
            };
            Game Cards = new Game("Cards", 5.5f)
            {
                _originCountry = "China",
                _numberOfPlayers = 2,
            };
            Game chess = new Game("Chess", "China")
            {
                _numberOfPlayers = 2,
                _rating = 5.5f,
            };

        }

    }
}
