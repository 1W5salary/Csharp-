using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01
{
    class Stack
    {

        public String[] num { get; set; }


        //按进
        public String[] Push(string s)
        {
            if (num[num.Length - 1] != null) {
                Console.WriteLine("栈满了，挤不进去了");
            }
            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] == null)
                {
                    num[i] = s;

                    Console.WriteLine(s + "入栈了");

                    break;

                }

            }

            Output(num);
            return num;
        }

        //弹出
        public String[] Pop()
        {
            if (num[0] == null)
            {
                Console.WriteLine("栈空了，弹不出去了");
            }
            else
            {
                for (int i = (num.Length-1); i >= 0; i--)
                {
                    if (num[i] != null)
                    {
                        num[i] = null;
                        Console.WriteLine("弹出去了一个");
                        break;
                    }


                }
            
            }
            Output(num);
            return num;
        }

        //输出
        public void Output(String[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != null)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}

public class OutputStack
{

}
