using System;
using System.Collections.Generic;

namespace TimeTableGenerator {
    public class Major {
        public string name { get; set; }
        public List<Cohort> semester { get; set; }
    }
    public class Cohort {
        public int term { get; set; }
        public int students { get; set; }
        public List<String> lectures { get; set; }
    }
}