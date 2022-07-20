using System;
using System.Collections.Generic;


namespace Search
{
  public class BinarySearchTrees
  {
    public BinarySearchTrees()
    {
      BinarySearchTree tree = new BinarySearchTree();
      //         9
      //    4        20
      // 1     6  15   170
      tree.Insert(9);
      tree.Insert(4);
      tree.Insert(6);
      tree.Insert(20);
      tree.Insert(170);
      tree.Insert(15);
      tree.Insert(1);

      PrintTree(tree);
      Console.WriteLine();

      // Depth First Search
      // InOrder - 1, 4, 6, 9, 15, 20, 170
      tree.InOrderDFS();
      Console.WriteLine();
      tree.PreOrderDFS();
      Console.WriteLine();
      tree.PostOrderDFS();
      // PreOrder - 9, 4, 1, 6, 20, 15, 170 
      // (Good to re-create tree)
      // PostOrder - 1, 6, 4, 15, 170, 20, 9
    }
    
    public string PrintArray(object[] input, int i)
    {      
      Console.Write(Convert.ToString(input[i]));
      if(i < input.Length - 1)
      {
        Console.Write(", ");                
      }
      else
      {
        Console.WriteLine();
        return "";              
      }
      return PrintArray(input, i + 1);
    }  
    
    public void PrintTree(BinarySearchTree tree)
    {
      print2DUtil(tree.root, 0);
    }

    // Print Tree Horizontally (from anirban-s)
    int COUNT = 5;
    private void print2DUtil(Node root, int space)
    {
      // Base case  
      if (root == null)
          return;

      // Increase distance between levels  
      space += COUNT;

      // Process right child first  
      print2DUtil(root.right, space);

      // Print current node after space  
      // count  
      Console.Write("\n");
      for (int i = COUNT; i < space; i++)
      {
        Console.Write(" ");
      }
      Console.Write(root.value + "\n");
      
      // Process left child  
      print2DUtil(root.left, space);
    }
  }
  
  public class BinarySearchTree
  {
    public Node root { get; set; }
    
    public BinarySearchTree()
    {
      this.root = null;
    }

    public void Insert(object value)
    {
      Node node = new Node(value);
      if (this.root == null)
      {
        this.root = node;
        return;
      }
      else
      {
        Node currentNode = this.root;
        while(true)
        {
          if(Convert.ToInt32(value) < Convert.ToInt32(currentNode.value))
          {
            // Left
            if(currentNode.left == null)
            {
              currentNode.left = node;
              return;
            }
            currentNode = currentNode.left;
          }
          else
          {
            // Right
            if(currentNode.right == null)
            {
              currentNode.right = node;
              return;
            }
            currentNode = currentNode.right;
          }
        }
      }
    }

    public string LookUp(object value)
    {
      if(this.root == null)
      {
        return "null";
      }

      Node node = Search(value);
      if(node != null)
      {
        return "Found! : " + node.value;
      }
      return "false";
    }

    public void Remove(object value)
    {
      Node nodeToRemove = this.root; // remove target node
      Node parentNode = null;        // parent of nodeToRemove
      // Search for delete & the node's parent
      while (Convert.ToInt32(nodeToRemove.value) != Convert.ToInt32(value))
      {
        parentNode = nodeToRemove;
        if(Convert.ToInt32(value) < Convert.ToInt32(nodeToRemove.value)) 
        {
          nodeToRemove = nodeToRemove.left;
        }
        else if (Convert.ToInt32(value) > Convert.ToInt32(nodeToRemove.value))
        {
          nodeToRemove = nodeToRemove.right;
        }
      }

      Node replacementNode = null;
      // case 1 right node
      if(nodeToRemove.right != null)
      {
        replacementNode = nodeToRemove.right;
        if(replacementNode.left == null)
        {
          replacementNode.left = nodeToRemove.left;
        }
        else
        {
          Node replacementParentNode = nodeToRemove;
          while (replacementNode.left != null)
          {
            replacementParentNode = replacementNode;
            replacementNode = replacementNode.left; // replacement.left move to replacement position
          }
          replacementParentNode.left = null;
          replacementNode.left = nodeToRemove.left;
          replacementNode.right = nodeToRemove.right;
        }
      }
      // case 2. left node
      else if (nodeToRemove.left != null)
      {
        replacementNode = nodeToRemove.left;
      }

      if (parentNode == null)
      {
        this.root = replacementNode;
      }
      else if (parentNode.left == nodeToRemove)
      {
        parentNode.left = replacementNode;
      }
      else
      {
        parentNode.right = replacementNode;
      }  
    }

