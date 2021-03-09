using System;

namespace MDT112_HW3_Conditional_Statement_63120501002
{
    class Program
    {
        static void Main(string[] args)
        {
            string ModeProgram = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (ModeProgram = "time")
            {
                Console.WriteLine();
            }
            if (ModeProgram = "price")
            {
                Console.WriteLine();
            }
            else (ModeProgram = "")
            {
                Console.WriteLine("Invalid mode");
            }

            if (x < 1)
            {
                Console.WriteLine();
            }
            else if(y > 1)
            {
                Console.WriteLine("lnvalid mouse position");
            }

            Console.ReadLine();
             
        }
    }
}
