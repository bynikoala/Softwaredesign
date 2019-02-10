using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace Stundenplangenerator {
    class Program {
        static List<Lecturer> jsonLecturers;
        static List<Room> jsonRooms;
        static List<Cohort> jsonCohorts;
        static void Main(string[] args) {
            parseScheduleData();
            createTimetable();
            showTimetableForCohort(jsonCohorts[0]);
            showTimetableForLecturer(jsonLecturers[0]);
            showTimetableForRoom(jsonRooms[0]);
        }

        static void parseScheduleData() {
            jsonLecturers = JsonConvert.DeserializeObject<List<Lecturer>>(new StreamReader("data/Lecturer.json").ReadToEnd());
            jsonRooms = JsonConvert.DeserializeObject<List<Room>>(new StreamReader("data/Room.json").ReadToEnd());
            jsonCohorts = JsonConvert.DeserializeObject<List<Cohort>>(new StreamReader("data/Cohort.json").ReadToEnd());

            Console.Write(jsonLecturers[0].course[0]);
        }
        private static void createTimetable() {
            // TODO: Well, yep.
        }
        private static void showTimetableForCohort(Cohort cohort) {
            Console.Write(cohort.ToString());
        }
        private static void showTimetableForLecturer(Lecturer lecturer) {
            Console.Write(lecturer.ToString());
        }
        private static void showTimetableForRoom(Room room) {
            Console.Write(room.ToString());
        }
    }
}