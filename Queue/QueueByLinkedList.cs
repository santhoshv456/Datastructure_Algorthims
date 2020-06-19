using System;

namespace DataStructure_Algo.Queue
{
    public class QueueByLinkedList
    { 
         singleLinkedList list;

        public QueueByLinkedList()
        {
            list = new singleLinkedList();
        }
        
        public void enque(int value)
        {
            if(list.getHead()==null)
            {
                list.createSingleLinkedList(value);
            }
            else
            {
                list.insertInLinkedList(value,list.getSize());
            }
        }

        public Boolean isQueueEmpty()
        {
            if(list.getHead()==null)
            {
                return true;
            }
            else
            {
                 return false;
            }
        }

        public int dequeue()
        {
            int value=-1;
            if(isQueueEmpty())
            {
               Console.WriteLine("Queue underflow error!");
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
            if(!isQueueEmpty())
            {
                return list.getHead().getValue();
            }
            else
            {
                Console.WriteLine("Queue Underflow error!");
                return -1;
            }
        }

        public void deleteQueue()
        {
            list.setHead(null);
        }
    }
}