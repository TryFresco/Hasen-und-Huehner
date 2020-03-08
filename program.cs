using System;

namespace SortingExample

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Bitte geben Sie jetzt die Anzahl Tiere ein");

            string Tier = Console.ReadLine();

            int Tiere = Convert.ToInt32(Tier);

            Console.WriteLine("Bitte geben Sie jetzt noch die Anzahl Beine ein, die Sie gezählt haben, Sie Dummkopf von einem Bauer. Danke!");

            string Bein = Console.ReadLine();

            int Beine = Convert.ToInt32(Bein);

 

            int pruefer = Beine % 2;

 

            while (pruefer == 1 || (2 * Tiere) >= Beine || Tiere < 1)

            {

                Console.WriteLine("Ihre Eingabe ist ungültig");

                Console.WriteLine("Bitte geben Sie jetzt die Anzahl Tiere ein");

                Tier = Console.ReadLine();

                Tiere = Convert.ToInt32(Tier);

                Console.WriteLine("Bitte geben Sie jetzt noch die Anzahl Beine ein, die Sie gezählt haben, Sie Dummkopf von einem Bauer. Danke!");

                Bein = Console.ReadLine();

                Beine = Convert.ToInt32(Bein);

 

                pruefer = Beine % 2;

 

 

            }

 

            int Hase = Tiere;

            int Huhn = 0;

            int Vorschlag = 0;

            bool Richtig = false;

 

            while (Richtig == false)

            {

 

                Vorschlag = Hase * 4 + Huhn * 2;

 

                if (Vorschlag < Beine || Vorschlag > Beine)

                {

                    Hase = Hase - 1;

                    Huhn = Huhn + 1;

                }

                else

                {

                    Richtig = true;

                }

            }

 

            Console.WriteLine("Hasen: " + Hase + " Huhn: " + Huhn);

            Console.ReadKey();

        }

    }

}
