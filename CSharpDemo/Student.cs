using System;

namespace CSharpDemo
{
    public class Student
    {
        public string name;
        public int studentID;

        public virtual void PrintGreeting()
        {
            Console.WriteLine("Hello! My name is " + name + ". My studentID is " + studentID.ToString());
        }

        public Student(string n, int s)
        {
            name = n;
            studentID = s;
        }
    }
}