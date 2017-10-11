using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Song
    {
        private string title;
        private string bandName;
        private string tempo;
        private int numberOfBandMembers;
        private int radioPlay;
        private int chartRise;
        private int productionCost;

        public string Title { get;}
        public string Tempo { get; set; }

        public int ChartRise
        {
            get { return this.chartRise; }
            set { this.chartRise = value; }
        }


        public Song()
        {

        }

        public Song(string title, string bandName, int numberOfBandMembers, int productionCost, int radioPlay)
        {
            this.title = title;
            this.bandName = bandName;
            this.numberOfBandMembers = numberOfBandMembers;
            this.productionCost = productionCost;
            this.radioPlay = radioPlay;
            this.chartRise = 0;
        }

        public void HitSong()
        {
            chartRise = productionCost - radioPlay;
        }


    }
}
