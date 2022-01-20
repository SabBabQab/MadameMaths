using System;
namespace MadameMaths
{
    public static class SolveForAnswer
    {
        public static double SolvingAnswer(double randomNumber, string op, double otherRandomNumber)
        {
            double correctAnswer;
            switch (op)
            {
                case "+":
                    correctAnswer = randomNumber + otherRandomNumber;
                    break;
                case "-":
                    correctAnswer = randomNumber - otherRandomNumber;
                    break;
                case "*":
                    correctAnswer = randomNumber * otherRandomNumber;
                    break;
                case "/":
                    correctAnswer = Math.Round(randomNumber / otherRandomNumber, 0, MidpointRounding.AwayFromZero);
                    break;
                default:
                    throw new Exception("Operator not recognised.");
            }
            return correctAnswer;
        }
    }
}
