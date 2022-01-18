using System;

namespace MadameMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");

            int score = 0;

            Console.WriteLine("Let's start! What's 1+1?");
            string answer1 = Console.ReadLine();
            if (answer1 == "2")
            {
                Console.WriteLine("CORRECT!");
                score++;
            }
            else
            {
                Console.WriteLine($"1+1 isn't {answer1}. It's 2!");
            }
            Console.WriteLine("OK! 3 x 3");
            string answer2 = Console.ReadLine();
            if (answer2 == "9")
            {
                Console.WriteLine("Awesome!");
                score++;
            }
            else
            {
                Console.WriteLine("Oh dear! The answer is 9! Never mind, keep trying.");
            }
            Console.WriteLine("100 ÷ 5");
            string answer3 = Console.ReadLine();
            if (answer3 == "20")
            {
                Console.WriteLine("Brilliant!");
                score++;
            }
            else
            {
                Console.WriteLine("WRONG. Your answer should be 20!");
            }
            Console.WriteLine("Let's move on. If 5𝑥 + 10 = 50, what is 𝑥?");
            string answer4 = Console.ReadLine();
            if (answer4 == "8")
            {
                Console.WriteLine("Yayyy! You really know your maths! But watch out, the next question is haaard.");
                score++;
            }
            else
            {
                Console.WriteLine($"𝑥 would not equal {answer4}. 𝑥 would equal 8.");
            }
            Console.WriteLine("How many πs is the area of a circle with a radius of 5?");
            string answer5 = Console.ReadLine();
            if (answer5 == "25")
            {
                Console.WriteLine("Oh my goodness, you are right! Are you awesome or what?");
                score++;
            }
            else
            {
                Console.WriteLine("The formula for the area of a circle is πr². Thus the area is 25π");
            }

            Console.WriteLine($"Your score is {score}/5");


        }
    }
}
