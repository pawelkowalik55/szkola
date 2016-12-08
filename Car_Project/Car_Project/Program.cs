using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            SredniaPredkosc spala = new SredniaPredkosc();
            Console.Write("podaj dlugosc trasy w metrach: ");


            spala.trasa = Convert.ToInt32(Console.ReadLine());
            spala.czasstart = DateTime.Now;
            Thread.Sleep(10000);
            spala.czasstop = DateTime.Now;
            Console.WriteLine(spala.czasstop - spala.czasstart);
            Car samo = new Car("Lancia ", "Lybra ", 60, 1.8);
            samo.wyswietl();
            List<Car> samochód = new List<Car>();
            samochód.Add(new Car("Lancia ","Lybra ",60,1.8));
            
            //Console.WriteLine(samochód);
            
            
           // spala.sredniapredkosc(spala.trasa, spala.czasstop-spala.czasstart);
            
            Console.WriteLine(CzasPracy.TodayTime.TimeOfDay);
            Console.Write("Podaj długość trasy ");

           // double x = Convert.ToDouble(Console.ReadLine());
            Random r = new Random(5);

            Console.WriteLine(r.Next(0,407));


        }
    }
}
