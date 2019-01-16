using System;

namespace StackTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Stack creation--------");
            StackTool<int> stackTool = new StackTool<int>();
            Console.WriteLine("------------------------------");

            Console.WriteLine("--------printing empty stack--------");
            stackTool.printStack();
            Console.WriteLine("------------------------------------");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("--------printing 1 value stack (pushed 1)--------");
            stackTool.push(3);
            stackTool.printStack();
            Console.WriteLine("-------------------------------------------------");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("--------printing 5 value stack (pushed 4 more)--------");
            stackTool.push(4);
            stackTool.push(5);
            stackTool.push(6);
            stackTool.push(7);
            stackTool.printStack();
            Console.WriteLine("------------------------------------------------------");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("--------printing 2 value stack (popped 3 more)--------");
            stackTool.pop();
            stackTool.pop();
            stackTool.pop();
            stackTool.printStack();
            Console.WriteLine("------------------------------------------------------");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
