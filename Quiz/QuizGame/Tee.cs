using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    internal class Tee : Tietovisa
    {
        string vastaus;
        public bool teeVisailuTehty = false;
        public void Kysymykset()
        {
            //---------------------------------------//
            // kysymys 1 //
            Console.Clear();
            Console.WriteLine("Vihjeet: " + vihjeSaldo);
            Console.WriteLine("Kauanko vihreää irtoteetä pitää hauduttaa?\na) 5 minuuttia\nb) 2 minuuttia\nc) 30 sekuntia\nd) näytä vihje \nVastaus (a, b, c tai d): ");
            vastaus = Console.ReadLine();

            if (vastaus == "b")
            {
                kokonaispisteet++;

            }
            else if (vastaus == "d" && vihjeSaldo > 0)
            {
                Console.WriteLine("Vihje: Mustalle teelle 5 min käy\nVastaus: ");
                vastaus = Console.ReadLine();
                vihjeSaldo--;
                if (vastaus == "b") { kokonaispisteet++; }
            }
            else if (vastaus == "d" && vihjeSaldo == 0)
            {
                Console.WriteLine("Vihjeet on loppu\nVastaus: ");
                vastaus = Console.ReadLine();
                if (vastaus == "b") { kokonaispisteet++; }
            }
            Console.WriteLine("Pisteet: " + kokonaispisteet);
            Console.ReadLine();

            //---------------------------------------//
            // kysymys 2 //
            Console.Clear();
            Console.WriteLine("Vihjeet: " + vihjeSaldo);
            Console.WriteLine("Mikä on sopiva lämpötila vihreän irtoteen hauduttamiseen?\na) 60C\nb) 80C\nc) 100C\nd) näytä vihje \nVastaus (a, b, c tai d): ");
            vastaus = Console.ReadLine();

            if (vastaus == "a")
            {
                kokonaispisteet++;

            }
            else if (vastaus == "d" && vihjeSaldo > 0)
            {
                Console.WriteLine("Vihje: Alhaisempi lämpötila sopii vihreälle teelle\nVastaus: ");
                vastaus = Console.ReadLine();
                vihjeSaldo--;
                if (vastaus == "a") { kokonaispisteet++; }
            }
            else if (vastaus == "d" && vihjeSaldo == 0)
            {
                Console.WriteLine("Vihjeet on loppu\nVastaus: ");
                vastaus = Console.ReadLine();
                if (vastaus == "a") { kokonaispisteet++; }

            }
            Console.WriteLine("Pisteet: " + kokonaispisteet);
            Console.ReadLine();

            teeVisailuTehty = true;
        }

    }
}
