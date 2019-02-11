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
    }
}