using System;

namespace A05 {
    class Program {
        static void Main (String[] args) {
            String sentence = "";
            if (args.Length == 0) {
                Console.WriteLine("Enter any sentence:");
                sentence = Console.ReadLine();
            } else {
                sentence = args[0];
            }
            Console.WriteLine(ReverseWordLetters(sentence));
            Console.WriteLine(ReverseWordOrder(sentence));
            Console.WriteLine(ReverseAllChars(sentence));
        }

        private static String[] SplitWords(String sentence) {
            return sentence.Split(' ');
        }

        private static String ReverseWordLetters(String sentence) {
            String[] words = SplitWords(sentence);
            String reversedSentence = "";
            foreach (var word in words) {
                reversedSentence += (ReverseAllChars(word) + " ");
            }
            return reversedSentence;
        }

        private static String ReverseWordOrder(String sentence) {
            String[] words = SplitWords(sentence);
            String reversedSentence = "";
            for (int i = words.Length - 1; i >= 0; i--) {
                reversedSentence += (words[i] + " ");
            }
            return reversedSentence;
        }

        private static String ReverseAllChars(String sentence) {
            char[] sentenceAsCharArray = sentence.ToCharArray();
            Array.Reverse(sentenceAsCharArray);
            return new String(sentenceAsCharArray);
        }
    }
}