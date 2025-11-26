using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pravdepodobnost
{
    public class Student
    {
        public string Meno {  get; set; }
        public int TicketCount { get; set; }

        public Student(string meno, int ticketCount)
        {
            Meno = meno;
            TicketCount = ticketCount;
        }
    }
}
