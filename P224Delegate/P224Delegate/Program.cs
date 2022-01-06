using System;

namespace P224Delegate
{
    class Program
    {
        private delegate bool Check(int a);
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 8, 6, 12, 9, 15, 20, 25 };

            Sum(arr, IsOdd);
            Sum(arr, IsEven);
            Sum(arr, IsFive);


            //Check check = new Check(IsFive);
            //Console.WriteLine(check.Invoke(9));

            //check += IsOdd;
            //Console.WriteLine(check.Invoke(9));


            //check += IsEven;

            //Console.WriteLine(check.Invoke(9));

            Student student = new Student
            {
                Name = "Sadiqxan",
                English = 64,
                Russsian = 35,
                Alman = 95
            };
            int a = 35;
            CheckStu<Program, int> checkStu = new CheckStu<Program, int>(CheckCheck);
            //Console.WriteLine(checkStu(student, a));

            //checkStu += CheckRussian;
            //checkStu += CheckCheck;
            //Console.WriteLine(checkStu.Invoke(student,15));

            //checkStu += CheckAlman;
            //Console.WriteLine(checkStu.Invoke(student,-50));

            //Anonym Method
            //checkStu += delegate (Student student1, int a)
            //{
            //    student1.English += a;
            //    if (student1.English > 65)
            //    {
            //        Console.WriteLine("Anonnym Engilis Dilinden Kecdiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Anonnym Paxat nada");
            //    }
            //};

            //checkStu -= delegate (Student student1, int a)
            //{
            //    student1.English += a;
            //    if (student1.English > 65)
            //    {
            //        Console.WriteLine("Anonnym Engilis Dilinden Kecdiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Anonnym Paxat nada");
            //    }
            //};
            //Console.WriteLine(checkStu.Invoke(student, -50));
            //Lambda Expression
            //checkStu += (stu, b) =>
            // {
            //     stu.English += b;
            //     if (stu.English > 65)
            //     {
            //         Console.WriteLine("Lambda Engilis Dilinden Kecdiniz");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Lambda Paxat nada");
            //     }
            // };
            //Console.WriteLine(checkStu.Invoke(student, -50));
            //checkStu -= CheckRussian;
            //checkStu -= CheckEnglish;



            //checkStu(student, -50);
        }

        static int Sum(int[] intArr, Check check)
        {
            int result = 0;

            foreach (int item in intArr)
            {
                if (check(item))
                {
                    result += item;
                }
            }

            return result;
        }

        //static int SumOdd(int[] intArr)
        //{
        //    int result = 0;

        //    foreach (int item in intArr)
        //    {
        //        if (IsOdd(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumEven(int[] intArr)
        //{
        //    int result = 0;

        //    foreach (int item in intArr)
        //    {
        //        if (IsEven(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumFive(int[] intArr)
        //{
        //    int result = 0;

        //    foreach (int item in intArr)
        //    {
        //        if (IsFive(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        static bool IsFive(int num)
        {
            return num % 5 == 0;
        }

        static void CheckEnglish(Student student, int grade=10)
        {
            student.English += grade;
            if (student.English > 65)
            {
                Console.WriteLine("CheckEnglish Engilis Dilinden Kecdiniz");
            }
            else
            {
                Console.WriteLine("CheckEnglish Paxat nada");
            }
        }
        static void CheckRussian(Student student, int grade)
        {
            if (student.Russsian > 65)
            {
                Console.WriteLine("CheckRussian Russsian Dilinden Kecdiniz");
            }
            else
            {
                Console.WriteLine("CheckRussian Paxat nada");
            }
        }
        static void CheckAlman(Student student, int grade)
        {
            if (student.Alman > 65)
            {
                Console.WriteLine("CheckAlman Alman Dilinden Kecdiniz");
            }
            else
            {
                Console.WriteLine("CheckAlman Paxat nada");
            }
        }

        static void CheckCheck(Program student, int grade)
        {
            //if (student.Alman > 65)
            //{
            //    Console.WriteLine("CheckAlman Alman Dilinden Kecdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("CheckAlman Paxat nada");
            //}
        }

    }

    class Student
    {
        public string Name { get; set; }
        public double English { get; set; }
        public double Russsian { get; set; }
        public double Alman { get; set; }
    }

    
    delegate void CheckStu<T, U>(T student, U grade) where T : class;
}
