using System;
using Igor.Homework.ExtraExtra.GuessingGame.Models;

namespace Igor.Homework.ExtraExtra.GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int winNum = new Random().Next(0,100);
            int guessNum = 0;
            int numOfGuesses = 9;
            Console.WriteLine("Enter mode : 1-easy, 2-normal , 3-hard");
            string choosedMode = Console.ReadLine();
            if(choosedMode == "1")
            {
                while (guessNum != winNum)
                {
                    Console.WriteLine("Enter your guess number:");
                    guessNum = Convert.ToInt32(Console.ReadLine());
                    if(guessNum == winNum) 
                    {
                        Console.WriteLine("Ding ding ding You guessed right.");
                    }
                    //else if(guessNum - winNum >= 50)
                    //{
                    //    Console.WriteLine("Your guess is waaay to high");
                    //}
                    //else if (guessNum - winNum <= 50)
                    //{
                    //    Console.WriteLine("Your guess is waay to low");
                    //}
                    else if(guessNum - winNum >= 10)
                    {
                        Console.WriteLine("Your guess is abit higher");
                    }
                    else if(guessNum - winNum <= 10)
                    {
                        Console.WriteLine("Your guess is abit lower");
                    }
                    numOfGuesses--;
                }
            }
            
        }
    }
}
