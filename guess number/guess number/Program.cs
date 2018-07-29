using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            int num = Convert.ToInt32(Rnd.Next(1, 100));
            int guess = 1000;


            while (guess != num)
            {
                Console.Write("請輸入數字:");
                guess =Convert.ToInt32(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine("猜的數字太大囉!");
                    Console.WriteLine("");
                }

                if (guess < num)
                {
                    Console.WriteLine("猜的數字太小囉!");
                    Console.WriteLine("");
                }

                if (guess == num)
                {
                    Console.WriteLine("恭喜你猜對囉!");
                    Console.WriteLine("");
                }
            }
            

            
        }
    }
}
