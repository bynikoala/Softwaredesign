using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace A09 {
    class Program {
        static int score = 0;
        static List<Quizelement> quizPool = new List<Quizelement>();
        static int currentQuizelement = 0;
        static void Main(string[] args) {
            Console.Clear();
            LoadQuestionsFromJson();

            // while (FollowUserInstruction()) { }

            // Console.WriteLine($"Your final score is: {score}\nThank you for playing!\n");
        }
        public static void LoadQuestionsFromJson() {

            // Parse JSON-File into List of suitable class
            List<JsonQuizPool> jsonQuizPool = JsonConvert.DeserializeObject<List<JsonQuizPool>>(new StreamReader("quizelements.json").ReadToEnd());

            foreach(JsonQuizPool jsonQuizelement in jsonQuizPool) {
                quizPool.Add(jsonQuizelement.ToQuizelement());
            }
        }
        // public static Boolean FollowUserInstruction() {
        // // Now let's get the party started! #Cringe
        // Console.Clear();
        // if (score != 0)
        //     Console.Write($"\nYour score is {score}\n");

        // Console.Write("\nDo you want to:\n\nS) Solve a quiz,\nA) Add a question or\nE) End the program?\n\n> ");

        // switch (Console.ReadLine().ToUpper()) {
        //     case "A":
        //         AddQuestion();
        //         return true;
        //     case "E":
        //         Console.Clear();
        //         Console.Write("You left the game.\n\n");
        //         return false;
        //     default:
        //         if (currentQuizelement < quizelements.Count) {
        //             SolveAQuestion(quizelements[currentQuizelement]);
        //             return true;
        //         } else {
        //             Console.Clear();
        //             Console.Write("There are no questions left.\n\n");
        //             return false;
        //         }
        // }
        // }
        public static void SolveAQuestion(Quizelement quizelement) {
            // Console.Clear();
            // quizelement.ShowQuestion();
            // Console.Write("\nYour choice: ");
            // if (quizelement.answers[Int32.Parse(Console.ReadLine()) - 1].isTrue()) {
            //     score += 10;
            //     Console.Write("\nRight Answer! 10 Points to Gryffindor!");
            // } else {
            //     Console.Write("\nWrong Answer. Sorry for that, bro!");
            // }
            // currentQuizelement++;
        }
        public static void AddQuestion() {
            // Console.Clear();
            // Console.Write("\nType in the Question you want to ask:\n> ");
            // String newQuestion = Console.ReadLine();

            // Console.Write("\nHow many chooseable answers do you want to give? (2-6)\n> ");
            // int answerCount = Int32.Parse(Console.ReadLine());
            // Answer[] newAnswers = new Answer[answerCount];

            // // Get the first AND true Question
            // Console.Write("\nType in your first AND TRUE answer: \n> ");
            // newAnswers[0] = new Answer(Console.ReadLine(), true);
            // // Get the rest
            // for (int i = 1; i < answerCount; i++) {
            //     Console.Write($"\nType in your {i+1}. answer: \n> ");
            //     newAnswers[i] = new Answer(Console.ReadLine(), false);
            // }
            // // Make the Quizelement
            // quizelements.Add(new Quizelement(newQuestion, newAnswers));
        }
    }
}