using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region  zajecia
            //string CarName = "moj samochod";
            /* car car1 = new car("Lancia",2000);
             car car2 = new car("VW",2003);
             Console.WriteLine("zad1");
             car1.pokaz();
             car2.pokaz();
             Console.WriteLine("zad2");
             car1 = car2;
             car1.pokaz();
             car2.pokaz();
             Console.ReadLine();
             Console.WriteLine("podaj marke");
             string a = Console.ReadLine();



             for (;;)
             {
                 Console.WriteLine("podaj rok produkcji");
                 int b = Convert.ToInt32(Console.ReadLine());

                 if (b > 1875 && b < 2016)
                 {
                     car car3 = new car(a, b);
                     car3.pokaz();
                     break;
                 }
                 else Console.WriteLine("zly rok produkcji");

             }

     */

            #endregion

            //1.stworzyc 2 zmienna ref o nazwie car2 typu car przypisac jej dowolne wartosci i wyswietlic na ekranie
            //2.przypisac do siebie wartosci car1 i car2 i ponownie sprawdzic na ekranie jakie wartosci beda wyswietlone
            //3.uzupełnić program tak aby przy wprowadzaniu roku produkcji weryfikowana była jego poprawność ustalić ograniczenie dolne 


            //4. utworzyc prywatne pola klasy car o nazwie 
            // - model
            // - iloscDrzwi
            // - pojemnoscSilnika
            // - srednieSpalanie
            // - narysowac diagram uml dalej robota na diagramie
            // utworzyc wlasciwosci dostepowe dla wszystkich pol w klasie car
            // utworzyc w klasie car prywatne statyczne pole typu int o nazwie ilosc samochodu i przypisac wartosc 0
            // utworzyc prywatna metode obliczSpalanie zwracajaca typu double i przyjmujacej parametr dlugosc trasy typu double
            // metoda ta ma obliczac spalanie samochodu na podstawie podanej wartosci dlugosci trasy i wartosci pola srednie spalanie wg wzoru spalanie = (srednieSpalanie*dlugoscTrasy)/100.0
            //utworzyc publiczna metode oblicz koszt przejazdu zwracajacej wartosc double i przyjmujacej parametry dlugosc trasy typu double i cena paliwa typu double
            //metoda ta ma obliczac koszt przejazdu na trasie o podanej dlugosci zakladajac podana cene paliwa za litr
            //metoda ta ma wykorzystywac prywatna metode obliczSpalanie
            //koszt przejazdu oblicza sie wg wzoru kosztPrzejazdu = obliczSpalanie*cenaPaliwa
        }
    }
}
