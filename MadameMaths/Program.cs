using System;

namespace MadameMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int score = 0;

            double randomNumber;
            double otherRandomNumber;

            Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");

            Console.WriteLine("Which level? Begginer, Intermediate or Professional");

            string level = Console.ReadLine();

            Console.WriteLine("How many questions do you want(or have) to answer today?");
            string questionString = Console.ReadLine();
            int questionNumber;
            int.TryParse(questionString, out questionNumber);

            


            if (level == "Begginer")
            { 
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    Random random = new Random();
                    string[] operators = { "+", "-", "*" };
                    string[] userOperators = { "+", "-", "x" };
                    int randomOperator = random.Next(0, 3);
                    string op = operators[randomOperator];
                    string userOp = userOperators[randomOperator];


                    if (op == "+" || op == "-")
                    {
                        randomNumber = random.Next(0, 100);
                        otherRandomNumber = random.Next(0, 100);
                    }
                    else
                    {
                        randomNumber = random.Next(1, 13);
                        otherRandomNumber = random.Next(1, 13);
                    }

                    Console.WriteLine($"What's {randomNumber} {userOp} {otherRandomNumber}?");
                    string answer = Console.ReadLine();
                    double danswer;
                    double.TryParse(answer, out danswer);

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
                        default:
                            throw new Exception("Operator not recognised.");
                    }
                    if (danswer == correctAnswer)
                    {
                        Console.WriteLine("CORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"WRONG! The answer is {correctAnswer}");
                    }
                }

                Console.WriteLine($"Your score is {score}/{questionNumber}");
            }
            if (level == "Intermediate")
            {
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    Random random = new Random();
                    string[] operators = { "+", "-", "*", "/" };
                    string[] userOperators = { "+", "-", "x", "÷" };
                    int randomOperator = random.Next(0, 4);
                    string op = operators[randomOperator];
                    string userOp = userOperators[randomOperator];


                    if (op == "+" || op == "-")
                    {
                        randomNumber = random.Next(0, 1000);
                        otherRandomNumber = random.Next(0, 1000);
                    }
                    else if (op == "*")
                    {
                        randomNumber = random.Next(10, 51);
                        otherRandomNumber = random.Next(10, 51);
                    }
                    else
                    {
                        randomNumber = random.Next(10, 51);
                        int randomInt = Convert.ToInt32(randomNumber);
                        otherRandomNumber = random.Next(10, randomInt + 1);
                    }

                    Console.WriteLine($"What's {randomNumber} {userOp} {otherRandomNumber}?");
                    string answer = Console.ReadLine();
                    double danswer;
                    double.TryParse(answer, out danswer);

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
                    if (danswer == correctAnswer)
                    {
                        Console.WriteLine("CORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"WRONG! The answer is {correctAnswer}");
                    }
                }

                Console.WriteLine($"Your score is {score}/{questionNumber}");
            }

            if (level == "Professional")
            {
                for (int q = 1; q < questionNumber + 1; q++)
                {
                    Random random = new Random();
                    string[] operators = { "+", "-", "*", "/" };
                    string[] userOperators = { "+", "-", "x", "÷" };
                    int randomOperator = random.Next(0, 4);
                    string op = operators[randomOperator];
                    string userOp = userOperators[randomOperator];

                    if (op == "+" || op == "-")
                    {
                        randomNumber = random.Next(0, 1000);
                        otherRandomNumber = random.Next(0, 1000);
                    }
                    else if (op == "*")
                    {
                        randomNumber = random.Next(20, 1000);
                        otherRandomNumber = random.Next(20, 1000);
                    }
                    else
                    {
                        randomNumber = random.Next(20, 1000);
                        int randomInt = Convert.ToInt32(randomNumber);
                        otherRandomNumber = random.Next(20, randomInt + 1);
                    }

                    Console.WriteLine($"What's {randomNumber} {userOp} {otherRandomNumber}?");
                    string answer = Console.ReadLine();
                    double danswer;
                    double.TryParse(answer, out danswer);

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
                    if (danswer == correctAnswer)
                    {
                        Console.WriteLine("CORRECT!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"WRONG! The answer is {correctAnswer}");
                    }
                }

                Console.WriteLine($"Your score is {score}/{questionNumber}");
            }

        }
            
    }
}
