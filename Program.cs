using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HomeWorkGB
{
    
    class Program
    {
        public interface IGraph
        {
            void AddItem(int value); // добавить вершину
            void RemoveItem(int value); // удалить вершину по значению
            Node GetNodeByValue(int value); //получить вершину графа по значению
            //void PrintTree(Graph graph, int depth); //вывести граф в консоль
        }
        public class Node
        {
            public int Value { get; set; }
            public List <Edge> Edges { get; set; }
        }
        public class Edge
        {
            public int Weight { get; set; }
            public Node Node { get; set; }
        }
        public class Graph : IGraph
        {
            public Node root;
            public void AddItem(int value)
            {
                throw new NotImplementedException();
            }

            public Node GetNodeByValue(int value)
            {
                throw new NotImplementedException();
            }

            public void RemoveItem(int value)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            var edgeAB = new Edge























            //int N = 5;
            //int[,] W = new int[N, N]; // Весовая матрица
            //Load(W);
            //Write(W);
            //int[] active = new int[N]; // Состояния вершин (просмотрена или не просмотрена)
            //int[] route = new int[N];
            //int[] peak = new int[N];
            //int i;
            //int j;
            //int min;
            //int kMin = 0;

            //for (i = 0; i < N; i++)
            //{
            //    active[i] = 1;
            //    route[i] = W[0, i];
            //    peak[i] = 0;
            //}

            //// Сразу помечаем, что вершина A(0) просмотрена,
            //// с неё начинается маршрут
            //active[0] = 0;

            //for (i = 0; i < N - 1; i++)
            //{
            //    // Среди активных вершин
            //    // ищем вершину с минимальным соответствующим значением в массиве R
            //    // и проверяем, не лучше ли ехать через неё:
            //    min = int.MaxValue;
            //    for (j = 0; j < N; j++)
            //        if (active[j] == 1 && route[j] < min)
            //        {
            //            min = route[j]; // Минимальный маршрут
            //            kMin = j; // Номер вершины с минимальным маршрутом
            //        }

            //    active[kMin] = 0; // Просмотрели эту точку
            //                      // Проверка маршрута через вершину kMin
            //                      // Есть ли более короткий путь
            //    for (j = 0; j < N; j++)
            //        // Если текущий путь в вершину J (R[j]
            //        // больше, чем путь из найденной вершины (R[kMin] +
            //        // путь из этой вершины W[kMin][j], то
            //        if (route[j] > route[kMin] + W[j, kMin] &&
            //            W[j, kMin] != int.MaxValue && active[j] == 1)
            //        {
            //            // мы запоминаем новое расстояние
            //            route[j] = route[kMin] + W[j, kMin];
            //            // и запоминаем, что можем добраться туда более
            //            // коротким путём в массиве P
            //            peak[j] = kMin;
            //        }
            //}
            //foreach (var item in peak)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //foreach (var item in route)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //while (i != 0)
            //{
            //    Console.Write($"{i} ");
            //    i = peak[i];
            //}


























            //var tree = new Tree(20);
            //for (int i = 0; i < 15; i++)
            //{
            //    tree.AddItem(i * 5);
            //}
        }
        static void Load(int[,] mas)
        {
            int n = 0;//Int32.MaxValue;
            mas[0, 0] = n;
            mas[0, 1] = 2;
            mas[0, 2] = 5;
            mas[0, 3] = n;
            mas[0, 4] = 7;
            mas[1, 0] = 2;
            mas[1, 1] = n;
            mas[1, 2] = 1;
            mas[1, 3] = n;
            mas[1, 4] = n;
            mas[2, 0] = 5;
            mas[2, 1] = 1;
            mas[2, 2] = n;
            mas[2, 3] = 5;
            mas[2, 4] = 1;
            mas[3, 0] = n;
            mas[3, 1] = n;
            mas[3, 2] = 5;
            mas[3, 3] = n;
            mas[3, 4] = 3;
            mas[4, 0] = 7;
            mas[4, 1] = n;
            mas[4, 2] = 1;
            mas[4, 3] = 3;
            mas[4, 4] = n;
        }
        static void Write(int[,] mas)
        {
            Console.WriteLine();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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

