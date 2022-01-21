using System;
namespace MadameMaths
{
    public static class RandomOperatorGenerator
    {
        public static (string, string) GetOperator(Random random, int numberOfOperators)
        {
            string[] operators = { "+", "-", "*", "/" };
            string[] userOperators = { "+", "-", "x", "÷" };
            int randomOperatorPosition = random.Next(0, numberOfOperators);
            string operatorSymbol = operators[randomOperatorPosition];
            string userOperatorSymbol = userOperators[randomOperatorPosition];
            return (operatorSymbol, userOperatorSymbol);
        }
    }
}
