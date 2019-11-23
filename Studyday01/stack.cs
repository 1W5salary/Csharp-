using System;
using System.Collections.Generic;
using System.Text;

namespace Studyday01

{
    class Stack
    {
        private int _top;
        private string[] _container;
        public Stack(int length)
        {
            _top = 0;
            _container = new string[length];
        }

        //按进
        public void Push(params string[] element)
        {
            for (int i = 0; i < element.Length; i++)
            {
                if (_top >= element.Length)
                {
                    Console.WriteLine("栈满了，挤不进去了");
                    return;
                }
                else {
                    _container[_top] = element[i];
                    _top++; 
                }
                
            }
            return;
        }

        //弹出
        public string Pop()
        {
            if (_top <= 0)
            {
                Console.WriteLine("栈空了，弹不出去了");
                return "";
            }
            //else { }
            _top--;
            string temp = _container[_top];
            _container[_top] = null;
            return temp;
        }

        public void OutputStack() {
            for (int i = 0; i <= _container.Length - 1; i++)
            {
                Console.WriteLine(_container[i]);
            }
        
        }
    }

}


