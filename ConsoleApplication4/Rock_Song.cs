using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Rock_Song : Song
    {
        private int quality;


        public Rock_Song()
        {

        }

        public void ChartDrop()
        {
            quality = moneyMade - 100000;
        }

        public void RockFight()
        {
            numberOfBandMembers = -2;
        }

        public override void HitSong()
        {
            chartRise = quality;
        }
    }
}
   

