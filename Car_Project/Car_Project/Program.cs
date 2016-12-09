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
           
            
            spala.czasstart = DateTime.Now;
            Console.Write("podaj czas w którym pokonałeś dystans w min: ");
            int time = Convert.ToInt32(Console.ReadLine());
            TimeSpan czas = TimeSpan.FromMinutes(time);
            Console.WriteLine("czas jazdy to {0}",Convert.ToString(czas));
            
            //Thread.Sleep(Convert.ToInt32(Console.ReadLine())*1000);
            spala.czasstop = DateTime.Now;
            Console.WriteLine(spala.czasstop - spala.czasstart);
            
            Car samo = new Car("Lancia ", "Lybra ", 1.8, 201);
            
            
            //List<Car> samochód = new List<Car>();
           // samochód.Add(new Car("Lancia ","Lybra ",1.8, 201));
            samo.wyswietl();


            //Console.WriteLine(samochód);

            
            // spala.sredniapredkosc(spala.trasa, spala.czasstop-spala.czasstart);

            Console.WriteLine(CzasPracy.TodayTime.TimeOfDay);
            Console.Write("Podaj długość trasy ");
            spala.trasa = Convert.ToInt32(Console.ReadLine());
            spala.sredniapredkosc(spala.trasa, time);
           // double x = Convert.ToDouble(Console.ReadLine());
            Random r = new Random(5);

            Console.WriteLine(r.Next(0,samo.PredkoscMax));


        }
    }
}
