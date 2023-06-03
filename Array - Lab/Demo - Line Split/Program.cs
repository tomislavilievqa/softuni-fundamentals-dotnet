using System;

namespace Demo___Line_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            // ivanka,petranka,ivan
            String line = Console.ReadLine();

            //string[] names = line.Split();
            //ako sa sus space
            string[] names = line.Split(",");
            // ako sa sus zapetaika 
            Console.WriteLine(names.Length);
            //names.length - broi broq zaeti mesta v masiva
            //4
            //14141313
            //15315315
            //1353151
            //35151
            for (int index = 0; index < names.Length; index++)
            {
                
                Console.WriteLine(names[index]);
            }
        }
    }
}
