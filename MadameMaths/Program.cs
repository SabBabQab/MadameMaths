using System;
namespace MadameMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");
            string difficulty = UserPreferences.GetDifficulty();
            int numberOfQuestions = UserPreferences.GetNumberOfQuestions();
            int score = GamePlay.PlayGameBasedOnDifficulty(difficulty, numberOfQuestions);
            Console.WriteLine($"Your score is {score}/{numberOfQuestions}");
        }
    }
}