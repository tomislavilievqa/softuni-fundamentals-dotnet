using System;
using System.Linq;
namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] arr1 = new string[input];
            string[] arr2 = new string[input];

            int lines = 0;
    
                for (int i = 0; i < input; i++)
                {
                lines++;
                    string[] current = Console.ReadLine().Split();
                    if (lines % 2 == 0)
                    {
                        arr1[i] = current[0];
                        arr2[i] = current[1];
                    }
                    else if (lines % 2 != 0)
                    {
                        arr2[i] = current[0];
                        arr1[i] = current[1];
                    }


                }

            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", arr1));
           


        }
    }
}
