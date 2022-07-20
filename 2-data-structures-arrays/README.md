## Array
Try to make usual operation implemented array class to understand the characteristics.

### Operations
| Operation | Cost |
|---|---|
| lookup | O(1) |
| push | O(1) |
| insert | O(n) |
| delete | O(n) |

### Space Complexity
    string[] strings = new strings() {"a", "b", "c", "d"};
    // 4*4 = 16 bytes of storage (32bit system)
    
    Console.WriteLine(strings[2]); // "c"

- Javascript Operations
 
  - push

        strings.push('e'); // O(1)

  - pop (Remove last item)

        strings.pop(); // O(1)

  - unshift (Put object in front) :

        strings.unshift('x'); // O(n)
        // ['x' ,'a' ,'b' ,'c' ,'d']

  - splice (add object at assigned index)

        strings.splice(2, 0, 'alien'); // O(n/2)=>O(n)
        // ['x', 'a', 'alien', 'b', 'c']
   
Usual array operation provided in C# standard library with ArrayList(System.Collections.Generic)

    ArrayList strings = new ArrayList();
    strings.Add("a", "b", "c", "d");

    strings.Add("e"); // push
    strings.RemoveAt(strings.Count - 1); //pop
    strings.Insert(0, "x"); // unshift
    strings,Insert(2, "alien"); // splice


## Dynamic Array

### Operations
| Operation | Cost |
|---|---|
| lookup | O(1) |
| append | O(1) or O(n) |
| insert | O(n) |
| delete | O(n) |

---
###### &copy; Joonsoo Kim