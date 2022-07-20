## Trees
For this hierarchical data structure uses lots of real-life programs such as **HTML5, AI, Navigation**  and so on.

    -data tree              (linked list)
    
         1                        1
       / | \                      |  
      2  3  4                     2
        / \                       |
       6   7                      3

| Classify | Contents |
|---|---|
| root | 1 |
| parent | 1, 3 |
| child | [2, 3, 4], [6, 7] |
| leaf | 2, 4, 6, 7 |
| sibling | [2, 3, 4], [6, 7] |

---
### Binary Tree
It should have two child node (left, right). Especially it is related with the **Logarithmic** at mathmatics and the bit & binaries of calculation. Quick and the fastest search, and usually using at **Google Search Engine**

    -perfect binary tree   -full binary tree
              1                    1
            /   \                /   \
           2     3              2     3
          / \   / \           /   \     
         4   5 6   7         4     5

- Perfect binary tree - has just two case full children or none, the special things is half of data always on the last children (leaves). The searching could stop when variable found in the process.

      height (level 0 : 2^0 = 1)       
              level 1 : 2^1 = 2
              level 2 : 2^2 = 4         
              level 3 : 2^3 = 8
           # of nodes : 2^h - 1 (1st level is 1 not 2)
         log of nodes : steps (height start from 1)

#### Operations
| Operation | Cost |
|---|---|
| lookup | O(log N) |
| insert | O(log N) |
| delete | O(log N) |

#### Binary Search Tree (BST)

- **Unbalanced Tree***

  Easy to selecting with left or right child by bigger or larger at the value of parent node.

      -unbalanced (BST)
          101
             \
             105
            /   \
          102   144
                  \
                  231
                    \
                     x (x > 231)


- **AVL(Adelson-Velsky&Landis) Tree - Self-balancing BST :**

  When it operate Insert() seems same as unbalanced algorithm, after insert it check the **AVL Balance Factor** with height and change the parent looks rotation at pivot. Insertion, deletion and look-up in guaranteed O(log n) time.
  - [AVL Trees-instruction](https://randerson112358.medium.com/avl-trees-a7b4f1fa2d1a)
  - [AVL Tree in C#](https://simpledevcode.wordpress.com/2014/09/16/avl-tree-in-c/)


- **Red/Black Tree** :

  It is all about the height property to utilize for insert & so on. Need to check more detain at the wikipedia. Insertion, deletion and look-up in guaranteed O(log n) time.
  - [Red-black Tree-Webapp](https://www.cs.usfca.edu/~galles/visualization/RedBlack.html)
  - [Red-black Tree-instruction](https://ko.wikipedia.org/wiki/%EB%A0%88%EB%93%9C-%EB%B8%94%EB%9E%99_%ED%8A%B8%EB%A6%AC)
  - [Red-black Tree-another-instruction](https://medium.com/basecs/painting-nodes-black-with-red-black-trees-60eacb2be9a5)

- **.net** C# doesn't have BST but the Red-black Tree named **SortedSet** class in System.Collections.Generic (above .net 4.0)

      // Created sorted set of strings.
      var set = new SortedSet<string>();

      // Add three elements.
      set.Add("net");
      set.Add("net");  // Duplicate elements are ignored.
      set.Add("dot");
      set.Add("rehan");

      // Remove an element.
      set.Remove("rehan");

      // Print elements in set.
      foreach (var value in set)
      {
        Console.WriteLine(value);
      }

      // Output is in alphabetical order:
      // dot
      // net

#### Conclusion - Binary Tree
| Pros | Cons |
|---|---|
| better than O(n) | no O(1) operations |
| ordered |
| flexible size |

---
### Binary Heap Tree
Basic principle that parent node should larger than children, and left or right doesn't care which is higher. This characteristic gives the great performance for comparison operations & range works. It just find and check children in the range.

    -binary heap tree
            101
          /     \
         75      31    
        /  \    /  \     
       3   45  4    1

#### Memory Heap != Heap Data Structure

#### Priority Queue for Insertion
Each data have priority data, and pop() them up to the priority.

#### Operations
| Operation | Cost |
|---|---|
| lookup | O(n) |
| insert | O(log N) |
| delete | O(log N) |

#### Conclusion - Binary Heap Tree
| Pros | Cons |
|---|---|
| better than O(n) | slow lookup |
| priority |
| flexible size |
| fast insert |

---
### Trie Tree
It is speciallzed searching the text. It keeps letters in each node for a word. For example it is not only benefit to find text but also like as **quick word suggestion** during search input, and so on. 

      -trie tree
                  Start         -start node is empty
             /     / \    \
           A      D    N    Z
          / \    /    / \    \                - ARE
         R   S  O    E   O    E               - AS
        /      /    /     \    \              - DOT
       E      T    W       T    N             - NEWS
                  /                           - NOT
                 S                            - ZEN

  - O(word length) blazing quick and Space O benefit than store the all the word with multiplied letters in dictionary

---
###### &copy; Joonsoo Kim