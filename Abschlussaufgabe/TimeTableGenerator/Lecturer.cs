using System;
using System.Collections.Generic;

namespace TimeTableGenerator {
    public class Lecturer {
        public string name { get; set; }
        public List<Course> courses { get; set; }
        public List<AbsentPoint> absents { get; set; }
        public List<OptionalCourse> optionalCoursesOffered { get; set; }

        public Boolean availableAt(int day, int block) {
            foreach (AbsentPoint absentPoint in absents) {
                foreach (int absentBlock in absentPoint.block) {
                    if (absentPoint.day == day && absentBlock == block)
                        return false;
                }
            }
            return true;
        }
        public void isAbsentAt(int day, int block) {
            foreach (AbsentPoint absentPoint in absents) {
                if (absentPoint.day == day) {
                    absentPoint.block.Add(block);
                    return;
                }
            }
            AbsentPoint newAbsentPoint = new AbsentPoint();
            newAbsentPoint.day = day;
            newAbsentPoint.block = new List<int>();
            newAbsentPoint.block.Add(block);
            absents.Add(newAbsentPoint);
        }
    }
    public class AbsentPoint {
        public int day { get; set; }
        public List<int> block { get; set; }
    }
    public class Course {
        public string name { get; set; }
        public List<string> equipment { get; set; }
    }
    public class OptionalCourse : Course {
        public string roomName { get; set; }
        public int day { get; set; }
        public int blockNumber { get; set; }
    }

}