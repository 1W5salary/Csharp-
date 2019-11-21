using System;

namespace Studyday01
{
    class Program
    {
        public static void Main(string[] args)
        {
            //栈的按进与弹出
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
            //继承与多态
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
