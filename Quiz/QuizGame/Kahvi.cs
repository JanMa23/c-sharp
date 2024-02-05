using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    internal class Kahvi : Tietovisa
    {

        string vastaus;
       
        public bool kahviVisailuTehty = false;

       public void Kysymykset()
        {

            //---------------------------------------//
            // kysymys 1 //
            Console.Clear();
            Console.WriteLine("Vihjeet: " + vihjeSaldo );
            Console.WriteLine("Montako mitallista kahvia annostellaan per kuppi?\na) 1\nb) 1,5\nc) 2\nd) näytä vihje \nVastaus (a, b, c tai d): ");
            vastaus = Console.ReadLine();

            if (vastaus == "a")
            {
                kokonaispisteet++;

            }
            else if (vastaus == "d" && vihjeSaldo > 0)
            {
                Console.WriteLine("Vihje: yleensä annostelu on mitallinen per kuppi\nVastaus: ");
                vastaus = Console.ReadLine();
                vihjeSaldo--;
                if (vastaus == "a") { kokonaispisteet++; }
            }
            else if (vastaus == "d" && vihjeSaldo == 0) { 
                Console.WriteLine("Vihjeet on loppu\nVastaus: ");
                vastaus = Console.ReadLine();
                if (vastaus == "a") { kokonaispisteet++; }

            }
            Console.WriteLine("Pisteet: " + kokonaispisteet);
            Console.ReadLine();


            //---------------------------------------//
            // kysymys 2 //
            Console.Clear();
            Console.WriteLine("Vihje: " + vihjeSaldo);
            Console.WriteLine("Mikä on kofeiinin kemiallinen kaava?\na) H1N1\nb) H2O\nc) C8H10N4O2\nd) näytä vihje\nVastaus (a, b, c tai d): ");
            vastaus = Console.ReadLine();

            if (vastaus == "c")
            {
                kokonaispisteet++;

            }
            else if (vastaus == "d" && vihjeSaldo > 0)
            {
                Console.WriteLine("Vihje: H1N1 taitaa olla sikainfluenssa\nVastaus: ");
                vastaus = Console.ReadLine();
                vihjeSaldo--;
                if (vastaus == "c") { kokonaispisteet++; }
            }
            else if (vastaus == "d" && vihjeSaldo == 0) {
                Console.WriteLine("Vihjeet on loppu\nVastaus: ");
                vastaus = Console.ReadLine();
                if (vastaus == "c") { kokonaispisteet++; }

            }
            Console.WriteLine("Pisteet: " + kokonaispisteet);
            Console.ReadLine();


            //---------------------------------------//
            // kysymys 3 //
            Console.Clear();
            Console.WriteLine("Vihje: " + vihjeSaldo);
            Console.WriteLine("Mihin kahvijuomista maitovaahto ei kuulu?\na) Capuccino\nb) Musta kahvi\nc) Latte\nVastaus (a, b tai c): ");
            vastaus = Console.ReadLine();

            if (vastaus == "b")
            {
                kokonaispisteet++;

            }
            else if (vastaus == "d" && vihjeSaldo > 0)
            {
                Console.WriteLine("Vihje: Maitokahvitaidetta tehdään usein latteen\nVastaus: ");
                vastaus = Console.ReadLine();
                vihjeSaldo--;
                if (vastaus == "b") { kokonaispisteet++; }
            }
            else if (vastaus == "d" && vihjeSaldo == 0) { Console.WriteLine("Vihjeet on loppu"); }
            Console.WriteLine("Pisteet: " + kokonaispisteet);
            Console.ReadLine();

            kahviVisailuTehty = true;


        }
    }
}
