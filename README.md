# linked-list

A linked list is a data structure in which the objects are arranged in a linear order.
Each element of a `doubly linked list` `L` is an object with
an attribute key and two other pointer attributes:
`next` and `prev`. Given an element x in the list, `x.next` points to its successor in the linked list, and `x.prev` points to its predecessor. If `x.prev` is NIL, the element `x` has no predecessor and is therefore the first element, or head, of
the list. If x:next = NIL, the element `x` has no successor and is therefore the last
element, or tail, of the list. An attribute `L.head` points to the first element of the
list. If `L.head` = NIL, the list is empty.