    Node Search(object value)
    {
      Node currentNode = this.root;
      while(currentNode!=null)
      {
      if(Convert.ToInt32(value) < Convert.ToInt32(currentNode.value))
        {
          // left
          currentNode = currentNode.left;
        }
        else if(Convert.ToInt32(value) > Convert.ToInt32(currentNode.value))
        {
          // right
          currentNode = currentNode.right;
        }
        else if(Convert.ToInt32(value) == Convert.ToInt32(currentNode.value))
        {
          return currentNode;
        }
      }
      return null;
    }

    public object[] SearchBFS()
    {
      Node currentNode = this.root;
      List<object> list = new List<object>();
      Queue<Node> queue = new Queue<Node>();

      queue.Enqueue(currentNode);
      
      while(queue.Count > 0)
      {
        currentNode = queue.Dequeue();
        // Console.Write(Convert.ToInt32(currentNode.value) + ", ");
        list.Add(currentNode.value);
        
        if(currentNode.left != null)
        {
          queue.Enqueue(currentNode.left);
        }
        if(currentNode.right != null)
        {
          queue.Enqueue(currentNode.right);
        }
      }

      return list.ToArray();
    }

    public object[] SearchBFSRecursive(List<object> list, Queue<Node> queue)
    {
      if(queue.Count == 0)
      {
        return list.ToArray();
      }
      
      Node currentNode = queue.Dequeue();
      list.Add(currentNode.value);

      if(currentNode.left != null)
      {
        queue.Enqueue(currentNode.left);
      }
      if(currentNode.right != null)
      {
        queue.Enqueue(currentNode.right);
      }
      return SearchBFSRecursive(list, queue);
    }

    // public object[] InOrderDFS()
    public void InOrderDFS() // Space comlexity : O(height of tree n)
    {
      List<object> list = new List<object>();
      object[] result = TraverseDFS(this.root, list, SortMode.InOrder); 
    }

    public void PreOrderDFS() // Space complexity : O(height of tree n)
    {
      List<object> list = new List<object>();
      object[] result = TraverseDFS(this.root, list, SortMode.PreOrder);
    }
    
    public void PostOrderDFS() // Space complexity : O(height of tree n)
    {
      List<object> list = new List<object>();
      object[] result = TraverseDFS(this.root, list, SortMode.PostOrder);
    }
    
    object[] TraverseDFS(Node node, List<object> list, SortMode sortMode)
    {
      if(sortMode == SortMode.PreOrder)
      {
        Console.Write(Convert.ToString(node.value) + " ");
        list.Add(node.value);
      }
      
      if(node.left != null)
      {
        TraverseDFS(node.left, list, sortMode);
      }
      
      if(sortMode == SortMode.InOrder)
      {
        Console.Write(Convert.ToString(node.value) + " ");
        list.Add(node.value);
      }
      
      if(node.right != null)
      {
        TraverseDFS(node.right, list, sortMode);
      }

      if(sortMode == SortMode.PostOrder)
      {
        Console.Write(Convert.ToString(node.value) + " ");
        list.Add(node.value);
      }
      
      return list.ToArray();
    }
  }

  public enum SortMode
  {
    InOrder = 1,
    PreOrder = 2,
    PostOrder = 3
  }
  
  public class Node 
  {
    public Node left { get; set; }
    public Node right { get; set; }
    public object value { get; set; }

    public Node(object value)
    {
      this.left = null;
      this.right = null;
      this.value = value;
    }
  }
}