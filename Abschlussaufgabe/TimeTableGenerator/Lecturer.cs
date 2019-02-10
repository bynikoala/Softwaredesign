using System;
using System.Collections.Generic;

namespace TimeTableGenerator {
    public class Lecturer {
        public string name { get; set; }
        public List<Course> course { get; set; }
        public List<AbsentPoint> absent { get; set; }

        public Boolean availableAt(int day, int block) {
            foreach (AbsentPoint absentPoint in absent) {
                foreach (int absentBlock in absentPoint.block) {
                    if(absentPoint.day == day && absentBlock == block)
                        return false;
                }
            }
            return true;
        }
    }
    public class Course {
        public string subject { get; set; }
        public List<string> equipment { get; set; }
    }
    public class AbsentPoint {
        public int day { get; set; }
        public List<int> block { get; set; }
    }
}