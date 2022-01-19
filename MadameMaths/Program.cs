using System;

namespace MadameMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");

            //Random random = new Random();
            //int randomNumber1 = random.Next(1, 11);
            //int otherRandomNumber1 = random.Next(1, 11);

            //int score = 0;

            //Console.WriteLine($"Let's start! What's {randomNumber} + {randomNumber}?");
            //string answer1 = Console.ReadLine();
            //double danswer1;
            //double.TryParse(answer1, out danswer1);
            //if (danswer1 == randomNumber + randomNumber)
            //{
            //    Console.WriteLine("CORRECT!");
            //    score++;
            //}
            //else
            //{
            //    Console.WriteLine($"1+1 isn't {answer1}. It's 2!");
            //}
            //Console.WriteLine("OK! 3 x 3");
            //string answer2 = Console.ReadLine();
            //if (answer2 == "9")
            //{
            //    Console.WriteLine("Awesome!");
            //    score++;
            //}
            //else
            //{
            //    Console.WriteLine("Oh dear! The answer is 9! Never mind, keep trying.");
            //}
            //Console.WriteLine("100 ÷ 5");
            //string answer3 = Console.ReadLine();
            //if (answer3 == "20")
            //{
            //    Console.WriteLine("Brilliant!");
            //    score++;
            //}
            //else
            //{
            //    Console.WriteLine("WRONG. Your answer should be 20!");
            //}
            //Console.WriteLine("Let's move on. If 5𝑥 + 10 = 50, what is 𝑥?");
            //string answer4 = Console.ReadLine();
            //if (answer4 == "8")
            //{
            //    Console.WriteLine("Yayyy! You really know your maths! But watch out, the next question is haaard.");
            //    score++;
            //}
            //else
            //{
            //    Console.WriteLine($"𝑥 would not equal {answer4}. 𝑥 would equal 8.");
            //}
            //Console.WriteLine("How many πs is the area of a circle with a radius of 5?");
            //string answer5 = Console.ReadLine();
            //if (answer5 == "25")
            //{
            //    Console.WriteLine("Oh my goodness, you are right! Are you awesome or what?");
            //    score++;
            //}
            //else
            //{
            //    Console.WriteLine("The formula for the area of a circle is πr². Thus the area is 25π");
            //}

            //Console.WriteLine($"Your score is {score}/5");

            int score = 0;

            Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");

            for (int q = 1; q < 6; q++)
            {
                Random random = new Random();
                double randomNumber = random.Next(1, 11);
                double otherRandomNumber = random.Next(1, 11);
                string [] operators = { "+", "-", "*", "/" };
                string[] userOperators = { "+", "-", "x", "÷" };
                int randomOperator = random.Next(1, 4);
                string op = operators[randomOperator];
                string userOp = userOperators[randomOperator];

                

                Console.WriteLine($"What's {randomNumber} {userOp} {otherRandomNumber}?");
                string answer = Console.ReadLine();
                double danswer;
                double.TryParse(answer, out danswer);

                double correctAnswer;

                switch(op)
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

            Console.WriteLine($"Your score is {score}/5");
        }
    }
}
