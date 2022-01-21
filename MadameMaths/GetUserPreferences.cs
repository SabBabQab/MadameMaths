using System;
namespace MadameMaths
{
    public static class GetInfo
    {
        public static string GetLevel()
        {
            string level;
            bool levelTrue;
            do
            {
                Console.WriteLine("Which level? Beginner, Intermediate or Professional");
                level = Console.ReadLine();
                if (level == "Beginner") levelTrue = true;
                else if (level == "Intermediate") levelTrue = true;
                else if (level == "Professional") levelTrue = true;
                else levelTrue = false;
            }
            while (!levelTrue);
            return level;
        }
        public static int GetQuestionNumber()
        {
            int questionNumber;
            Console.WriteLine("How many questions do you want(or have) to answer today?");
            string questionString = Console.ReadLine();
            int.TryParse(questionString, out questionNumber);
            return questionNumber;
        }
    }
}
