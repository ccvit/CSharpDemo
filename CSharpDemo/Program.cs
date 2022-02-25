using System;
namespace CSharpDemo
{

    class Program
    {
        static int Main(string[] args)
        {
            Student student = new Student("Joe", 1234);
            student.PrintGreeting();

            Console.WriteLine("\nWhat is your name?: ");
            string name = Console.ReadLine();

            if (name == "charlie") {
                Console.WriteLine("That's my name too!");
            }

            Console.WriteLine("\nWhat is your SID?: ");
            int studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhat is your Favorite language?: ");
            string favoriteLanguage = Console.ReadLine();

            CSStudent csStudent = new CSStudent(name, studentID, favoriteLanguage);
    
            csStudent.PrintGreeting();

            // this is a combination of lomuto partition and quick select that I 
            // initially made in python for my Algorithms class. Here I am going
            // to translate it to C# as it shows recursion and for loops well.

            // Goal for these algorithms: Find the kth smallest element of an
            // unsorted array without having to sort the entire array.
    
            int[] a = {59, 815, 594, 821, 371, 257, 28, 250, 671, 496};

            int LomutoPartition(int left, int right) {
                int pivot = a[left];
                int split = left;

                for (int i = left; i < right; i++) {
                    if (a[i] < pivot) {

                        split++;
                        int temp = a[split];
                        a[split] = a[i];
                        a[i] = temp;

                    }
                }
                int temp2 = a[split];
                a[split] = a[left];
                a[left] = temp2;
                return split;
            }

            int QuickSelect(int left, int right, int k) {
                int split = LomutoPartition(left, right);

                if (split == k - 1) {
                    return a[split];
                }
                else if (split > k - 1) {
                    return QuickSelect(left, split - 1, k);
                }
                else {
                    return QuickSelect(split + 1, right, k);
                }
            }

            // finding the second smallest number
            Console.WriteLine("kth number: " + QuickSelect(0, a.Length, 5).ToString());

            return 0;
        }
    }
}
