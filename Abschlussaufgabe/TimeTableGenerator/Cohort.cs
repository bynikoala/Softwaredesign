using System;
using System.Collections.Generic;

namespace TimeTableGenerator {
    public class Cohort {
        public string name { get; set; }
        public List<Semester> semester { get; set; }
    }
    public class Semester {
        public int term { get; set; }
        public int students { get; set; }
        public List<String> lectures { get; set; }
    }
}