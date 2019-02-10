using System;

namespace Stundenplangenerator {
    public class Lecturer {
        public string name;
        public ValueTuple[] course;

        public Lecturer(String name, ValueTuple[] course) {
            this.name = name;
            this.course = course;
        }
    }
}