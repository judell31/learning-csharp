using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * HandsOn
             */
            bool isSunny = false;
            String wear = "Wear sunglasses!";
            String dontWear = "You don't need to wear sunglasses.";

            bool atTheBeach = true;
            String sunblock = "Sunblcok is a good idea.";
            String noSunblock = "Sunblock isn't needed.";

            bool goAnyway = true;
            String going = "Awesome! Glad you don't mind clouds!";
            String nextTime = "No worries! Hopefully next time we will have some sun!";

            if (isSunny)
            {
                Console.WriteLine(wear);
                if(atTheBeach)
                {
                    Console.WriteLine(sunblock);
                }
                else
                {
                    Console.WriteLine(noSunblock);
                }
            }
            else
            {
                Console.WriteLine(dontWear);
                if (goAnyway)
                {
                    Console.WriteLine(going);
                }
                else
                {
                    Console.WriteLine(nextTime);
                }
            }
        }

        /*
         * If else statments
         */
        public static void conditionals()
        {
            int multi = 2 * 3;

            if (multi == 56566)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
