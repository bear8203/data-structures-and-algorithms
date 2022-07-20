## BFS + DFS (Searching)

### Linear Search
    6    12    1    34    4    9
    O(1)                    O(n)

### Binary Search

### Graoh & Tree Traversal
Lookup all the element and need a strategy to find right algorithm88

### Breadth First Search - BFS
It is a method of visiting or searching for nodes or vertices of a tree or graph from a nearby place. It is good to find shortest node and all the possibilities to destination in limited bound.

    - breadth first search
    
          1     ->      1     ->      1     ->      1
                      / | \         / | \         / | \
                     2  3  4       2  3  4       2  3  4
                                  /  / \  \     /  / \  \
                                 5  6   7  8   5  6   7  8
                                                  |
                                                  9

1. Start from root
2. Save children nodes
3. Visiting saved nodes, and save again the children of visiting nodes.
4. (Loop)
5. When traversal all the nodes, searching is finished.              

#### Conclusion - BFS
| Pros | Cons |
|---|---|
| shortest path | more memory |
| closer nodes |

### Depth First Search - DFS
It is searching each branch ends, and next branch search. It usually use lower memory than the Breadth First Search. It is good to check or find a certain path evaluation.

    - depth first search

          1     ->      1     ->      1     ->      1
                      /             / |           / |  
                     2             2  3          2  3   
                    /             /             /  /  
                   5             5             5  6    
                   
    ->    1     ->      1     ->      1     ->      1
        / |           / |           / | \         / | \
       2  3          2  3          2  3  4       2  3  4
      /  /          /  / \        /  / \        /  / \  \
     5  6          5  6   7      5  6   7      5  6   7  8
        |             |             |             |
        9             9             9             9  

#### Conclusion - DFS
| Pros | Cons
|---|---|
| less memory | can get slow
| does path exist?

### Interview about when to use BFS or DFS
- If you know a solution is not far from the root of the tree?
- If the tree is very deep and solutions are rare?      
- If the tree is very wide(even if it is not binary tree)?
- If solutions are frequent but located deep in the tree?
- Determining whether a path exists between two nodes?
- Finding the shortest path?

### Interview about BFS
- Validate binary search tree - https://leetcode.com/problems/validate-binary-search-tree/