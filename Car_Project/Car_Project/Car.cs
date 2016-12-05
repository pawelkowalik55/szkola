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
        public int PojemnoscBaku;

        public Car(string marka, string model, int pojemnoscbaku, double pojemnodcsilnika )
        {
            Marka = marka;
            Model = model;
            PojemnoscSilnika = pojemnodcsilnika;
            PojemnoscBaku = pojemnoscbaku;
        }

        public void wyswietl()
        {
            Console.WriteLine("Marka: {0}\nModel: {1}\nPojemnosc Silnika: {2}\nPojemnosc Baku: {3}",Marka,Model,PojemnoscSilnika,PojemnoscBaku);
        }
    }

}
