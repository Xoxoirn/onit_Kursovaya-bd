using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_ONIT_3.Entities
{
    class LogOfRecords
    { 
        public int N
        {
            get; set;
        }
        public string Telephone
        {
            get; set;
        }

        public DateTime DateAndTime
        {
            get; set;
        }


        public string NameOfT
        {
            get; set;
        }

        public LogOfRecords(LogOfRecords logOfRecords)
        {
            N = logOfRecords.N;
            Telephone = logOfRecords.Telephone;
            DateAndTime = logOfRecords.DateAndTime;
            
            NameOfT = logOfRecords.NameOfT;
        }
        public LogOfRecords(int n, string telephone, DateTime dateandtime, string nameOfT)
        {
            N = n;
            Telephone = telephone;
            DateAndTime = dateandtime;
             NameOfT = nameOfT;
        }
    }
}
