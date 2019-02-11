using System;

namespace TimeTableGenerator {
    internal class Block {
        public Major major;
        public string courseName;
        public Lecturer lecturer;
        public Room room;
        public Cohort cohort;
        public int number;
        public int day;
        public Block(Major cohort, string lectureName, Lecturer lecturer, Room room, Cohort semester, int blockNumber, int day) {
            this.major = cohort;
            this.courseName = lectureName;
            this.lecturer = lecturer;
            this.room = room;
            this.number = blockNumber;
            this.day = day;
        }
        static public string getDayname(int dayNumberOfWeek) {
            switch(dayNumberOfWeek) {
                case 0:
                return "Monday";
                case 1:
                return "Tuesday";
                case 2:
                return "Wednesday";
                case 3:
                return "Thursday";
                case 4:
                return "Friday";
                default:
                return "ErrorWithDayOfWeek";
            }
        }
        static public String getTime(int blockNumber) {
            switch(blockNumber) {
                case 0:
                return "07:45-09:15";
                case 1:
                return "09:30-11:00";
                case 2:
                return "11:15-12:45";
                case 3:
                return "14:00-15:30";
                case 4:
                return "15:45-17:15";
                case 5:
                return "17:45-19:15";
                default:
                return "ErrorWithDayOfWeek";
            }
        }
    }
}