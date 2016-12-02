using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            SredniaPredkosc spala = new SredniaPredkosc();
            spala.trasa = 120;
            spala.czas = 1.5;
            spala.sredniapredkosc(spala.trasa, spala.czas);
            Console.WriteLine(CzasPracy.TodayTime);


        }
    }
}
