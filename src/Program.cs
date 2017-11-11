using System;

namespace linked_list {
	class Program {
		static void Main (string[] args) { }
	}

	class Node {
		public Node Next;
		public Node Prev;
		public int Value;
	}

	class linkedList {

		Node head, tail, temp = null;

		public int getFirst () {
			if (head != null) return head.Value;
			else throw new ArgumentNullException ("Head is null.");
		}

		public int getLast () {
			if (tail != null) return tail.Value;
			else throw new ArgumentNullException ("Tail is null.");
		}

		public void add (int value) {
			if (head == tail) {
				head.Value = tail.Value = value;
				head.Next = tail.Prev;
				head.Prev = tail.Next = null;
			} else {
				temp = head;
				head.Value = value;
				head.Next = temp;
			}
		}

		public Node search (int value) {
			temp = head;
			while (temp != null && temp.Value != value) {
				temp = temp.Next;
			}
			return temp;
		}

		public void remove (int value) {
			temp = search (value);
			if (temp.Prev != null) temp.Prev.Next = temp.Next;
			else head = temp.Next;
			if (temp.Next != null) temp.Next.Prev = temp.Prev;
		}
	}
}