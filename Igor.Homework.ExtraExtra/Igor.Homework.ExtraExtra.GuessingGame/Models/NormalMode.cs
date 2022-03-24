using System;
using System.Collections.Generic;
using System.Text;

namespace Igor.Homework.ExtraExtra.GuessingGame.Models
{
    public class NormalMode
    {
        public int NumberOfTries = 7;
        public int CorrectNumber = new Random().Next(0,500);

        public NormalMode(int numberOfTries, int correctNumber)
        {
            NumberOfTries = numberOfTries;
            CorrectNumber = correctNumber;
        }
    }
}
