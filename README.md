# linked-list

A linked list is a data structure in which the objects are arranged in a linear order.
Each element of a `doubly linked list` `L` is an object with
an attribute key and two other pointer attributes:
`next` and `prev`. Given an element x in the list, `x.next` points to its successor in the linked list, and `x.prev` points to its predecessor. If `x.prev` is NIL, the element `x` has no predecessor and is therefore the first element, or head, of
the list. If x:next = NIL, the element `x` has no successor and is therefore the last
element, or tail, of the list. An attribute `L.head` points to the first element of the
list. If `L.head` = NIL, the list is empty.

### Searching a linked list:
The function `SEARCH` finds the first element with key `k` in list `L` by a simple linear search, returning a pointer to this element. If no object with
key `k` appears in the list, then the procedure returns `NIL`.
To search a list of n objects, the `SEARCH` function takes O(n) time in the
worst case, since it may have to search the entire list.

### Inserting into a linked list:
Given an element `x` whose key attribute has already been set, the `INSERT` function “splices” `x` onto the front of the linked list. The running time for `INSERT` on a list of n elements is O(1).

### Deleting from a linked list:
The function `DELETE` removes an element `x` from a linked list `L`. It must
be given a pointer to x, and it then “splices” `x` out of the list by updating pointers. If we wish to delete an element with a given key, we must first call `SEARCH` function to retrieve a pointer to the element. If we wish to delete an element with a given key Θ(n) time is required in the worst case because we must first call `SEARCH` to find the
element.

### Getting first value (head):
The function `getFirst` returns value of head from linked list `L`. The running time of `getFirst` function is O(1).

### Logging linked list: 
The function `log` logs whole linked list `L`. Starts logging from `head` while `head.Next` is not `NIL`. The running time of `log` function is Θ(n).