using System;
namespace MadameMaths
{
    public static class Answer
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
        public static double GetCorrectAnswer(double randomNumber1, string operatorSymbol, double randomNumber2)
        {
            double correctAnswer;
            switch (operatorSymbol)
            {
                case "+":
                    correctAnswer = randomNumber1 + randomNumber2;
                    break;
                case "-":
                    correctAnswer = randomNumber1 - randomNumber2;
                    break;
                case "*":
                    correctAnswer = randomNumber1 * randomNumber2;
                    break;
                case "/":
                    correctAnswer = Math.Round(randomNumber1 / randomNumber2, 0, MidpointRounding.AwayFromZero);
                    break;
                default:
                    throw new Exception("Operator not recognised.");
            }
            return correctAnswer;
        }
    }
}
