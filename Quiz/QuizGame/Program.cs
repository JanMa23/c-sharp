using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Kahvi kahviKysymys = new Kahvi();
            Tee teeKysymys = new Tee();
            

            

            Console.WriteLine("Pelaa tietovisaa! \nValitse aihealue:\n1. Kahvi\n2. Tee\nValinta (1 tai 2): ");
            string aihe = Console.ReadLine();

            

            while (aihe != "1" && aihe != "2")
            {
                Console.WriteLine("Pelaa tietovisaa! \nValitse aihealue:\n1. Kahvi\n2. Tee\nValinta (1 tai 2): ");
                aihe = Console.ReadLine();
            }
            
            if (aihe == "1")
            {
                kahviKysymys.Kysymykset();
            } 
            else if (aihe == "2")
            {
                teeKysymys.Kysymykset();
            } 
          

            //---------------------------------------//
            // Tarjoa toista visaa, kun ensimmäinen tehty //
                    

            if (teeKysymys.teeVisailuTehty == true)
            {
                Console.WriteLine("Pisteet: " + teeKysymys.kokonaispisteet);
                Console.WriteLine("a) Jatka tietovisaa aiheella kahvi \nb) Lopeta\nVastaus (a tai b):");
                string vastaus = Console.ReadLine();

                if (vastaus == "a") {
                    
                    kahviKysymys.Kysymykset(); }

            }
            else if (kahviKysymys.kahviVisailuTehty == true)
            {
                Console.WriteLine("Pisteet: " + kahviKysymys.kokonaispisteet);
                Console.WriteLine("a) Jatka tietovisaa aiheella tee \nb) Lopeta\nVastaus (a tai b):");
                string vastaus = Console.ReadLine();

                if (vastaus == "a") {
                   
                    teeKysymys.Kysymykset(); }

            }

            //---------------------------------------//

            //---------------------------------------//
            // Lopputulos
            Console.Clear();
            int tulos = kahviKysymys.kokonaispisteet + teeKysymys.kokonaispisteet;
            Console.WriteLine($"Tietovisa loppui, sait yhteensä {tulos} pistettä.");

            //---------------------------------------//



        }

        
        
    }
}
