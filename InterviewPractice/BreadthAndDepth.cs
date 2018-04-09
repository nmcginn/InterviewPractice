using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPractice
{
    public class BreadthAndDepth
    {
        public static string BreadthFirstSearch(Node root)
        {
            Console.WriteLine("BREADTH FIRST");
            var queue = new Queue<Node>();
            var result = "";
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result += current.Visit();
                foreach (var neighbor in current.Neighbors.Where(x => !x.Visited))
                {
                    queue.Enqueue(neighbor);
                }
            }
            return result;
        }

        public static string DepthFirstSearch(Node root)
        {
            Console.WriteLine("\nDEPTH FIRST");
            var stack = new System.Collections.Generic.Stack<Node>();
            var result = "";
            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                result += current.Visit();
                foreach (var neighbor in current.Neighbors.Where(x => !x.Visited))
                {
                    stack.Push(neighbor);
                }
            }
            return result;
        }
    }

    public class Node
    {
        public List<Node> Neighbors { get; set; }
        public string Value { get; set; }
        public bool Visited { get; set; }

        public Node()
        {
            Neighbors = new List<Node>();
            Value = "";
            Visited = false;
        }

        public string Visit()
        {
            Console.Write(Value);
            Visited = true;
            return Value;
        }

        public static Node GetTestData()
        {
            var root = new Node() { Value = "A" };
            root.Neighbors.Add(new Node() { Value = "B" });
            root.Neighbors.Add(new Node() { Value = "C", Neighbors = new List<Node>() { new Node() { Value = "E" } } });
            root.Neighbors.Add(new Node()
            {
                Value = "D",
                Neighbors = new List<Node>() {
                new Node() { Value = "F" },
                new Node() { Value = "G" } }
            });
            return root;
        }
    }
}
