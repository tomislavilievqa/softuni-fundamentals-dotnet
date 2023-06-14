namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int peopleNum = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)peopleNum/ capacity;
            System.Console.WriteLine(Math.Ceiling(courses));
        
       

            
            
            
           
     
           
        }
    }
}