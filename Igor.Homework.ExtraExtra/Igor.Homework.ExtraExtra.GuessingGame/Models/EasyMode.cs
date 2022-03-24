using System;
using System.Collections.Generic;
using System.Text;

namespace Igor.Homework.ExtraExtra.GuessingGame.Models
{
    public class EasyMode
    {
        public int NumberOfTries = 9;
        public int CorrectNumber = new Random().Next(0,100);

        public EasyMode(int numberOfTries, int correctNumber)
        {
            NumberOfTries = numberOfTries;
            CorrectNumber = correctNumber;
        }

    }
}
