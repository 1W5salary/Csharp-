using System;

namespace Studyday01
{
    class Program
    {
        public static void Main(string[] args)
        {
            //创建一个长度为10的栈，按进11次，弹出11次
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




        }
    }
}
