using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HomeWorkGB
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            var tree = new Tree(20);
            for (int i = 0; i < 15; i++)
            {
                tree.AddItem(i * 5);
            }
        }
        static TreeNode BFS(Tree tree, int search_value)
        {
            var res = new TreeNode();
            var fail = new TreeNode();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree.GetRoot()); //обходим дерево в ширину с помощью очереди в поисках нужного значения, если его нет, возвращаем пустой элемент
            while (queue.Count != 0)
            {
                res = queue.Dequeue();
                if (res?.Value == search_value)
                {
                    return res;
                }
                if (res.LeftChild != null)
                {
                    queue.Enqueue(res?.LeftChild);
                }
                if (res.RightChild != null)
                {
                    queue.Enqueue(res?.RightChild);
                }
            }
            return fail;
        }
        static TreeNode DFS(Tree tree, int search_value)
        {
            var res = new TreeNode();
            var fail = new TreeNode();
            var stack = new Stack<TreeNode>();
            stack.Push(tree.GetRoot());                  //обходим дерево в глубину с помощью стека в поисках нужного значения, если его нет, возвращаем пустой элемент
            while (stack.Count != 0)
            {
                res = stack.Pop();
                if (res?.Value == search_value)
                {
                    return res;
                }
                if (res.LeftChild != null)
                {
                    stack.Push(res?.LeftChild);
                }
                if (res.RightChild != null)
                {
                    stack.Push(res?.RightChild);
                }
            }
            return fail;
        }
    }
        
}

