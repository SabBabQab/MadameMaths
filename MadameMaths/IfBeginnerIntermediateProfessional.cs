using System;
namespace MadameMaths
{
    public static class IfBeginnerIntermediateProfessional
    {
        public static int IfBeginnerIntermediateProfessionalAction(string level, int questionNumber)
        {
            int score = 0;
            if (level == "Beginner")
            {
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    // Try making into class
                    Random random = new Random();
                    (string op, string userOp) = RandomOperatorGenerator.GetOperator(random, 3);

                    (double randomNumber, double otherRandomNumber) = RandomNumberGenerator.GenerateNumber(op, 10, 51, 0, 1000, random);
                    double danswer = AskAndReceiveAnswer.AskingAndReceiving(randomNumber, userOp, otherRandomNumber);
                    double correctAnswer = SolveForAnswer.SolvingAnswer(randomNumber, op, otherRandomNumber);
                    score = GiveSolution.WrongOrRight(correctAnswer, danswer, score);
                }
            }
            else if (level == "Intermediate")
            {
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    Random random = new Random();
                    (string op, string userOp) = RandomOperatorGenerator.GetOperator(random, 4);

                    (double randomNumber, double otherRandomNumber) = RandomNumberGenerator.GenerateNumber(op, 10, 51, 0, 1000, random);
                    double danswer = AskAndReceiveAnswer.AskingAndReceiving(randomNumber, userOp, otherRandomNumber);
                    double correctAnswer = SolveForAnswer.SolvingAnswer(randomNumber, op, otherRandomNumber);
                    score = GiveSolution.WrongOrRight(correctAnswer, danswer, score);

                }

            }

            else
            {
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    Random random = new Random();
                    (string op, string userOp) = RandomOperatorGenerator.GetOperator(random, 4);

                    (double randomNumber, double otherRandomNumber) = RandomNumberGenerator.GenerateNumber(op, 20, 1000, 0, 1000, random);
                    double danswer = AskAndReceiveAnswer.AskingAndReceiving(randomNumber, userOp, otherRandomNumber);
                    double correctAnswer = SolveForAnswer.SolvingAnswer(randomNumber, op, otherRandomNumber);
                    score = GiveSolution.WrongOrRight(correctAnswer, danswer, score);
                }
            }
            return score;
        }
    }
}
