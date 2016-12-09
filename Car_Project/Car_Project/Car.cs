using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Project
{
    class Car
    {
        public string Marka;
        public string Model;
        public double PojemnoscSilnika;
        public int PredkoscMax;
        

        public Car(string marka, string model, double pojemnodcsilnika, int predkoscmax )
        {
            Marka = marka;
            Model = model;
            PojemnoscSilnika = pojemnodcsilnika;
            PredkoscMax = predkoscmax;

        }

        public void wyswietl()
        {
            Console.WriteLine("Marka: {0}\nModel: {1}\nPojemnosc Silnika: {2}\n",Marka,Model,PojemnoscSilnika);
        }
    }

}
