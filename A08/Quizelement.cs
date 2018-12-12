using System;

namespace A08 {
    public abstract class Quizelement {
        public String question;
        public String callToAction;
        public abstract void Show();
        public abstract Boolean IsCorrect();
    }
}