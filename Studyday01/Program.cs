using System;

namespace Studyday01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.num = new string[10];

            for (int i = 1; i <= 9;i++)
            {
                stack.Push("学生");
            }
            stack.Push("侯滔");
            stack.Push("atai");

            for (int i = 1; i <= 11; i++)
            {
                stack.Pop();
            }




            //集成与多态
            //Person a = new Person();
            //a.Greet();
            //Console.WriteLine("-----------------------------------");
            //Student b = new Student();
            //b.Greet();
            //Console.WriteLine("-----------------------------------");
            //Person ht = new Student();
            //ht.Greet();
            //Console.WriteLine("-----------------------------------");

        }

    }

}
