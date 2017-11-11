using System;

namespace linked_list {
  class Program {
    static void Main (string[] args) {
      linkedList ll = new linkedList ();
      ll.insert (5);
      Console.WriteLine (ll.getFirst ());
      ll.insert (3);
      ll.insert (76);
      ll.insert (12);
      ll.delete (12);
      ll.log ();
    }
  }
}