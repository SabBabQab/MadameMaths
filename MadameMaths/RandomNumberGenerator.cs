using System;
namespace MadameMaths
{
    public static class RandomNumberGenerator
    {
        public static (double, double) GenerateNumber(string op, int multiplyDivMin, int multiplyDivMax, int minusAddMin, int minusAddMax, Random random)
        {
            double randomNumber;
            double otherRandomNumber;
            if (op == "+" || op == "-")
            {
                randomNumber = random.Next(minusAddMin, minusAddMax);
                otherRandomNumber = random.Next(minusAddMin, minusAddMax);
            }
            else if (op == "*")
            {
                randomNumber = random.Next(multiplyDivMin, multiplyDivMax);
                otherRandomNumber = random.Next(multiplyDivMin, multiplyDivMax);
            }
            else
            {
                randomNumber = random.Next(multiplyDivMin, multiplyDivMax);
                int randomInt = Convert.ToInt32(randomNumber);
                otherRandomNumber = random.Next(multiplyDivMin, randomInt + 1);
            }
            return (randomNumber, otherRandomNumber);
        }
    }
}
