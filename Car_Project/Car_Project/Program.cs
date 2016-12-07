using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            Car samo = new Car("Lancia ", "Lybra ", 60, 1.8);
            samo.wyswietl();
            List<Car> samochód = new List<Car>();
            samochód.Add(new Car("Lancia ","Lybra ",60,1.8));
            
            //Console.WriteLine(samochód);
            
            
            spala.sredniapredkosc(spala.trasa, spala.czas);
            
            Console.WriteLine(CzasPracy.TodayTime.TimeOfDay);
            Console.Write("Podaj długość trasy ");

            double x = Convert.ToDouble(Console.ReadLine());
            Random r = new Random(5);

            Console.WriteLine(r.Next(0,407));


        }
    }
}
