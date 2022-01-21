﻿using System;
namespace MadameMaths
{
    public static class GamePlay
    {
        public static int PlayingGameBasedOnDifficulty(string difficulty, int numberOfQuestions)
        {
            Random random = new Random();
            int score = 0;
            if (difficulty == "Beginner")
            {
                for (int q = 1; q < numberOfQuestions + 1; q++)
                {
                    (string operatorSymbol, string userOperatorSymbol) = RandomOperatorGenerator.GetOperator(random, 3);

                    (double randomNumber1, double randomNumber2) = RandomNumberGenerator.GenerateNumber(operatorSymbol, 10, 51, 0, 1000, random);
                    double finalAnswer = UserAnswer.GettingUserAnswer(randomNumber1, userOperatorSymbol, randomNumber2);
                    double correctAnswer = CorrectAnswer.GettingCorrectAnswer(randomNumber1, operatorSymbol, randomNumber2);
                    score = CheckUserAnswer.CheckingUserAnswer(correctAnswer, finalAnswer, score);
                }
            }
            else if (difficulty == "Intermediate")
            {
                for (int q = 1; q < numberOfQuestions + 1; q++)
                {
                    (string operatorSymbol, string userOperatorSymbol) = RandomOperatorGenerator.GetOperator(random, 4);

                    (double randomNumber1, double randomNumber2) = RandomNumberGenerator.GenerateNumber(operatorSymbol, 10, 51, 0, 1000, random);
                    double finalAnswer = UserAnswer.GettingUserAnswer(randomNumber1, userOperatorSymbol, randomNumber2);
                    double correctAnswer = CorrectAnswer.GettingCorrectAnswer(randomNumber1, operatorSymbol, randomNumber2);
                    score = CheckUserAnswer.CheckingUserAnswer(correctAnswer, finalAnswer, score);

                }
            }
            else
            {
                for (int q = 1; q < numberOfQuestions + 1; q++)
                {
                    (string operatorSymbol, string userOperatorSymbol) = RandomOperatorGenerator.GetOperator(random, 4);

                    (double randomNumber1, double randomNumber2) = RandomNumberGenerator.GenerateNumber(operatorSymbol, 20, 1000, 0, 1000, random);
                    double finalAnswer = UserAnswer.GettingUserAnswer(randomNumber1, userOperatorSymbol, randomNumber2);
                    double correctAnswer = CorrectAnswer.GettingCorrectAnswer(randomNumber1, operatorSymbol, randomNumber2);
                    score = CheckUserAnswer.CheckingUserAnswer(correctAnswer, finalAnswer, score);
                }
            }
            return score;
        }
    }
}
