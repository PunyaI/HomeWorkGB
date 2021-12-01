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
            Console.WriteLine("            Наше дерево: ");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(),0);
            Console.WriteLine();
            int search_value = 45;
            Console.WriteLine();
            Console.WriteLine("                           Поиск в ширину");
            Console.WriteLine();
            Console.WriteLine("               Сначала добавляем в очередь корень дерева.");
            Console.WriteLine("    Затем вытаскиваем из начала очереди элемент, сравниваем его с искомым, ");
            Console.WriteLine("         если не он - добавляем в конец очереди детей этого элемента.");
            Console.WriteLine("            Повторяем, пока не найдём или не обойдём всё дерево.");
            Console.WriteLine();
            Console.WriteLine("Ниже изменения очереди на каждой итерации:");
            var res = BFS(tree, search_value);
            Console.WriteLine();
            Console.WriteLine("Как видим по наполнению очереди последовательные элементы в ней идут с одного уровня глубины, ");
            Console.WriteLine("то есть действительно обход дерева в ширину. ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            Наше дерево: ");
            Console.WriteLine();
            tree.PrintTree(tree.GetRoot(), 0);
            Console.WriteLine();
            Console.WriteLine("Поиск в глубину");
            Console.WriteLine();
            Console.WriteLine("                 Сначала добавляем в стек корень дерева.");
            Console.WriteLine("      Затем вытаскиваем из конца стека элемент, сравниваем его с искомым, ");
            Console.WriteLine("          если не он - добавляем в конец стека детей этого элемента.");
            Console.WriteLine("             Повторяем, пока не найдём или не обойдём всё дерево.");
            Console.WriteLine();
            Console.WriteLine("Ниже изменения стека на каждой итерации:");
            res = DFS(tree, search_value);
            Console.WriteLine();
            Console.WriteLine("Как видим по детализации благодаря тому, что берем каждый раз последний положенный элемент ");
            Console.WriteLine("мы обходим дерево по каждой ветке по очереди на всю глубину. ");
            Console.WriteLine("То есть это действительно поиск в дереве в глубину ");
        }
        static void PrintStepQueue(Queue<TreeNode> queue)
        {
            Console.Write("       ");
            foreach (var item in queue)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
        static void PrintStepStack(Stack<TreeNode> stack)
        {
            Console.Write("       ");
            foreach (var item in stack)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
        static TreeNode BFS(Tree tree, int search_value)
        {
            int i = 0;
            Console.WriteLine();
            var res = new TreeNode();
            var fail = new TreeNode();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree.GetRoot()); //обходим дерево в ширину с помощью очереди в поисках нужного значения, если его нет, возвращаем пустой элемент
            PrintStepQueue(queue);
            Console.WriteLine();
            Console.WriteLine($"Сравниваем первый в очереди '{tree.GetRoot().Value}' с искомым '{search_value}', ");
            Console.WriteLine($"Они не равны, поэтому вытаскиваем его и добавляем в очередь двух его 'детей': {tree.GetRoot().LeftChild.Value} и {tree.GetRoot().RightChild.Value}");
            Console.WriteLine();
            while (queue.Count != 0)
            {
                int now = queue.Peek().Value;
                res = queue.Dequeue();
                if (res?.Value == search_value)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Сравниваем первый в очереди '{now}' с искомым '{search_value}', ");
                    Console.WriteLine("Они равны, искомый элемент найден! Возвращаем его значание, прекращаея обход.");
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
                if (i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Сравниваем первый в очереди '{now}' с искомым '{search_value}', ");
                    Console.WriteLine($"Они не равны, поэтому вытаскиваем его и добавляем в очередь двух его 'детей' (если они есть): {res.LeftChild?.Value} и {res.RightChild?.Value}.");
                    Console.WriteLine();
                }
                PrintStepQueue(queue);
                i++;
            }
            Console.WriteLine("Искомый элемент не найден, поэтому возвращаем пустой элемент");
            return fail;
        }
        static TreeNode DFS(Tree tree, int search_value)
        {
            int i = 0;
            Console.WriteLine();
            var res = new TreeNode();
            var fail = new TreeNode();
            var stack = new Stack<TreeNode>();
            stack.Push(tree.GetRoot());                  //обходим дерево в глубину с помощью стека в поисках нужного значения, если его нет, возвращаем пустой элемент
            PrintStepStack(stack);
            Console.WriteLine();
            Console.WriteLine($"Сравниваем последний в стеке '{tree.GetRoot().Value}' с искомым '{search_value}', ");
            Console.WriteLine($"Они не равны, поэтому вытаскиваем его и добавляем в стек двух его 'детей': {tree.GetRoot().LeftChild.Value} и {tree.GetRoot().RightChild.Value}");
            Console.WriteLine();
            while (stack.Count != 0)
            {
                int now = stack.Peek().Value;
                res = stack.Pop();
                if (res?.Value == search_value)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Сравниваем первый в стеке '{now}' с искомым '{search_value}', ");
                    Console.WriteLine("Они равны, искомый элемент найден! Возвращаем его значание, прекращаея обход.");
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
                if (i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Сравниваем последний в стеке '{now}' с искомым '{search_value}', ");
                    Console.WriteLine($"Они не равны, поэтому вытаскиваем его и добавляем в стек двух его 'детей' (если они есть): {res.LeftChild?.Value} и {res.RightChild?.Value}.");
                    Console.WriteLine();
                }
                PrintStepStack(stack);
                i++;
            }
            Console.WriteLine("Искомый элемент не найден, поэтому возвращаем пустой элемент");
            return fail;
        }
    }
        
}

