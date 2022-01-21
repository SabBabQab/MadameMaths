using System;
namespace MadameMaths
{
    public static class CorrectAnswer
    {
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
