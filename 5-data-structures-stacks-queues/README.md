## Stacks + Queues
Normally data structures are sequentially access. Stacks & Queues offers optimized access for multiple request & access and randomness.

### Stacks
Adding a data stacks in a space. It is usually illustrating as stacking dishes. The **LIFO** (Last In First Out) characteristic is quiet important for language specific engines like as **"Stact Overflow"**.
The world usually use this for **Undo/Redo** too. When you use a Web Browser, you can easily meet the **stacks** when use back button or at the browsing history list. 

#### Stacks Operations
| operation | cost |
|---|---|
| lookup | O(n) |
| pop | O(1) |
| push | O(1) |
| peek | O(1) |

#### Example

    ex) visiting websites
        + twitter (new stack)
        google (1 step behind)
        udemy.com (2 step behind)
        youtube (3 step behind)

    What could be the best fundamental base logic?
    Arrays vs Linked Lists?

The answer is **The Both** operate fairly well and need trade off up to the project.
- Arrays use caches & direct access, technically faster solution. However the operations cost doubling or more for changing datas.
- Linked Lists use dynamic memory and easily scalling the space for the operations 


### Queues
It is for accessing multiple people one by one for example people make lines for get in a restaurant.  The **FIFO** (First In First Out) characteristic is easyly found in a reservation system, Uber Taxi, printer device and so on.

#### Queues Operations
| operation | cost |
|---|---|
| lookup | O(n) |
| enqueue | O(1) |
| dequeue | O(1) |
| peek | O(1) |

#### Example
    ex) providing queues for users
        Matt -- Joy -- Samir -- Pavel -- (goal)
        4th  -- 3rd -- 2nd   -- 1st   -- (access)
 
    What could be the best fundamental base logic?
    Arrays vs Linked List?

The answer is using **Linked List**.
- Arrays, when the queues should change process going to be O(n) because change the index shift for all other datas
- Linked List is just needed change the pointer and the cost mostly O(1) some complex operations O(1) or O(n)

### Conclusion
| pros | cons |
|---|---|
| Fast Operations | Slow Lookup |
| Fast Peek |
| Ordered |

---
###### &copy; Joonsoo Kim