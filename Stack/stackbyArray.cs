using System;

namespace DataStructure_Algo.Stack
{
    public class stackbyArray
    {
        int[] arr;
        int topOfStack;

        public stackbyArray(int size)
        {
            arr = new int[size];
            topOfStack = -1;
            Console.WriteLine("Creted an Empty stack of size:"+size);
        }
        public Boolean isStackIsEmpty()
        {
             if(topOfStack==-1)
             return true;
             else
             return false;
        }

        public Boolean isStackIsFull()
        {
            if(topOfStack == arr.Length-1)
            return true;
            else
            return false;
        }

        public void push(int value)
        {
            if(isStackIsFull())
            {
               Console.WriteLine("\n Stack OverFlow Error!!");
               return;
            }
            else
            {
                arr[topOfStack+1] = value;
                topOfStack++;
                Console.WriteLine("Successfully inserted " +value+" in the Stack");
            }
        }
         
        public void pop()
        {
            if(isStackIsEmpty())
            {
                Console.WriteLine("\nStack Underflow error!!");
                return;
            }
            else
            {
                Console.WriteLine("\nPoping value from stack:"+ arr[topOfStack]+"...");
                topOfStack--;
            }
        }

        public void peek()
        {
            if(isStackIsEmpty())
            {
                Console.WriteLine("\nStack is empty");
                return;
            }
            else
            {
                Console.WriteLine("\nPeeking value from stack:"+ arr[topOfStack]+"...");
            }
        }

        public void deleteStack()
        {
            arr = null;
            Console.WriteLine("\nStack is deleted Successfully");
        }
    }
}