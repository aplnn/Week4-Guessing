using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhusliku numbri vaid ühe korra.

            Console.WriteLine("Tere tulemast mängu!");

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud! Palju õnne!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number, sul on {3 - i} katset jäänud.");

                    if (3 - i == 0)
                    {
                        Console.WriteLine("Oled mängu kaotanud, kahju.");
                    }

                }
            }

        }
    }
}
