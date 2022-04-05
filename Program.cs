using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(15);
            Names();


        }

        public static int RandomArray()
        {
            int[] RandArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                RandArray[i] = rand.Next(5, 25);
            }

            int sum = 0;
            foreach (int i in RandArray)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            return sum;
        }



        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            string[] TwoSides = {"Heads","Tails"};
            Random rand = new Random();
            string land = TwoSides[rand.Next(0,2)];
            Console.WriteLine(land);
            return land;
        }

        public static double TossMultipleCoins(int num)
        {
            double count = 0.0;
            for(int tosses = 1;tosses < num;tosses++)
            { 
                string landed = TossCoin();
                if(landed == "Heads"){
                    count++;
                }
            }
                Console.WriteLine(count);
                Console.WriteLine(num);
                double total =  count / num;
                Console.WriteLine(total);
                return total;
        }


        public static List<string> Names()
        {
            List<string> ListNames = new List<string>
            {
                "Todd","Tiffany","Charlie","Geneva","Sydney"
            };
            List<string> NewListNames = new List<string>();
            int count = ListNames.Count;
            while(count > 0)
            {
                count--;
                Random rand = new Random();
                int number = rand.Next(0,count + 1);
                if(ListNames[number].Length > 5)
                {
                NewListNames.Add(ListNames[number]);
                }
                ListNames.Remove(ListNames[number]);
            }

            foreach(string i in NewListNames)
            {
            Console.WriteLine(i);
            }
            return NewListNames;
        }
    }
}
