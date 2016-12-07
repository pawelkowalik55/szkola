using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    class SredniaPredkosc
    {
        public double trasa;
        public double czas;

        public void sredniapredkosc(double trasa, double czas)
        {
            Console.WriteLine("Średnia predkosc = {0}", trasa / czas);
        }

        public void predkosctymczasowa(double czas)
        {
            Console.WriteLine("Spalanie chwilowe = {0}",1/czas);
        }
    }
}
