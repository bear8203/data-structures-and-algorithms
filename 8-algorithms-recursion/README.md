## Recursion
A function could call same function inside and keep calling the same function until getting desired result.

    Recursion - Stop
              \
                Recursion - Stop      
                          \ 
                            Recursion - Stop
                                      \ 
                                        Recursion - ...

- ex) bash 'ls' Operation    

      @ ls
      replit.nix   Main.cs      main.csproj   ...
      folder1      folder2

      @ ls -R (Recursion)
      .:  
      replit.nix   Main.cs      main.csproj   ...
      folder1      folder2

      ./folder1:
      file1.cs     file2.cs     file3.cs      ...

      ./folder2:
      file2-1.cs   file2-2.cs   file2-3.cs    ...


- ex) A Function
    
      void Inception()
      {
        // Recursive Case
        return Inception();
      }
  
      // Inception() -> Inception() -> Inception() -> ...

### Stack Overflow
A memory is limited and if the function couldn't stop in certain condition, it is going to be 'Out of Memory' and 'Stack Overflow'. Need careful strategy to use the recursion.

### Elements
- Identify the base case
- Identify the recursive case
- Get closer & return when needed - Usually use 2 returns

### Recursion vs Iterative
| Recursion | Iterative |
|---|---|
| make code dry | relatively complex |
| readability | difficult for others |
| simple stack | large stack |

### Tail Call Optimization
Recursion gives stack call & memory optimization.

### Using a Tree or Converting into a tree, Consider Recursion.
1. Divided into a number of subproblems that are smaller instances of the same problem.
2. Each instance of the subproblem is identical in nature.
3. The solutions of each subproblem can be combined to solve the problem at hand.
### **Divide and Conquer using Recursion**

### Any recursion could be done iteratively (loops)