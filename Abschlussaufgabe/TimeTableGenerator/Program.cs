using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace TimeTableGenerator {
    class Program {
        public static TimeTable timeTable;
        public static List<Lecturer> lecturerList = new List<Lecturer>();
        public static List<Room> roomList = new List<Room>();
        public static List<Major> majorList = new List<Major>();
        static void Main(string[] args) {

            ParseJsonDataAndWriteToLists();

            if (!Task.Run(new Action(CreateTimeTable)).Wait(10000)) {
                WriteToConsole("Timeout: Calculating took to long\n");
                return;
            }
            GetAndFollowUserInstruction(args);
        }

        private static void ParseJsonDataAndWriteToLists() {
            lecturerList = JsonConvert.DeserializeObject<List<Lecturer>>(new StreamReader("data/Lecturer.json").ReadToEnd());
            roomList = JsonConvert.DeserializeObject<List<Room>>(new StreamReader("data/Room.json").ReadToEnd());
            majorList = JsonConvert.DeserializeObject<List<Major>>(new StreamReader("data/Cohort.json").ReadToEnd());
        }
        private static void CreateTimeTable() {
            timeTable = new TimeTable(roomList, majorList, lecturerList);
            timeTable.Fill();

        }
        private static void GetAndFollowUserInstruction(string[] instructions) {
            string userInput;

            if (instructions == null) {
                
                WriteToConsole(@"Type F to show the whole Timetable,
Type C to show the Timetable for a Cohort,
Type L to show the Timetable for a Lecturer,
Type R to show the Timetable for a Room,
Type O to show optional Courses for a Cohort,
Type any other key to leave the program.

> ");
                userInput = Console.ReadLine();
            } else {
                userInput = instructions[0];
            }
            switch (userInput) {
                case "F":
                    WriteToConsole(timeTable.GetCompleteTable());
                    break;
                case "C":
                    WriteToConsole("Please type in the name of the cohort you want to see the Timetable of.\n\n> ");
                    WriteToConsole(timeTable.GetTableForCohort(Console.ReadLine()));
                    break;
                case "L":
                    WriteToConsole("Please type in the name of the lecturer you want to see the Timetable of.\n\n> ");
                    WriteToConsole(timeTable.GetTableForLecturer(Console.ReadLine()));
                    break;
                case "R":
                    WriteToConsole("Please type in the name of the room you want to see the Timetable of.\n\n> ");
                    WriteToConsole(timeTable.GetTableForRoom(Console.ReadLine()));
                    break;
                case "O":
                    WriteToConsole("Please type in the name of the cohort you want to see the possible optional Courses of.\n\n> ");
                    WriteToConsole(timeTable.GetOptionalCourses(Console.ReadLine()));
                    break;
                default:
                    return;
            }
        }

        // This method manages the console-output
        private static void WriteToConsole(string text) {
            Console.Clear();
            Console.Write(text);
        }
    }
}