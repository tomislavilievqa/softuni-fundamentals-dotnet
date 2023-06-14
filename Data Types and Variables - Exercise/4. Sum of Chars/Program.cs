namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                char current = char.Parse(Console.ReadLine());
                result += current;
               
            }
            
            System.Console.WriteLine("The sum equals: {0}", result);
        }
    }
}