using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    public class Player
    {
        private int Number { get; set; }

        public int SetNumberFromPlayer()
        {
            bool success;
            do
            {
                Console.WriteLine("Guess the number trow from the dice");
                var numberFromPlayer = Console.ReadLine();
                int numberFromPlayerInt;
                if (int.TryParse(numberFromPlayer, out numberFromPlayerInt))
                {
                    success = true;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                    success = false;
                }
                Number = numberFromPlayerInt;
            } while (success == false);
            return Number;
        }

        public void GetNumberFromPlayer()
        {
            Console.WriteLine($"The number is {Number}");
        }
    }
}
