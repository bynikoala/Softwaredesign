using System;

namespace A09 {
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