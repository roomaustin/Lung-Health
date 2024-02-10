using System;

class LungHealthProgram
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Lung Health Program!");
            Console.WriteLine("1. Lung Health Exercises");
            Console.WriteLine("2. Pronunciation Problems");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayLungHealthExercises();
                    break;
                case 2:
                    DisplayPronunciationProblems();
                    break;
                case 3:
                    Console.WriteLine("Thank you for using the Lung Health Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayLungHealthExercises()
    {
        Console.WriteLine("Lung Health Exercises:");
        Console.WriteLine("1. Deep Breathing: Inhale deeply through your nose, hold for a few seconds, then exhale slowly through your mouth.");
        Console.WriteLine("2. Pursed Lip Breathing: Inhale slowly through your nose, then purse your lips as if you're going to whistle and exhale slowly.");
        Console.WriteLine("3. Diaphragmatic Breathing: Lie on your back, place one hand on your chest and the other on your abdomen. Inhale deeply through your nose, allowing your abdomen to rise, then exhale slowly.");
    }

    static void DisplayPronunciationProblems()
    {
        Console.WriteLine("Pronunciation Problems:");
        Console.WriteLine("1. Shortness of Breath: Pronounced as 'shor-tness of breth' instead of 'short-ness of breath'.");
        Console.WriteLine("2. Dyspnea: Pronounced as 'dis-pee-nee-uh' instead of 'disp-nee-uh'.");
        Console.WriteLine("3. Wheezing: Pronounced as 'weez-ing' instead of 'wee-zing'.");
    }
}
