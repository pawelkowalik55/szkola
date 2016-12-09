using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    class SredniaPredkosc
    {
        public int trasa;
        public DateTime czasstart;
        public DateTime czasstop;
        public double czas;

        public void sredniapredkosc(int trasa, double czas)
        {
            
            Console.WriteLine("Średnia predkosc: {0}", trasa / (czas/60.0));
        }

        public void predkosctymczasowa(double czas)
        {
            
            Console.WriteLine("Spalanie chwilowe = {0}",1/ czas);
        }
    }
}
