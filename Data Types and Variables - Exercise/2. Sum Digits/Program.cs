
namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string num = number.ToString();
            int lenght = num.Length;
            
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += number % 10;
                number /= 10;
            }

            
            System.Console.WriteLine(sum);
        }
    }
}