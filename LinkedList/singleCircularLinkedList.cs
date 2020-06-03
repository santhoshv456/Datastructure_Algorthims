using System;
using DataStructure_Algo.node;

namespace DataStructure_Algo.LinkedList
{
    public class singleCircularLinkedList
    {
        public SingleNode head;
        public SingleNode tail;
        public int size;

        public SingleNode getHead()
        {
            return head;
        }

        public void setHead(SingleNode head)
        {
            this.head = head;
        }

        public SingleNode getTail()
        {
            return tail;
        }

        public void setTail(SingleNode tail)
        {
            this.tail = tail;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        { 
            return size;
        }

        public SingleNode createSingleCircularLinkedList(int nodeValue)
        {  
            head = new SingleNode();
            SingleNode node = new SingleNode();
            node.setValue(nodeValue);
            node.setNext(node);
            head=node;
            tail= node;
            size=1;
            return head;
        }

        public Boolean existsLinkedList()
        {
            return head != null;
        }


        public void insertNodeInSingularLinkedList(int location, int value)
        { 
            SingleNode node = new SingleNode();
            node.setValue(value);

            if(!existsLinkedList())
            {
                Console.WriteLine("\nLinked List Doesnt exists");
                return;
            }
            else if(location==0)
            { 
                node.setNext(head);
                head=node;
                tail.setNext(node);
            }
            else if(location >=size)
            {
                tail.setNext(node);
                tail = node;
                tail.setNext(head);
            }
            else
            {
                SingleNode tempNode = head;
                for(int i=0;i<size;i++)
                {
                    tempNode = tempNode.getNext();
                }
                
                node.setNext(tempNode.getNext());
                tempNode.setNext(node);
            }

            size++;
        }


     public void traverseLinkedList()
     {
         if(existsLinkedList())
         {
              SingleNode tempNode = head;
              for(int i=0; i < size; i++)
              {
                  Console.Write(tempNode.getValue());
                  if(i != size-1)
                  {
                      Console.Write("-->");
                  }
                  tempNode = tempNode.getNext();
              }
              Console.WriteLine("\n");
         }
         else
         {
             Console.WriteLine("\nLinked List Doesn't exists");
         }
     }

     public void printHeadUsingTail()
     {
         if(existsLinkedList())
         {

         }

     }

     public void PrintHeadUsingTail()
     {   
         Console.WriteLine("\nPrinting Tail..");
         Console.WriteLine(tail.getValue());

         Console.WriteLine("\nPrinting Head..");
         Console.WriteLine(head.getValue());

         Console.WriteLine("\nPrinting Head Using Tail...");
         Console.WriteLine(tail.getNext().getValue());
     }

     public void deleteLinkedList()
     {
        Console.WriteLine("\nDeleting the LinkedList...");
        head = null;
        if(tail == null)
        {
            Console.WriteLine("\nLinkedList is already deleted..");
            return;
        }
        else
        { 
           tail.setNext(null);
           tail = null;
           Console.WriteLine("\nLinkedList deleted Successfully...");
        }
     }


     public Boolean searchNode(int value)
     {
         SingleNode tempNode = head;
         for(int i=0; i < size; i++)
         {  
             if(tempNode.getValue() == value)
             {
                 Console.WriteLine("\nFound the value at the Location: "+i);
                 return true;
             }
             tempNode = tempNode.getNext();
         }
         Console.WriteLine("\nNot found the value...");
         return false;
     }

     
     public void deleteNode(int location)
     {  
        if(!existsLinkedList())
        {
           Console.WriteLine("\nLinkedList Doesn't exists...");
           return;
        }
        else if(location == 0)
         {
            head = head.getNext();
            tail.setNext(head);
            setSize(getSize()-1);
            if(getSize()==0)
            { 
               tail = null; 
            }
         }
         else if(location >= getSize())
         {
             SingleNode tempNode = head;

             for(int i=0; i< location-1 ; i++)
             {
                 tempNode = tempNode.getNext();   
             }

             if(tempNode == head)
             {
                head = tail = null;
                setSize(getSize()-1);
                return;
             }

            tempNode.setNext(head);
            tail=tempNode;
            setSize(getSize()-1);
         }
         else
         {
             SingleNode tempNode = head;
             
             for(int i=0; i< location-1; i++)
             {
                tempNode = tempNode.getNext();
             }

             tempNode.setNext(tempNode.getNext().getNext());
             setSize(getSize()-1);
         }
     }
    }
}