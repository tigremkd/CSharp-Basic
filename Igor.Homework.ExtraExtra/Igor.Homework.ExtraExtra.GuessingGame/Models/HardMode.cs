using System;
using System.Collections.Generic;
using System.Text;

namespace Igor.Homework.ExtraExtra.GuessingGame.Models
{
    public class HardMode
    {
        public int NumberOfTries = 5;
        public int CorrectNumber = new Random().Next(0,1000);

        public HardMode(int numberOfTries, int correctNumber)
        {
            NumberOfTries = numberOfTries;
            CorrectNumber = correctNumber;
        }
    }
}
