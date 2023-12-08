using System;

namespace delegate_event_example
{
    class DelegateExample
    {

        public delegate void Operation(int i, int j);

        static void Main(String[] args)
        {
            Operation operation = Add;
            operation += Sub;
            operation += Multiply;

            Console.WriteLine("Enter 2 Num to perform operations: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            operation(num1, num2);

            Console.Write("press any key to exit...");
            Console.ReadKey();
        }

        public static void Add(int i, int j)
        {
            Console.WriteLine("Add: {0}",i + j);
        }

        public static void Sub(int i, int j)
        {
            Console.WriteLine("Sub: {0}", i - j);
        }

        public static void Multiply(int i, int j)
        {
            Console.WriteLine("Multiply: {0}", i * j);
        }
    }
}
