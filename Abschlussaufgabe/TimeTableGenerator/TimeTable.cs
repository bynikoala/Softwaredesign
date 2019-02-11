using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTableGenerator {
    public class TimeTable {
        List<Room> roomList;
        List<Major> majorList;
        List<Lecturer> lecturerList;

        private Block[, , ] completeTable;
        public TimeTable(List<Room> roomList, List<Major> cohortList, List<Lecturer> lecturerList) {
            this.roomList = roomList;
            this.majorList = cohortList;
            this.lecturerList = lecturerList;

            /* 
                Build a general, big TimeTable by declaring a 3-dim Array, where:
                - the first dimension (length 5) describes each day of the week,
                - the second dimension (length 6) describes each Block of the day
                - the third dimension (length of availabe rooms) describes, well, the available rooms...
            */
            completeTable = new Block[5, 6, roomList.Count];
            for (int day = 0; day < 5; day++) {
                for (int block = 0; block < 6; block++) {
                    for (int room = 0; room < roomList.Count; room++) {
                        completeTable[day, block, room] = new Block(null, null, null, roomList[room], null, block, day);
                    }
                }
            }
        }

        public void Fill() {
            foreach (Lecturer lecturer in lecturerList) {
                if (lecturer.optionalCoursesOffered.Count > 0) {
                    foreach (OptionalCourse optionalCourse in lecturer.optionalCoursesOffered) {
                        lecturer.isAbsentAt(optionalCourse.day, optionalCourse.blockNumber);
                    }
                }
            }
            foreach (Major major in majorList) {
                foreach (Cohort cohort in major.semester) {
                    foreach (string courseName in cohort.lectures) {
                        Lecturer lecturer = GetLecturerByCourseName(courseName);
                        Course course = GetCourseByName(courseName);
                        SaveCourseIntoNextAvailableBlock(major, course, lecturer, cohort);
                    }
                }
            }
        }
        private Lecturer GetLecturerByCourseName(string courseName) {
            foreach (Lecturer lecturer in lecturerList) {
                foreach (Course course in lecturer.courses) {
                    if (course.name.Equals(courseName))
                        return lecturer;
                }
            }
            return null;
        }
        private Course GetCourseByName(string courseName) {
            foreach (Lecturer lecturer in lecturerList) {
                foreach (Course course in lecturer.courses) {
                    if (course.name.Equals(courseName))
                        return course;
                }
            }
            return null;
        }
        private Lecturer GetLecturerByName(string lecturerName) {
            foreach (Lecturer lecturer in lecturerList) {
                if (lecturer.name.Equals(lecturerName))
                    return lecturer;
            }
            return null;
        }
        private Cohort GetCohortByName(string cohortName) {
            string cohortMajor = cohortName.Substring(0, 3);
            int cohortSemester = cohortName[3] - '0'; // Trick to convert char into int

            foreach (Major major in majorList) {
                if (major.name.Equals(cohortMajor)) {
                    foreach (Cohort cohort in major.semester) {
                        if (cohort.term == cohortSemester)
                            return cohort;
                    }
                }
            }
            return null;
        }
        private Room GetRoomByName(string roomName) {
            foreach (Room room in roomList) {
                if (room.name.Equals(roomName))
                    return room;
            }
            return null;
        }
        private void SaveCourseIntoNextAvailableBlock(Major cohort, Course course, Lecturer lecturer, Cohort semester) {
            foreach (Block block in completeTable) {
                // Check if Block is used
                try {
                    if (block.courseName == null && block.room.capacity >= semester.students && lecturer.availableAt(block.day, block.number) && hasEquipment(block.room, course)) {
                        block.major = cohort;
                        block.courseName = course.name;
                        block.lecturer = lecturer;
                        block.cohort = semester;
                        lecturer.isAbsentAt(block.day, block.number);
                        return;
                    }
                } catch (System.NullReferenceException) {
                    if (lecturer == null) {
                        // Some Lecturers are not yet entered into json-data
                    }
                }
            }
        }
        private bool hasEquipment(Room room, Course course) {
            return !course.equipment.Except(room.equipment).Any();
        }

        public string GetCompleteTable() {
            StringBuilder sb = new StringBuilder();
            foreach (Block block in completeTable) {
                if (block != null && block.lecturer != null)
                    sb.Append($"{block.major.name}{block.cohort.term} Day {block.day+1}, Block {block.number+1}: {block.courseName} in {block.room.name} with {block.lecturer.name}\n");
            }
            return sb.ToString();
        }
        public string GetTableForCohort(string userInput) {
            Cohort cohort = GetCohortByName(userInput);
            if (cohort == null)
                return $"Cohort {userInput} not found";

            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {userInput}:\n");
            foreach (Block block in completeTable) {
                if (block != null && block.lecturer != null && block.cohort == cohort)
                    sb.Append($"Day {block.day+1}, Block {block.number+1}: {block.courseName} in {block.room.name} with {block.lecturer.name}\n");
            }
            return sb.ToString();
        }
        public string GetTableForLecturer(string userInput) {
            Lecturer lecturer = GetLecturerByName(userInput);
            if (lecturer == null)
                return $"Lecturer {userInput} not found";

            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {lecturer.name}:\n");
            foreach (Block block in completeTable) {
                if (block != null && block.lecturer != null && block.lecturer == lecturer)
                    sb.Append($"{block.major.name}{block.cohort.term} Day {block.day+1}, Block {block.number+1}: {block.courseName} in {block.room.name}\n");
            }
            return sb.ToString();
        }
        public string GetTableForRoom(string userInput) {
            Room room = GetRoomByName(userInput);
            if (room == null)
                return $"Room {userInput} not found";

            StringBuilder sb = new StringBuilder();
            sb.Append($"Timetable for {room.name}:\n");
            foreach (Block block in completeTable) {
                if (block != null && block.lecturer != null && block.room == room)
                    sb.Append($"{block.major.name}{block.cohort.term} Day {block.day+1}, Block {block.number+1}: {block.courseName} with {block.lecturer.name}\n");
            }
            return sb.ToString();
        }
        public string GetOptionalCourses(string userInput) {
            Cohort cohort = GetCohortByName(userInput);
            if (cohort == null)
                return $"Cohort {userInput} not found";

            StringBuilder sb = new StringBuilder();
            sb.Append($"Optional courses available for {userInput}:\n");

            foreach (Lecturer lecturer in lecturerList) {
                foreach (OptionalCourse optionalCourse in lecturer.optionalCoursesOffered) {
                    for (int i = 0; i < roomList.Count; i++) {
                        Block block = completeTable[optionalCourse.day, optionalCourse.blockNumber, i];
                        if (block.cohort != cohort)
                            sb.Append($"Day {optionalCourse.day}: {optionalCourse.name} in {optionalCourse.roomName} with {lecturer.name}");
                    }
                }
            }
            if (sb.Length > 40)
                return "No Optional Courses found for your TimeTable";
            return sb.ToString();
        }
    }
}