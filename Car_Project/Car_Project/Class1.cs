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

        public void sredniapredkosc(int trasa, DateTime czas)
        {
            
            Console.WriteLine("Średnia predkosc = {0}", trasa / Convert.ToDouble(czas));
        }

        public void predkosctymczasowa(DateTime czas)
        {
            
            Console.WriteLine("Spalanie chwilowe = {0}",1/ Convert.ToDouble(czas));
        }
    }
}
