using System;
namespace MadameMaths
{
    public static class CheckUserAnswer
    {
        public static int CheckingUserAnswer(double correctAnswer, double finalAnswer, int score)
        {
            if (finalAnswer == correctAnswer)
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
