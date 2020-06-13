using System;

namespace DataStructure_Algo.Stack
{
    public class stackByLinkedList
    {
         singleLinkedList list;

         public stackByLinkedList()
         {
             list = new singleLinkedList();
         }

         public void push(int value)
         {
             if(list.getHead()== null)
             {
                 list.createSingleLinkedList(value);
             }
             else
             {
                 list.insertInLinkedList(value,0);
             }

            Console.WriteLine("Inserted "+value+" in stack!");
         }

          
        public int pop()
        { 
            int value = -1;

            if(isStackEmpty())
            {
                Console.WriteLine("Stack underflow error!");
            }
            else
            {
                value = list.getHead().getValue();
                list.deletionOfNode(0);
            }
            return value;
        }

        public int peek()
        {
            int value =-1;

            if(isStackEmpty())
            {
                Console.WriteLine("Stack underflow error!");
            }
            else
            {
               value = list.getHead().getValue();
            }
            return value;
        }

        public void deleteStack()
        {
            list.setHead(null);
        }

         public Boolean isStackEmpty()
         {
             if(list.getHead() == null )
             return true;
             else 
             return false;
         }
        

    }
}