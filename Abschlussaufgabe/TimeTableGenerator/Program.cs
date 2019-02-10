using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace TimeTableGenerator {
    class Program {
        public static TimeTable timeTable;
        public static List<Lecturer> lecturerList = new List<Lecturer>();
        public static List<Room> roomList = new List<Room>();
        public static List<Cohort> cohortList = new List<Cohort>();
        static void Main(string[] args) {
            ParseJsonDataAndWriteToLists();

            CreateTimeTables();

            Console.Clear();

            Console.Write(timeTable.PrintCompleteTable());
            Console.WriteLine();
            Console.Write(timeTable.PrintTableForCohort(cohortList[0]));
            Console.WriteLine();
            Console.Write(timeTable.PrintTableForLecturer(lecturerList[1]));
            Console.WriteLine();
            Console.Write(timeTable.PrintTableForRoom(roomList[0]));
        }

        public static void ParseJsonDataAndWriteToLists() {
            lecturerList = JsonConvert.DeserializeObject<List<Lecturer>>(new StreamReader("data/Lecturer.json").ReadToEnd());
            roomList = JsonConvert.DeserializeObject<List<Room>>(new StreamReader("data/Room.json").ReadToEnd());
            cohortList = JsonConvert.DeserializeObject<List<Cohort>>(new StreamReader("data/Cohort.json").ReadToEnd());
        }
        private static void CreateTimeTables() {
            timeTable = new TimeTable(roomList, cohortList, lecturerList);
            timeTable.Fill();
        }
    }
}