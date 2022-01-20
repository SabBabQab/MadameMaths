using System;
namespace MadameMaths
{
    public static class AskAndReceiveAnswer
    {
        public static double AskingAndReceiving(double randomNumber, string userOp, double otherRandomNumber)
        {
            Console.WriteLine($"What's {randomNumber} {userOp} {otherRandomNumber}?");
            string answer = Console.ReadLine();
            double danswer;
            double.TryParse(answer, out danswer);
            return danswer;
        }
    }
}
