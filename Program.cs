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




















        //    Console.WriteLine();
        //    Console.WriteLine("                   Задание №2");
        //    Console.WriteLine();
        //    int[] array = { 2, 4, 5, 7, 9, 11, 15, 18, 23, 29, 32, 33, 36, 39, 40, 42, 44, 59, 89, 90 };
        //    int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //    var testcase1 = new TestCase()
        //    {
        //        input = array,
        //        inputsearch = 4,
        //        expected = 1,
        //        expectedException = null
        //    };
        //    var testcase2 = new TestCase()
        //    {
        //        input = array,
        //        inputsearch = 89,
        //        expected = 18,
        //        expectedException = null
        //    };
        //    var testcase3 = new TestCase()
        //    {
        //        input = array2,
        //        inputsearch = 9,
        //        expected = 8,
        //        expectedException = null
        //    };
        //    var testcase4 = new TestCase()
        //    {
        //        input = array2,
        //        inputsearch = 20,
        //        expected = 19,
        //        expectedException = null
        //    };
        //    var testcase5 = new TestCase()
        //    {
        //        input = array,
        //        inputsearch = -1,
        //        expected = 32,
        //        expectedException = new ArgumentException()
        //};

        //    TestCase.Test(testcase1);
        //    TestCase.Test(testcase2);
        //    TestCase.Test(testcase3);
        //    TestCase.Test(testcase4);
        //    TestCase.Test(testcase5);
        }
    }
        
    }

