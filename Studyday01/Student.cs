using System;
using System.Collections.Generic;
using System.Text;

namespace studyday01
{
    public class Person
    {
        internal string name { get; set; }
        internal virtual void greet()
        {
            Console.WriteLine("hell body");
        }

    }
    public class Student : Person
    {
        public int age { get; set; }
        public int grade { get; set; }
        internal string major;
        internal override void greet()
        {
            Console.WriteLine("hell teacher");
        }

        public Student improve(Student student)
        {
            student.grade++;
            return student;
        }

        public void grow(Student student) {
            student.age++;
        }

        public void refGrow(ref Student student)
        {
            student.age++;
        }


    }

    internal class Teacher : Person
    {
        internal string major;
        internal override void greet()
        {
            Console.WriteLine("hell students");
        }

    }
}
