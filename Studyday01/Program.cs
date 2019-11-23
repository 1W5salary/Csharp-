using studyday01;
using System;

namespace Studyday01
{
    class Program
    {
        public static void Main(string[] args)
        {











            //调用仓库类
            Repoistory repoistory = new Repoistory("192.168.1.1");










            //调用栈
            Stack container = new Stack(10);
            container.Push("德玛西亚","诺克萨斯", "德玛西亚", "诺克萨斯","德玛西亚","诺克萨斯","德玛西亚", "诺克萨斯", "德玛西亚", "诺克萨斯");
            for (int i = 1; i <= 11; i++) {
                container.Pop();
            }
            container.OutputStack();





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
