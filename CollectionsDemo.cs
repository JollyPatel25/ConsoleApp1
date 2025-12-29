using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CollectionsDemo
    {
        Stack<int> stack = new Stack<int>();
        Dictionary<int, string> dict = new Dictionary<int, string>();
        List<string> list = new List<string>();
        HashSet<int> set = new HashSet<int>();
        LinkedList<string> linkedList = new LinkedList<string>();
        SortedList<int, string> sl = new SortedList<int, string>();
        Queue<int> queue = new Queue<int>();
        ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
        ConcurrentDictionary<String, int> marks = new ConcurrentDictionary<string, int>();

        public void Start()
        {
            //marks.TryAdd("Jolly", 25);
            //marks.TryAdd("Purva", 2);
            //marks.TryAdd("Nandani", 10);
            //marks.TryAdd("Pranali", 12);
            //foreach (var item in marks)
            //{
            //    Console.WriteLine($"Marks Of {item.Key} Are {item.Value}");
            //}
            //if (marks.TryRemove("Pranali", out int result3)){
            //    Console.WriteLine($"\nRemoved Element Is {result3}\n");
            //}
            //foreach (var item in marks)
            //{
            //    Console.WriteLine($"Marks Of {item.Key} Are {item.Value}");
            //}
            //Console.WriteLine("\nKeys Are: ");
            //foreach(var item in marks.Keys)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine("\nValues Are: ");
            //foreach(var item in marks.Values)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Concurrent Stack
            //concurrentStack.Push(21);
            //concurrentStack.Push(24);
            //if(concurrentStack.TryPop(out int result1)){
            //    Console.WriteLine($"Element Popped Is {result1}!");
            //}
            //if(concurrentStack.TryPeek(out int result2))
            //{
            //    Console.WriteLine($"Element Peeked Is {result2}");
            //}
            //Console.WriteLine("Stack Elements: ");
            //foreach(var item in concurrentStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue
            //queue.Enqueue(25);
            //queue.Enqueue(21);
            //queue.Enqueue(20);
            //queue.Enqueue(24);
            //Console.WriteLine("Before: ");
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("After: ");
            //queue.Dequeue();
            //queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList
            sl.Add(4, "Jolly");
            sl.Add(1, "Purvika");
            sl.Add(2, "Nandani");
            sl.Add(3, "Pranali");
            foreach (var s in sl)
            {
                Console.WriteLine($"Key: {s.Key} Value: {s.Value}");
            }

            //LinkedList
            //linkedList.Clear();
            //linkedList.AddFirst("y");
            //linkedList.AddFirst("a");
            //linkedList.AddAfter(linkedList.Find("a"), "b");
            //linkedList.AddLast("z");
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //linkedList.RemoveLast();
            //linkedList.RemoveLast();
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet
            //set.Add(5);
            //set.Add(6);
            //set.Add(4);
            //set.Add(5);
            //set.Remove(6);
            //foreach(int i in set)
            //{
            //    Console.WriteLine(i);
            //}


            //List
            //list.Add("Jolly Patel");
            //list.Add("Pranali Khare");
            //list.Add("Purva Bhavsar");
            //Console.WriteLine($"Count: {list.Count}");
            //list.Insert(2, "Nandani Jani");
            //list.Remove("Pranali Khare");
            //Console.WriteLine($"Contains: {list.Contains("Jolly Patel")}");
            //foreach(string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary
            //dict.Add(7002, "Purva");
            //dict.Add(7021, "Jolly");
            //dict[7002] = "Purva Bhavsar";
            //dict[7021] = "Jolly Patel";
            //foreach (var d in dict)
            //{
            //    Console.WriteLine($"Key: {d.Key} Value: {d.Value}");
            //}

            //stack
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //foreach (object x in stack)
            //{
            //    Console.WriteLine(x);
            //}
        }

    }
}
