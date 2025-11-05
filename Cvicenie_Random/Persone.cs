using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Random
{
    public class Persone
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Persone(string nameParam, string surnameParam)
        {
            Name = nameParam;
            Surname = surnameParam;
        }
        public void VypisSa()
        {
            Console.WriteLine("Volam sa: "+Name+" "+Surname);
        }
    }
}
