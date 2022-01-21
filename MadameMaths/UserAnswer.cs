using System;
namespace MadameMaths
{
    public static class UserAnswer
    {
        public static double GettingUserAnswer(double randomNumber1, string userOperatorSymbol, double randomNumber2)
        {
            Console.WriteLine($"What's {randomNumber1} {userOperatorSymbol} {randomNumber2}?");
            string answer = Console.ReadLine();
            double finalAnswer;
            double.TryParse(answer, out finalAnswer);
            return finalAnswer;
        }
    }
}
