using System;
namespace MadameMaths
{
    public static class UserPreferences
    {
        public static string GetDifficulty()
        {
            string difficulty;
            bool isValidDifficulty;
            do
            {
                Console.WriteLine("Which level? Beginner, Intermediate or Professional");
                difficulty = Console.ReadLine();
                if (difficulty == "Beginner") isValidDifficulty = true;
                else if (difficulty == "Intermediate") isValidDifficulty = true;
                else if (difficulty == "Professional") isValidDifficulty = true;
                else isValidDifficulty = false;
            }
            while (!isValidDifficulty);
            return difficulty;
        }
        public static int GetNumberOfQuestions()
        {
            int numberOfQuestions;
            Console.WriteLine("How many questions do you want(or have) to answer today?");
            string numberOfQuestionsString = Console.ReadLine();
            int.TryParse(numberOfQuestionsString, out numberOfQuestions);
            return numberOfQuestions;
        }
    }
}
