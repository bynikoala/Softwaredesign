using System;

namespace Stundenplangenerator {
    public class Cohort {
        public string name;
        public ValueTuple[] semester;

        public Cohort(String name, ValueTuple[] semester) {
            this.name = name;
            this.semester = semester;
        }
    }
}