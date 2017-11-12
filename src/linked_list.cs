using System;

namespace linked_list {

	class Node {
		public Node Next;
		public Node Prev;
		public int Value;
	}

	class linkedList {

		Node head = null;

		public int getFirst () {
			if (head != null) return head.Value;
			else throw new ArgumentNullException ("Head is null.");
		}

		public linkedList insert (int value) {
			Node insertion = new Node ();
			insertion.Value = value;
			insertion.Next = head;
			if (head != null) {
				head.Prev = insertion;
			}
			head = insertion;
			insertion.Prev = null;
			return this;
		}

		public Node search (int value) {
			Node temp = new Node ();
			temp = head;
			while (temp != null && temp.Value != value) {
				temp = temp.Next;
			}
			return temp;
		}

		public linkedList delete (int value) {
			Node temp = new Node ();
			temp = search (value);
			if (temp.Prev != null) temp.Prev.Next = temp.Next;
			else head = temp.Next;
			if (temp.Next != null) temp.Next.Prev = temp.Prev;
			return this;
		}

		public void log () {
			while (head != null) {
				Console.WriteLine (head.Value);
				head = head.Next;
			}
		}
	}
}