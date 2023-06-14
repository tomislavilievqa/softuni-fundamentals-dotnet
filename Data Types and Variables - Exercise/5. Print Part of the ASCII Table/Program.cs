namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char current = '\0';

            for (int i = start; i <= end; i++)
            {
                current = (char)i;

                System.Console.Write(current + " ");
            }
        }
    }
}