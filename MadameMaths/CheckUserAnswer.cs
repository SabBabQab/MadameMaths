using System;
namespace MadameMaths
{
    public static class GiveSolution
    {
        public static int WrongOrRight(double correctAnswer, double danswer, int score)
        {
            if (danswer == correctAnswer)
            {
                Console.WriteLine("CORRECT!");
                score++;
            }
            else
            {
                Console.WriteLine($"WRONG! The answer is {correctAnswer}");
            }

            return score;
        }
    }
}
