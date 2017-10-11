using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Song shake = new Song("Shake", "The Martians", 5, 1000, 200);
            
            shake.HitSong();
            Console.WriteLine(shake.ChartRise);

        }
    }
}
