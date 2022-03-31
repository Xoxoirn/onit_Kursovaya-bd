using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_ONIT_3.Entities
{
    class Treatment
    {

        public string NameOfProcedure
        {
            get; set;
        }
        public int Cost
        {
            get; set;
        }
     
        public double Duration
        {
            get; set;
        }
        public string Master
        {
            get; set;
        }
        public Treatment(Treatment treatment)
        {
            NameOfProcedure = treatment.NameOfProcedure;
            Cost = treatment.Cost;
            Duration = treatment.Duration;
            Master = treatment.Master;
        }
        public Treatment(string nameofprocedure, int cost, double duration, string master)
        {
            NameOfProcedure = nameofprocedure;
            Cost = cost;
            Duration = duration;
            Master = master;
        }
    }
}
