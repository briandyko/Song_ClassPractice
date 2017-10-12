using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Dance_Song : Song
    {
        private string annoyingLevel;

        public string AnnoyingLevel { get; set; }

        public Dance_Song()
        {

        }


        public Dance_Song(string title, string bandName, int numberOfBandMembers, int productionCost, int radioPlay, string annoyingLevel) : base("very very fast")
        {
            this.title = title;
            this.bandName = bandName;
            this.productionCost = productionCost;
            this.radioPlay = radioPlay;
            this.annoyingLevel = annoyingLevel;
        }

        public void StopMakingSense()
        {
            if (annoyingLevel == "very annoying")
            {
                ChartRise = 100; 
            }
            
        }

        public void Millionaires()
        {
            moneyMade = radioPlay * 1000000000;
        }
            
        public override void HitSong()
        {
            chartRise = 1000*(productionCost - radioPlay);
        }

            
    }
    }

