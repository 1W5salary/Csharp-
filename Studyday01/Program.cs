using studyday01;
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

            //按进
            for (int i = 1; i <= 9; i++)
            {
                stack.Push("学生");
            }
            stack.Push("侯滔");
            stack.Push("atai");

            //弹出
            for (int i = 1; i <= 11; i++)
            {
                stack.Pop();
            }





            //值类型参数的值传递
            int age = 17;
            grow(age);
            int grow(int age)
            {
                age++;
                return age;
            }
            Console.WriteLine(age);

            //引用参数的值传递
            Student houtao = new Student();
            houtao.age = 24;
            houtao.grow(houtao);
            Console.WriteLine(houtao.age);

            //值类型的引用传递
            Student clone = houtao;
            clone.age = 20;
            Console.WriteLine(houtao.age);

            //引用类型的引用传递
            houtao.refGrow(ref houtao);
            Console.WriteLine(houtao.age);

            //使用return传递参数
            houtao.grade = 99;
            houtao.improve(houtao);
            Console.WriteLine(houtao.grade);








            //测试User类
            User feige = new User();
            feige.UserName = "admin";
            feige.login(feige);

            User houta = new User();
            houta.UserName = "侯滔";
            houta.register();



        }







        

    }
}
