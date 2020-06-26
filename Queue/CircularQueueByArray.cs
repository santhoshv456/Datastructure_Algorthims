using System;

namespace DataStructure_Algo.Queue
{
    public class CircularQueueByArray
    {
        int[] arr;
        int topOfQueue;
        int size;
        int start;

        public CircularQueueByArray(int size)
        {
            arr = new int[size];
            this.size = size;
            this.topOfQueue =-1;
            this.start = -1;
        }
        
        public Boolean isQueueIsFull()
        {
            if(topOfQueue+1 == start)
            {
                return true;
            }
            else if((start == 0) && (topOfQueue+1 == size))
            {
                return true;
            }
            else
            {
               return false;
            }
        }

        public void enque(int value)
        {
            if(arr == null)
            {
                Console.WriteLine("Please Create an Array");
            }
            else if(isQueueIsFull())
            {
                Console.WriteLine("\nQueue overflow error");
            }
            else
            {
                intializeStartOfArray();
                if(topOfQueue+1 == size)
                {
                    topOfQueue=0;
                }
                else 
                {
                    topOfQueue++;
                }

                arr[topOfQueue] = value;

                Console.WriteLine("\nSuccessfully inserted "+value+" in the queue");
            }            
        }

        public void DeQueue()
        {
           if(isQueueEmpty())
           {
               Console.WriteLine("Queue Underflow Error!");
           }
           else
           {
               Console.WriteLine("\n----------------------------");
               Console.WriteLine("Before dequeing"); printArray();
               Console.WriteLine("\nDequeing value for Queue");
               Console.WriteLine("Dequed value: "+arr[start]+" from the array"); 
               arr[start]=0;
               if(start == topOfQueue)
               {
                   start = topOfQueue =-1;
               }
               else if( start+1 == size)
               {
                   start = 0;
               }
               else
               {
                   start++;
               }
           }
        }

        public Boolean isQueueEmpty()
        {
            if(topOfQueue ==-1)
            return true;
            else
            return false;
        }

        public Boolean isQueueFull()
        {
            if(topOfQueue+1 == start)
            {
                return true;
            }
            else if((start==0) && (topOfQueue+1==size))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void printArray()
        {
            Console.WriteLine("Queue Now...");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("\nStart = "+start);
            Console.WriteLine("\nEnd= "+topOfQueue);
        }

        public void intializeStartOfArray()
        {
            if(start==-1)
            start =0;
        }

        public void peek()
        {  
            if(!isQueueEmpty())
            {
                Console.WriteLine("\nPeeking value from queue");
                Console.WriteLine(arr[start]);
            }
            else
            {
                Console.WriteLine("The queue is empty...");
            }
        }
        
        public void deleteQueue()
        {
            Console.WriteLine("\nDeleting the entire Queue");
            arr= null;
            Console.WriteLine("Queue is successfully deleted..");
        }
    }
}