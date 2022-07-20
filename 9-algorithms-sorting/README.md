## Sorting
Big companies like as google, Amazon, Apple, Netflix, Microsoft and so on, they consider the sorting algorithm serious and care about it.

### Trade Off
There are many algorithms, but it depends on the data type, device or memory situations. So, it needs to be know about the algorithms, and use it wisely with trade off.

### C# and .net Official Sort()
In general when using “Sort()” on a List, Array or Collection it will use :
- If the collection has less than 16 elements, the algorithm **“Insertion Sort”** will be used.
- If the number of partitions exceeds 2 log *array size*, then **Heap Sort** is used.
- Otherwise **Quick Sort** is used.
  
However this is not always the case, For example when using Linq on a list and calling OrderBy, Quick Sort is always used as the underlying implementation. 

### Sorting Algorithms
There are a lot of algorithms to solve this problems, but we need to experience and then go deeper. These are good to start as below ([More algorithms & details in Wikipedia](https://en.wikipedia.org/wiki/Sorting_algorithm)) :
1. **Elementry Sort** 
   1. **Bubble Sort** - One of a simpler possible sort. It has pros about that space complexity is O(1), and the time complexity the mostly O(n^2) but O(n) sometimes. ([Bubble Sort Dance](https://youtu.be/lyZQPjUT5B4))
   2. **Insertion Sort** - One of a simpler possible sort. It uses small space O(1), and it gives O(n) when the data is not a lot. Otherwise, it takes time O([Insertion Dance](https://youtu.be/EdIKIf9mHk0))
   3. **Selection Sort** - One of a simpler possible sort. It has pros about that space complexity is O(1), but the time complexity always O(n^2). ([Selection Dance](https://youtu.be/0-W8OEwLebQ))
4. **Complex Sort**
   1. **Merge Sort** - It is an efficient, general-purpose, and comparison-based sorting algorithm. Most implementations produce a stable sort, which means that the order of equal elements is the same in the input and output. It has pros about that space complexity is O(n), and the time complexity always O(n log n). ([Merge Dance](https://youtu.be/dENca26N6V4))
   2. **Quick Sort** - It is an in-place sorting algorithm. Developed by Tony Hoare in 1959 and published in 1961, it is still a commonly used algorithm for sorting. When implemented well, it can be somewhat faster than merge sort and about two or three times faster than heap sort. **Small amount of swap** ([Quick Dance](https://youtu.be/3San3uKKHgg))

          -quick sort
                                                _------- pick a random pivot "4"
              [ 3 | 7 | 8 | 5 | 2 | 1 | 9 | 5 | 4 ]      compare all with the pivot!

                    _                       _ <-_      - compare 7 & *4 => 4 & 7
              [ 3 | 7 | 8 | 5 | 2 | 1 | 9 | 5 |*4 ]    - compare 5 & *4 => 4 & 5
                    --------------------------->
                    _                   _ <-_          - compare 9 & *4 => 4 & 9
              [ 3 | 5 | 8 | 5 | 2 | 1 | 9 |*4 | 7 ]    - compare *4 & 5 => 4 & 5
                    ----------------------->
                    _               _ <-_              - compare *4 & 5 => 4 & 5
              [ 3 | 9 | 8 | 5 | 2 | 1 |*4 | 5 | 7 ]    - compare *4 & 5 => 4 & 5
                    ------------------->
                        _       _ <-_                  - compare *4 & 5 => 4 & 5
              [ 3 | 1 | 8 | 5 | 2 |*4 | 9 | 5 | 7 ]    - compare *4 & 5 => 4 & 5
                        ----------->
                            _ <-_                      - compare *4 & 5 => 4 & 5
              [ 3 | 1 | 2 | 5 |*4 | 8 | 9 | 5 | 7 ]    - compare *4 & 5 => 4 & 5
                            --->

              [ 3 | 1 | 2 |*4 | 5 | 8 | 9 | 5 | 7 ]    - compare *4 & 5 => 4 & 5
                    |       |           |
              _   _ <-_     |         _       _ <-_    
            [ 3 | 1 |*2 ]   |   [ 5 | 8 | 9 | 5 |*7 ]
              ------->      |         ----------->
                            |             _ <-_    
            [ 1 | 2 | 3 ]   |   [ 5 | 5 | 9 |*7 | 8 ]
                  |         |
                  |         |            
                  |         |   [ 5 | 5 | 7 | 9 | 8 ]
                  |         |    _|       |       |
                  |         |   |         |     _ <-_
                  |         | [ 5 | 5 ]   |   [ 9 |*8 ]
                  |         |   |         |     --->
                  |_        |   |        _|     |
                    |       |   |       |     [ 8 | 9 ]
                    |       |   |       |    ___|
                    |       |   |       |   |
              [ 1 | 2 | 3 | 4 | 5 | 5 | 7 | 8 | 9 ]
            
### Operations
| Sort | Time Complexity | Space Complexity | |
|---|---|---|---|
| bubble sort | O(n^2) or O(n) | O(1) |
| insertiona sort | O(n^2) or O(n)* | O(1) | for small amount elements |
| selection sort | O(n^2) | O(1) |
| merge sort | O(n log n) | O(n) | process huge amount of elements |
| quick sort | O(n), O(n log n) or O(n^2) | O(log n) or O(n) | up to how to select pivot
###### *If the data is not a lot, then It gives good performance.

### Stable vs Unstable Algorithms
A sorting algorithm is said to be **stable** if two objects with equal keys appear in the same order in sorted output as they appear in the input array to be sorted. Some sorting algorithms are stable by nature like Insertion sort, Merge Sort, Bubble Sort, etc. And some sorting algorithms are not, like Heap Sort, Quick Sort, etc.

Background: a "stable" sorting algorithm keeps the items with the same sorting key in order. Suppose we have a list of 5-letter words:
    
    peach
    straw
    apple
    spork
If we sort the list by just the first letter of each word then a stable-sort would produce:

    apple
    peach
    straw
    spork
In an unstable sort algorithm, straw or spork may be interchanged, but in a stable one, they stay in the same relative positions (that is, since straw appears before spork in the input, it also appears before spork in the output).

We could sort the list of words using this algorithm: stable sorting by column 5, then 4, then 3, then 2, then 1. In the end, it will be correctly sorted. Convince yourself of that. (by the way, that algorithm is called radix sort)

Conclusively, we are asked to sort "by last name, then by first". We could first sort (stable or unstable) by the first name, then stable sort by the last name. After these sorts, the list is primarily sorted by the last name. However, where last names are the same, the first names are sorted.

| Stable Algorithm | Unstable Algorithm |
|---|---|
| **merge sort*** | **quick sort***
| **insertion sort** | **selection sort**
| **bubble sort** | **[heap sort](https://brilliant.org/wiki/heap-sort/)**
| tim sort | shell sort
| counting sort | introsoft (subject to quicksort)
| block sort | tree sort
| quadsort | cycle sort
| library sort | smoothsort 
| cocktail shaker sort | tournament sort (subject to heapsort)
| gnome sort
| odd–even sort

### Non-Comparision Sorting
It is only work with numbers. 
- Counting Sort - [Reference](https://brilliant.org/wiki/counting-sort/) & [Animation](https://www.cs.usfca.edu/~galles/visualization/CountingSort.html)
- Radix Sort - [Reference](https://brilliant.org/wiki/radix-sort/) & [Animation](https://www.cs.usfca.edu/~galles/visualization/RadixSort.html)

### Intuitive References
- [Sorting Algorithms Animations, Toptal](https://www.toptal.com/developers/sorting-algorithms) - Good to understand intuitively
- [15 Sorting Algorithms in 6 Minutes with Sound!](https://youtu.be/kPRA0W1kECg) - Great exploration with sound, good to be relax to understand

### Common Question
- Compare with Quick Sort and Heap Sort. - [Link](https://stackoverflow.com/questions/2467751/quicksort-vs-heapsort)

### Test (https://samsungu.udemy.com/course/master-the-coding-interview-data-structures-algorithms/learn/lecture/12407184#content)
Nobody ask to build own algorithm from the nothing & **When to use & why is** the most important point.
1. Sort 10 schools around your house by distance? (A: insertion sort)
2. eBay sorts listings by the current Bid amount? (A: radix or counting sort)
3. Sort sport scores on ESPN? (A: quick sort) (less memory than merge sort)
4. Massive database (can't fit all into memory) needs to sort through past year's user data? (A: merge sort)
5. Almost sorted Udemy review data needs to update and add 2 new reviews (A: insertion sort)
6. Temperature records for the past 50 years in Canada? (A: radix or counting sort or quick sort-if decimal places)
7. Large user name database needs to be sorted. Data is very random (A: quick sort - save memory & randomness)
8. If you want to teach sorting for the first time? (A: bubble and selection sort)