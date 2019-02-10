using System;

namespace TimeTableGenerator {
    internal class Block {
        public Cohort cohort;
        public string lectureName;
        public Lecturer lecturer;
        public Room room;
        public Semester semester;
        public int number;
        public int day;
        public Block(Cohort cohort, string lectureName, Lecturer lecturer, Room room, Semester semester, int blockNumber, int day) {
            this.cohort = cohort;
            this.lectureName = lectureName;
            this.lecturer = lecturer;
            this.room = room;
            this.number = blockNumber;
            this.day = day;
        }
    }
}