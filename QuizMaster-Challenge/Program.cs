using System.Diagnostics;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to QuizMaster! Test your IT fundamentals knowledge with this 8-question quiz. Get ready and let's begin!");
            Console.WriteLine("Before we start, please respond with A/a, B/b or C/c for each answer. You will have 25 seconds to answer each question.\n\n");

            Thread.Sleep(1500);

            try
            {
                StartQuiz.start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error happened: {ex.Message}");
            }
        }


    }
    
}
