using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    public class Dice
    {
        private int Number {  get; set; }

        public int PlayDice()
        {
            var numberPlayed = new Random().Next(1, 6);
            Number = numberPlayed;
            return Number;
        }
    }
}