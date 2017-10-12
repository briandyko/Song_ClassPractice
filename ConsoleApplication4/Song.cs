using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Song
    {
        protected string title;
        protected string bandName;
        protected string tempo;
        protected int numberOfBandMembers;
        protected int radioPlay;
        protected int chartRise;
        protected int productionCost;
        protected int moneyMade;

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

        public Song(string tempo)
        {
            this.tempo = tempo;
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

        public virtual void HitSong()
        {
            chartRise = productionCost - radioPlay;
        }


    }
}
