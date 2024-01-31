using System.Diagnostics;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string vastaus;
            int kokonaispisteet = 0;

            Console.WriteLine("Pelaa tietovisaa! \nValitse aihealue:\n1. Kahvi\n2. Tee\nValinta (1 tai 2): ");
            string aihe = Console.ReadLine();

            if (aihe == "1")
            {


                Console.WriteLine("Montako mitallista kahvia annostellaan per kuppi?\na) 1\nb) 1,5\nc) 2\nVastaus (a, b tai c): ");
                vastaus = Console.ReadLine();

                if (vastaus == "a")
                {
                    kokonaispisteet++;

                }
                Console.WriteLine("Pisteet: " + kokonaispisteet);

                Console.WriteLine("Mikä on kofeiinin kemiallinen kaava?\na) H1N1\nb) H2O\nc) C8H10N4O2\nVastaus (a, b tai c): ");
                vastaus = Console.ReadLine();

                if (vastaus == "c")
                {
                    kokonaispisteet++;

                }
                Console.WriteLine("Pisteet: " + kokonaispisteet);


                

            } else if (aihe == "2")
            {
               
                Console.WriteLine("Kauanko vihreää irtoteetä pitää hauduttaa?\na) 5 minuuttia\nb) 2 minuuttia\nc) 30 sekuntia\nVastaus (a, b tai c): ");
                vastaus = Console.ReadLine();

                if (vastaus == "b")
                {
                    kokonaispisteet++;

                }
                Console.WriteLine("Pisteet: " + kokonaispisteet);


                Console.WriteLine("Mikä on sopiva lämpötila vihreän irtoteen hauduttamiseen?\na) 60C\nb) 80C\nc) 100C\nVastaus (a, b tai c): ");
                vastaus = Console.ReadLine();

                if (vastaus == "a")
                {
                    kokonaispisteet++;

                }
                Console.WriteLine("Pisteet: " + kokonaispisteet);


            } else
            {
                Console.WriteLine("tööt");
            }

            try { 

            Console.WriteLine("Muunna Celsiusasteet Fahrenheitiksi");
            Console.Write("Celsius: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            muunninCelsius(num1);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try { 

            Console.WriteLine("Muunna kilometrit maileiksi\nKM: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            muunninKilometri(num1);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {

            Console.WriteLine("Muunna kilogrammat nauloiksi\nKG: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            muunninKilogramma(num1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();


        }

        static void muunninCelsius (double num1)
        {
            double tulos;

            //muunna celcius fahrenheitiksi
            tulos = num1 * 1.8 + 32;
            Console.WriteLine($"{num1} c on {tulos} f");

            
        }

        static void muunninKilometri(double num1)
        {
            double tulos;
            //muunna kilometri mailiksi
            tulos = num1 * 0.62;
            Console.WriteLine($"{num1} km on {tulos} mailia");
        }

        static void muunninKilogramma(double num1)
        {
            double tulos;
            //muunna kilogrammat nauloiksi
            tulos = num1 * 2.2;
            Console.WriteLine($"{num1} kg on {tulos} naulaa (lbs)");
        }
        
    }
}
