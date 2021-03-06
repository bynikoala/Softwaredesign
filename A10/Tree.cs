using System;
using System.Collections.Generic;

namespace A10 {
    class Tree<T> {
        public delegate void Func(Tree<T> node);
        public T treeVar;
        public List<Tree<T>> children = new List<Tree<T>>();
        public Tree<T> parent;

        public override string ToString() {
            if (typeof(T).IsValueType || typeof(T) == typeof(String)) {
                return this.treeVar.ToString();
            }
            return "";
        }
        public Tree<T> CreateNode(T nodeVar) {
            Tree<T> nodeTree = new Tree<T> {
                treeVar = nodeVar
            };
            return nodeTree;
        }
        public void AppendChild(Tree<T> childNode) {
            children.Add(childNode);
            childNode.parent = this;
        }
        public void RemoveChild(Tree<T> childNode) {
            children.Remove(childNode);
        }
        public void PrintTree() {
            Console.WriteLine(treeVar);
            if (children.Count > 0) {
                foreach (Tree<T> child in children) {
                    Console.Write("*");
                    if (parent != null)
                        Console.Write("*");
                    child.PrintTree();
                }
            }
        }
        public void PrintAncestors() {
            if (parent != null) {
                parent.PrintAncestors();
            }
            Console.Write("#");
            Console.WriteLine(treeVar);
        }
        public void ForEach(Func func) {
            func(this);
            foreach (Tree<T> child in children) {
                child.ForEach(func);
            }
        }
    }
}