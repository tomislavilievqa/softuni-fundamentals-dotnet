using System;
using System.Linq;
namespace _4._Array_Rotation
{
    class Program
    {
        public static object GFG { get; private set; }

        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotationsCount = int.Parse(Console.ReadLine());

            int track = 0;
            
            while (rotationsCount > track)
            {
                string last = arr[0]; //1
                for (int index = 0; index < arr.Length-1; index++) // 4
                {
                    arr[index] = arr[index + 1];
                    
                }
                arr[arr.Length-1] = last;
                track++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            

        }
    }
}
