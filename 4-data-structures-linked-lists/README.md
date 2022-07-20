## Linked Lists
Node list which is connected and pointing each other with pointer. Normally start node call **'head'** and the end of the list call **'tail'**. (null terminated.)

    string[] basket = {"apples", "grapes", "pears"};
    
    - linked list: apples -> grapes -> pears
    ex) apples
        8947   -> grapes
                  8742   -> pears
                            372   -> null

### Object
Linked Lists offer the logical steps to understand, and provide flexible participation on the code line by line. It is good to understand how computer process.

### Operations
| Operation | Cost |
|---|---|
| prepend | O(1) |
| append | O(1) |
| lookup | O(n) |
| insert | O(n) |
| remove | O(n) |
| reverse | O(n) |

### Pointing
Referencing a node class for next in current node class as next make chaining node lists (single linked)

     class Node
     {
       public int value { get; set; }
       public Node next { get; set; } // for chaining next Node class

Referencing the both next and previous node class in current node class as both side chaining node lists (double linked)

      class Node
    {
      public int value { get; set; }
      public Node next { get; set; } // for chaining next Node class 
      public Node prev { get; set; } // for chaining previous Node class

### Conclusion
| Pros | Cons |
|---|---|
| Fast Insertion | Slow Lookup |
| Fast Deletion | More Memory |
| Ordered |
| Flexible Size |

---
###### &copy; Joonsoo Kim