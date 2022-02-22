using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbri vaid ühe korra.

            Console.WriteLine("Tere tulemast mängu!");

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;

            while(loopActive)
            {
                Console.WriteLine("Sisesta number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud! Palju õnne!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti.");
                }
            }

        }
    }
}
