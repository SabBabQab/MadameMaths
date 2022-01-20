using System;
namespace MadameMaths
{
    public static class RandomOperatorGenerator
    {
        public static (string, string) GetOperator(Random random, int untilOperatorNumber)
        {
            string[] operators = { "+", "-", "*", "/" };
            string[] userOperators = { "+", "-", "x", "÷" };
            int randomOperator = random.Next(0, untilOperatorNumber);
            string op = operators[randomOperator];
            string userOp = userOperators[randomOperator];
            return (op, userOp);
        }
    }
}
