using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QuizMaster_Challenge
{
    public class StartQuiz
    {
        public static void start()
        {
            string[] questions =
            {
                "What does \"HTTP\" stand for?\n\nA) HyperText Transfer Protocol\nB) HyperText Transmission Protocol\nC) HyperTransfer Text Protocol",
                "What is the name of Apple's mobile operating system?\n\nA) Android\nB) Windows\nC) iOS",
                "Which programming language is known for its use in web development and is commonly paired with HTML and CSS?\n\nA) Python\nB) Java\nC) JavaScript",
                "Which company developed the Windows operating system?\n\nA) Apple\nB) Microsoft\nC) IBM",
                "What does CPU stand for?\n\nA) Central Processing Unit \nB) Computer Processing Unit\nC) Central Power Unit",
                "Which protocol is used for secure communication over the internet?\n\nA) HTTP\r\nB) FTP\nC) HTTPS",
                "What does \"IP\" stand for in \"IP address\"?\n\nA) Internet Provider\nB) Internet Protocol\nC) Internal Protocol",
                "Who founded Microsoft?\n\nA) Steve Jobs\nB) Bill Gates\nC) Larry Page"
            };

            string[] solutions =
            {
                "A",
                "C",
                "C",
                "B",
                "A",
                "C",
                "B",
                "B"
            };

            int score = 0;
            int timeForPerQuestion = 25000;

            for (int i = 0; i < questions.Length; i++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                Console.WriteLine("\n");
                Console.Write($"{i+1}) ");
                Console.WriteLine(questions[i]);


                string answer = "";
                try
                {
                    while (true)
                    {
                        if (stopwatch.ElapsedMilliseconds >= timeForPerQuestion)
                        {
                            Console.WriteLine("Out of time! Let's go to the next question.\n");
                            break;
                        }

                        if (Console.KeyAvailable)
                        {
                            string userInput = Console.ReadLine()?.Trim().ToUpper();
                            if (userInput == "A" || userInput == "B" || userInput == "C")
                            {
                                answer = userInput;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect! Please enter A, B, or C");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error happened: {ex.Message}.");
                }

                stopwatch.Stop();

                if (stopwatch.ElapsedMilliseconds < timeForPerQuestion && answer == solutions[i])
                {
                    Console.WriteLine("That's correct! Nice job!! \n");
                    score++;
                }
                else if (stopwatch.ElapsedMilliseconds < timeForPerQuestion)
                {
                    Console.WriteLine($"Oooops! The correct answer is: {solutions[i]}\n");
                }

                Thread.Sleep(1500);

            }

            if (score >= 0 && score <= 8)
            {
                if (score == 8)
                {
                    Console.WriteLine("Fantastic! You achieved a perfect score of 8 out of 8!!!!\n");
                }
                else if (score >= 4)
                {
                    Console.WriteLine($"Well done! You passed with a score of {score} out of 8 !!\n");
                }
                else
                {
                    Console.WriteLine($"Unfortunately, you did not pass. Your score is {score} out of 8\n");
                }
            }
            else
            {
                Console.WriteLine("Error: The score entered is invalid\n");
            }
        }
    }
}
