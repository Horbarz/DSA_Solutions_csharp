// C# program to find count of distinct nodes 
// on a path with maximum distinct nodes. 
using System;
using System.Collections.Generic;

class GFG
{

    // A node of binary tree 
    public class Node
    {
        public int data;
        public Node left, right;
    };

    // A utility function to create a new Binary 
    // Tree node 
    public static Node newNode(int data)
    {
        Node temp = new Node();
        temp.data = data;
        temp.left = temp.right = null;
        return temp;
    }

    public static int largestUinquePathUtil(Node node,
                                    Dictionary<int, int> m)
    {
        if (node == null)
            return m.Count;

        // put this node into hash 
        if (m.ContainsKey(node.data))
        {
            m[node.data] = m[node.data] + 1;
        }
        else
        {
            m.Add(node.data, 1);
        }

        int max_path = Math.Max(largestUinquePathUtil(node.left, m),
                                largestUinquePathUtil(node.right, m));

        // remove current node from path "hash" 
        if (m.ContainsKey(node.data))
        {
            m[node.data] = m[node.data] - 1;
        }

        // if we reached a condition where all 
        // duplicate value of current node is deleted 
        if (m[node.data] == 0)
            m.Remove(node.data);

        return max_path;
    }

    // A utility function to find long unique value path 
    public static int largestUinquePath(Node node)
    {
        if (node == null)
            return 0;

        // hash that store all node value 
        Dictionary<int,
                int> hash = new Dictionary<int,
                                            int>();

        // return max length unique value path 
        return largestUinquePathUtil(node, hash);
    }

    // Driver Code 
}

// This code is contributed by 29AjayKumar 

