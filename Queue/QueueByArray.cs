using System;

namespace DataStructure_Algo.Queue
{
    public class QueueByArray
    {
        int[] arr;
        int topOfQueue;
        int beginningOfQueue;

        public QueueByArray(int size)
        {
            arr = new int[size];
            beginningOfQueue =-1;
            topOfQueue=-1;
            Console.WriteLine("Successfully created an empty queue of size: "+size);
        }

        public Boolean isQueueFull()
        {
            if(topOfQueue == arr.Length-1)
            return true;
            else
            return false;
        }

        public Boolean isQueueEmpty()
        { 
            if((beginningOfQueue == -1) || (beginningOfQueue == arr.Length-1))
            return true;
            else
            return false;
        }

        public void enqueue(int value)
        {
            if(isQueueFull())
            {
              Console.WriteLine("Queue Overflow Error!"); 
            }
            else if(isQueueEmpty())
            {
                beginningOfQueue = 0;
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Successfully inserted value:"+value+" in the Queue");
            }
            else 
            {
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Successfully inserted value:"+value+" in the Queue");
            }

            printQueue();
        }

        public void printQueue()
        {
            if(!isQueueEmpty())
            {
                Console.WriteLine("Queue Now...");
                for(int i=beginningOfQueue; i<=topOfQueue;i++)
                {
                    Console.WriteLine(arr[i]+" ");
                }
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Queue is Empty...");
            }
        }

        public void Dequeue()
        {
            if(isQueueEmpty())
            {
                Console.WriteLine("Queue is Empty!..");
            }
            else
            {
                Console.WriteLine("Dequeing value from Queue...");
                Console.WriteLine("Dequed "+arr[beginningOfQueue]+" from Queue");
                beginningOfQueue++;
                if(beginningOfQueue > topOfQueue){
                    beginningOfQueue = topOfQueue = -1;
                }
            }
            printQueue();
            Console.WriteLine();
        }

        public void peekQueue()
        {
            if(!isQueueEmpty())
            Console.WriteLine(arr[beginningOfQueue]);
            else
            Console.WriteLine("The Queue is Empty..");
        }

        public void deleteQueue()
        {
            arr = null;
            Console.WriteLine("Queue is Successfully deletd!..");
        }
  

    }
}