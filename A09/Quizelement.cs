using System;

namespace A09 {
    public abstract class Quizelement {
        protected String question;
        protected String callToAction;
        public abstract String Show();
        public abstract Boolean IsCorrect(String userInput);
        public abstract void LoadFromJson();
    }
}