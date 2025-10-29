﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Objekty
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adres { get; set; }
        public char Pohlavie { get; set; }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public void AddName(string surname)
        {
            Name += surname;
        }

        public string vypisInfo()
        {
            return $"meno:  {Name} vek: {Age} Adressa: {Adres}"; 
        }
    }
}
