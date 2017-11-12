using System;

namespace linked_list {
  class Program {
    static void Main (string[] args) {
      linkedList ll = new linkedList ();
      ll.insert (5);
      Console.WriteLine (ll.getFirst ());
      ll.insert (3).insert (4).insert (12).delete (12);
      ll.log ();
    }
  }
}