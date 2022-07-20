## Graph
The graph is composing three elements **Value, Node & Edge**, and the linked list or trees also one of the graph. Not like the linked list or trees, it is possible to have more than 2 nodes and characteristic edge. Like as the Networks, www, Friendship and so on such as **Facebook** social network, **Amazon**'s recommendation engine or **Google Map** to search shortest route.

    -graph

       6     5
        \  / | \
         4   2 - 1    -value
          \ /         -node(vertex)
           3          -edge

#### 1. Directed & Undirected
When the system needs just connect like as a Highway or a Road needs undirected edge. However, the system needs control with one way like as a Railway or an Oneway Road. For the Facebook vs Twitter is more connected this characteristic. **Facebook needs undirected** search up to the relationships. **Twitter is more directed** because people can follow someone but the one doesn't need to follow.

    .  -directed        -undirected
      a -> b <-> c       a - b - c
      ex) Twitter        Facebook

#### 2. Weighted & Unweighted
A edge could have a value or not. When someone need to plan to visit somewhere needs evaluation such as time or value to be there. It is useful for a **Map & Navigation Service, Planning Service, Recommendation** and so on.

    .   -unweighted              -weighted

    a --- b --- c --- d      a-(5)-b-(2)-c-(9)-d
           \                        \
            \                       (7)
             \                        \
              f                        f

#### 3. Cyclic & Acyclic
There is cyclic phenomenon, and acyclic structures such as the **Internet**. Asyclic usually use doesn't need to have round trip for example like internet([illustration](https://internet-map.net/)), but for example Google Map & Navigation needs round trip.

    -cyclic            -acyclic
        a                  a
       / \                  \
      b - c              b - c


### Conclusion
| Pros | Cons |
|---|---|
| relationships | scaling is hard |

### In Production
[neo4j](https://neo4j.com/) - One of the fastest & state of art solution

---
###### &copy; Joonsoo Kim