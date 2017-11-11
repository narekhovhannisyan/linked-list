using System;

namespace linked_list {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }
    }
    class linkedList {
        class Node {
            public Node Next;
            public Node Prev;
            public int Value;
        }

        Node head, tail = null;
        linkedList () {
            head.Next = tail;
            head.Prev = null;
            tail.Prev = tail;
            tail.Next = null;
        }

        public int getHead () {
            if (head != null) return head.Value;
            else throw new ArgumentNullException ("Head is null.");
        }

        public int getTail () {
            if (tail != null) return tail.Value;
            else throw new ArgumentNullException ("Tail is null.");
        }
    }
}