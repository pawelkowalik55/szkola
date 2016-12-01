using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class car
    {
        private string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int ilosc = 0;

        public car(string Marka, int Rok, string Model, int drzwi, int pojemnosc, double spalanie)
        {
            marka = Marka;
            rokProdukcji = Rok;
            model = Model;
            iloscDrzwi = drzwi;
            pojemnoscSilnika = pojemnosc;
            srednieSpalanie = spalanie;

        }

        public void pokaz()
        {
            Console.WriteLine("marka samochodu {0} \n rok produkcji {1}", marka, rokProdukcji);
            return;
        }

        private double obliczSpalanie(double sredniespalanie, double dlugosctrasy)
        {
            double spalanie = (sredniespalanie*dlugosctrasy)/100.0;
            return spalanie;
        }

        public double kosztPrzejazdu(double cenaPaliwa,double dlugosctrasy)
        {
            double kosztprzejazdu = obliczSpalanie(srednieSpalanie,dlugosctrasy)*cenaPaliwa;

            return kosztprzejazdu;
        }
        //utworzyc publiczna metode oblicz koszt przejazdu zwracajacej wartosc double i przyjmujacej parametry dlugosc trasy typu double i cena paliwa typu double
        //metoda ta ma obliczac koszt przejazdu na trasie o podanej dlugosci zakladajac podana cene paliwa za litr
        //metoda ta ma wykorzystywac prywatna metode obliczSpalanie
        //koszt przejazdu oblicza sie wg wzoru kosztPrzejazdu = obliczSpalanie*cenaPaliwa

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public int Rok
        {
            get { return rokProdukcji; }
            set
            {
                if (value > 1880 && value < 2016)
                {
                    Rok = value;
                }
                else
                {
                    Console.WriteLine("zly rok");
                }
            }
        }

        public string Model
        {
            get { return marka; }
            set { marka = value; }
        }

        public int Drzwi
        {
            get { return iloscDrzwi; }
            set { Drzwi = value; }
        }
        public int Silnik
        {
            get { return pojemnoscSilnika; }
            set { Silnik = value; }
        }
        public double Spalanie
        {
            get { return srednieSpalanie; }
            set { Spalanie = value; }
        }
    }
}
