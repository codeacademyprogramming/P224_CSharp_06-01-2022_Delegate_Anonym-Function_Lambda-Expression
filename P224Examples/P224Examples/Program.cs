using System;
using System.Collections;
using System.Collections.Generic;

namespace P224Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Amil";
            //student.Age = 20;
            //Console.WriteLine(student.Age);

            //Student student1 = student;
            //student1.Name = "P224";
            //student1.Age = 30;

            //Console.WriteLine(student.Age);
            //Console.WriteLine(student1.Age);

            //int a = 20;
            //Console.WriteLine(a);
            //int b = a;
            //b = 30;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //string str1 = "Test";
            //Console.WriteLine(str1);
            //string str2 = str1;
            //str2 = "Hello";
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            //Student<Teacher> student = new Student<Teacher>();







            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ahmet");
            queue.Enqueue("Mehmet");
            queue.Enqueue("Faruk");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Reverse");



            foreach (var item in ReverseQueue(queue))
            {
                Console.WriteLine(item);
            }

        }

        static Queue<string> ReverseQueue(Queue<string> queue)
        {
            Stack<string> stack = new Stack<string>();

            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                stack.Push(queue.Dequeue());
            }

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }

    //class Student<T> where T: Ientity
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //class Ientity
    //{

    //}

    //class Teacher : Ientity
    //{

    //}
}
