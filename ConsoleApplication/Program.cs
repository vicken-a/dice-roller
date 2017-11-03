using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var roller = new DiceRoller();

            int[] Numbers = new int[6]; // [0,0,0,0,0,0] [1,2,3,4,5,6]

            CheckValueInRange(roller, Numbers);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("You Rolled {0} {1} times", i+1, Numbers[i]);
            }
        }

        private static void CheckValueInRange(DiceRoller roller, int[] Numbers)
        {
            for (int i = 0; i < 1000; i++)
            {
                var roll = roller.Roll();

                if (!IsBetweenOneAndSix(roll))
                {
                    throw new Exception("Not Between 1 and 6)");
                }

                Numbers[roll-1]++;
            }
        }

        static bool IsBetweenOneAndSix(int num)
        {
            return num >= 1 && num <= 6;
        }
    }


    internal class DiceRoller
    {
        Random rand = new Random();
        Random rand2 = new Random();
        
        public int Roll()
        {
            if(rand2.Next(1,4)==3){
                return 6;
            }
            return rand.Next(1, 7);
        }
    }
}

