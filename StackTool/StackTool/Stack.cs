using System;
using System.Collections;
using System.Collections.Generic;

namespace StackTool
{
    class StackTool<T>
    {
        private ArrayList stack;

        public StackTool()
        {
            stack = new ArrayList();
            Console.WriteLine("Stack created !!!");
        }

        public object push(object element)
        {
            stack.Add(element);
            return element;
        }

        public object pop()
        {
            object item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count-1);
            return item;
        }

        public void printStack()
        {
            if(stack.Count != 0)
            {
                ArrayList stackList = stack;
                stackList.Reverse();
                foreach (T item in stackList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("!!! empty stack !!!");
            }
        }
    }
}
