using System;
namespace MadameMaths
{
    public static class RandomNumberGenerator
    {
        public static (double, double) GenerateNumber(string operatorSymbol, int multiplyDivMin, int multiplyDivMax, int minusAddMin, int minusAddMax, Random random)
        {
            double randomNumber1;
            double randomNumber2;
            if (operatorSymbol == "+" || operatorSymbol == "-")
            {
                randomNumber1 = random.Next(minusAddMin, minusAddMax);
                randomNumber2 = random.Next(minusAddMin, minusAddMax);
            }
            else if (operatorSymbol == "*")
            {
                randomNumber1 = random.Next(multiplyDivMin, multiplyDivMax);
                randomNumber2 = random.Next(multiplyDivMin, multiplyDivMax);
            }
            else
            {
                randomNumber1 = random.Next(multiplyDivMin, multiplyDivMax);
                int randomInt1 = Convert.ToInt32(randomNumber1);
                randomNumber2 = random.Next(multiplyDivMin, randomInt1 + 1);
            }
            return (randomNumber1, randomNumber2);
        }
    }
}
