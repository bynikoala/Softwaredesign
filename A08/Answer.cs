using System;

namespace A08 {
    public class Answer {
        public String text;
        private Boolean verity;
        public Answer(String text, Boolean verity) {
            this.text = text;
            this.verity = verity;
        }
        public Boolean isTrue() {
            return verity;
        }
    }
}