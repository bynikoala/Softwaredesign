using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTableGenerator {
    internal class TimeTable {
        List<Room> roomList;
        List<Cohort> cohortList;
        List<Lecturer> lecturerList;

        private Block[, , ] wholeWeek;
        public TimeTable(List<Room> roomList, List<Cohort> cohortList, List<Lecturer> lecturerList) {
            this.roomList = roomList;
            this.cohortList = cohortList;
            this.lecturerList = lecturerList;

            /* 
                Build a general, big TimeTable by declaring a 3-dim Array, where:
                - the first dimension (length 5) describes each day of the week,
                - the second dimension (length 6) describes each Block of the day
                - the third dimension (length of availabe rooms) describes, well, the available rooms...
            */
            wholeWeek = new Block[5, 6, roomList.Count];
            for (int day = 0; day < 5; day++) {
                for (int block = 0; block < 6; block++) {
                    for (int room = 0; room < roomList.Count; room++) {
                        wholeWeek[day, block, room] = new Block(null, null, null, roomList[room], null, block, day);
                    }
                }
            }
        }

        public void Fill() {
            foreach (Cohort cohort in cohortList) {
                foreach (Semester semester in cohort.semester) {
                    foreach (string lectureName in semester.lectures) {
                        Lecturer lecturer = GetLecturer(lectureName);
                        SaveCourseIntoNextAvailableBlock(cohort, lectureName, lecturer, semester);
                    }
                }
            }
        }
        private Lecturer GetLecturer(string lectureName) {
            foreach (Lecturer lecturer in lecturerList) {
                foreach (Course course in lecturer.course) {
                    if (course.subject.Equals(lectureName))
                        return lecturer;
                }
            }
            return null;
        }
        private void SaveCourseIntoNextAvailableBlock(Cohort cohort, string lectureName, Lecturer lecturer, Semester semester) {
            foreach (Block block in wholeWeek) {
                // Check if Block is used
                try {
                    if (block.lectureName == null && block.room.capacity >= semester.students && lecturer.availableAt(block.day, block.number)) {
                        block.cohort = cohort;
                        block.lectureName = lectureName;
                        block.lecturer = lecturer;
                        block.semester = semester;
                        return;
                    }
                } catch (System.NullReferenceException) {
                    if (lecturer == null) {

                    }
                }
            }
        }

        public string PrintCompleteTable() {
            StringBuilder sb = new StringBuilder();
            foreach (Block block in wholeWeek) {
                if (block != null && block.lecturer != null)
                    sb.Append($"{block.cohort.name}{block.semester.term} Tag {block.day+1}, Block {block.number+1}: {block.lectureName} in {block.room.name}\n");
            }
            return sb.ToString();
        }
        public string PrintTableForCohort(Cohort cohort) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {cohort.name}\n");
            foreach (Block block in wholeWeek) {
                if (block != null && block.lecturer != null && block.cohort == cohort)
                    sb.Append($"{cohort.name}{block.semester.term} Tag {block.day+1}, Block {block.number+1}: {block.lectureName} in {block.room.name}\n");
            }
            return sb.ToString();
        }
        public string PrintTableForLecturer(Lecturer lecturer) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {lecturer.name}\n");
            foreach (Block block in wholeWeek) {
                if (block != null && block.lecturer != null && block.lecturer == lecturer)
                    sb.Append($"{block.cohort.name}{block.semester.term} Tag {block.day+1}, Block {block.number+1}: {block.lectureName} in {block.room.name}\n");
            }
            return sb.ToString();
        }
        public string PrintTableForRoom(Room room) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {room.name}\n");
            foreach (Block block in wholeWeek) {
                if (block != null && block.lecturer != null && block.room == room)
                    sb.Append($"{block.cohort.name}{block.semester.term} Tag {block.day+1}, Block {block.number+1}: {block.lectureName}\n");
            }
            return sb.ToString();
        }
    }
}