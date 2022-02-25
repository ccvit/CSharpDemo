using System;

namespace CSharpDemo
{
    public class CSStudent : Student
    {
        string favoriteLanguage;

        public CSStudent(string n, int s, string f) : base(n, s)
        {
            favoriteLanguage = f;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine("Hello! My name is " + name + ". My studentID is " + studentID.ToString() + ". My favorite language is " + favoriteLanguage + ".");
        }
    }
}