using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_ONIT_3.Entities
{
    public class Client
    {
        public string FIO
        {
            get; set;
        }
        public string TelNum
        {
            get; set;
        }
        public Client(Client client)
        {
            FIO = client.FIO;
            TelNum = client.TelNum;
        }
        public Client(string fio, string telnum)
        {
            FIO = fio;
            TelNum = telnum;
        }
    }
}
