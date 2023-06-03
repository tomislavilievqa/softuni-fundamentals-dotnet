using System;
using System.Text;

namespace Rhombus_of_Stars
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusAsStringDrawer();
            string rhombus = rhombusDrawer.Draw(n);
            Console.WriteLine(rhombus);
            
        }    
    }
}
