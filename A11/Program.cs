﻿using System;

namespace A11 {
    class Program {
        static void Main(string[] args) {
            var tree = new Tree<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child2");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree();
            grand12.PrintAncestors();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
        static void Func(String node) {
            Console.Write(node + " | ");
        }
    }
}