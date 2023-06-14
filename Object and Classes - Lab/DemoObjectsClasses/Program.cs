namespace DemoObjectsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //създаване на обект
            var dog = new
            {
                Cat = "Misho",
                Age = 8,
                Color = "White"

            };
            
            var cat = new Cat();
            
            cat.Name = "Test";

            Console.WriteLine("Hello, World!");
        }
    }
}