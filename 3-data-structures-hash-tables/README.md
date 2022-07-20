## Hash Table
Store datas with key + value => Create a Node!

     ex) object.grapes = 10000;

### Operations
| Operation | Cost |
|---|---|
| insert | O(1) |
| lookup | O(1) |
| delete | O(1) |
| search | O(1) |

### Hash Collision
Hash function automatically stacking on memory the hashes when it is going to be more & mode. Collision means using same memory address more than a hash. However, the collision slows down the abilities to read (O(n)).

There is two sollutions avoiding the collision.
 
    1. Separate Chaining (Hash Table)
    2. Open Addressing

### Indempotent
> MD5 : One Way
> SHA-1 fast!
> SHA-256 takes lots of time.

### Conclusion
| Pros | Cons |
|---|---|
| Fast lookups* | Unordered |
| Fast inserts | Slow key iteration |
| Flexible Keys |   |

###### *Good collision resolution needed

---
###### &copy; Joonsoo Kim