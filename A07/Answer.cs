using System;

namespace A07 {
    public class Answer {
        public String text;
        public Boolean verity;
        public Answer(String text, Boolean verity) {
            this.text = text;
            this.verity = verity;
        }
        public Answer(String solution) {
            this.text = solution;
        }
        public Boolean isTrue() {
            return verity;
        }
    }
}