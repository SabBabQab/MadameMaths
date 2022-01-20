using System;

namespace MadameMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            Console.WriteLine("Welcome to MadameMaths. Are you ready to do some MATHS?");
            string level = GetInfo.GetLevel();
            int questionNumber = GetInfo.GetQuestionNumber();
            int score = IfBeginnerIntermediateProfessional.IfBeginnerIntermediateProfessionalAction(level, questionNumber);
            Console.WriteLine($"Your score is {score}/{questionNumber}");

        }
            
    }
}
