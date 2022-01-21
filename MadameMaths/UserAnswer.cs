using System;
namespace MadameMaths
{
    public static class UserAnswer
    {
        public static double GetUserAnswer(double randomNumber1, string userOperatorSymbol, double randomNumber2)
        {
            Console.WriteLine($"What's {randomNumber1} {userOperatorSymbol} {randomNumber2}?");
            string answer = Console.ReadLine();
            double finalAnswer;
            double.TryParse(answer, out finalAnswer);
            return finalAnswer;
        }
        public static int CheckUserAnswer(double correctAnswer, double finalAnswer, int score)
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
