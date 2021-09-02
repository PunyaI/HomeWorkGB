using System;


namespace HomeWorkGB
{
    class Program
    {
        public interface ILinkedList
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // ищет элемент по его значению
        }

        static void Main(string[] args)
        {
            Case1_DoubleNodeList();

            Console.WriteLine();
            Console.WriteLine("                   Задание №2");
            Console.WriteLine();
            int[] array = { 2, 4, 5, 7, 9, 11, 15, 18, 23, 29, 32, 33, 36, 39, 40, 42, 44, 59, 89, 90 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var testcase1 = new TestCase()
            {
                input = array,
                inputsearch = 4,
                expected = 1,
                expectedException = null
            };
            var testcase2 = new TestCase()
            {
                input = array,
                inputsearch = 89,
                expected = 18,
                expectedException = null
            };
            var testcase3 = new TestCase()
            {
                input = array2,
                inputsearch = 9,
                expected = 8,
                expectedException = null
            };
            var testcase4 = new TestCase()
            {
                input = array2,
                inputsearch = 20,
                expected = 19,
                expectedException = null
            };
            var testcase5 = new TestCase()
            {
                input = array,
                inputsearch = -1,
                expected = 32,
                expectedException = new ArgumentException()
        };

            TestCase.Test(testcase1);
            TestCase.Test(testcase2);
            TestCase.Test(testcase3);
            TestCase.Test(testcase4);
            TestCase.Test(testcase5);
        }


        public static int BinarySearch(int[] array, int search_value)
        {
            if (search_value == -1)
            {
                throw new ArgumentException("Ошибка, некорректное значение");
            }
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (search_value == array[mid])
                {
                    return mid;
                }
                else if (search_value < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        static void Case1_DoubleNodeList()
        {
            Console.WriteLine("                   Задание №1");
            Console.WriteLine();
            NodeList nodelist = new NodeList();
            Console.WriteLine("Добавляем в список элементы со значениями 2, 4, 6, 10");
            nodelist.AddNode(2);
            nodelist.AddNode(4);
            nodelist.AddNode(6);
            nodelist.AddNode(10);
            Console.WriteLine("Элементы двусвязного списка:");
            foreach (var item in nodelist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"В списке {nodelist.GetCount()} элементов(а).");
            Console.WriteLine("Добавляем запись, находящуюся после записи со значением 6");
            nodelist.AddNodeAfter(nodelist.FindNode(6), 8);
            foreach (var item in nodelist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Удаляем запись с индексом 3");
            nodelist.RemoveNode(3);
            foreach (var item in nodelist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Удаляем запись со значением 4 (найденную с помощью поиска)");
            nodelist.RemoveNode(nodelist.FindNode(4));
            foreach (var item in nodelist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
        
    }

