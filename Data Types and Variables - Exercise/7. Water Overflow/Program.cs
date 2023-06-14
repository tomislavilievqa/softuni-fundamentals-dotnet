namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());
           
            int capacity = 0;
            int overflow = 0;
            
            for (int i = 1; i <= numberOfLines; i++)
            {
               int liters = int.Parse(Console.ReadLine());

                if (capacity+liters < 255)
                {
                    capacity += liters;
                }
                else {
                    Console.WriteLine("Insufficient capacity!");
                
                }
               

            }
            System.Console.WriteLine(capacity);

           






        }
    }
}