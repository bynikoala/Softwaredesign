using System;
using System.Collections.Generic;

namespace TimeTableGenerator {
    public class Room {
        public string name { get; set; }
        public int capacity { get; set; }
        public List<string> equipment { get; set; }
    }
}