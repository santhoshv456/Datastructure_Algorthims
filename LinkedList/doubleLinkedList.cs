using System;
using DataStructure_Algo.node;

namespace DataStructure_Algo.LinkedList
{
    public class doubleLinkedList
    {
         public int size;

         public DoubleNode head;

         public DoubleNode tail;
        
        public void setSize(int size)
        {
           this.size = size;
        }

        public int getSize()
        {
            return this.size;
        }

         public DoubleNode createDoubleLinkedList(int value)
         {
             head = new DoubleNode();
             DoubleNode node = new DoubleNode();
             node.setValue(value);
             node.setNext(null);
             node.setPrev(null);
             head = node;
             tail = node;
             size = 1;
             return head;
         }

        public Boolean existLinkedList()
        {
            return head!=null;
        } 

        
        public void insertLinkedList(int nodeValue,int location)
        {
            DoubleNode node = new DoubleNode();
            node.setValue(nodeValue);

            if(!existLinkedList())
            {
                Console.WriteLine("LinkedList Doesnot Exists...");
                return;
            }

            else if(location == 0)
            { 
                node.setNext(head);
                node.setPrev(null);
                head.setPrev(node);
                head = node;
            } 
            else if(location >= size)
            {
                node.setNext(null);
                tail.setNext(node);
                node.setPrev(tail);
                tail = node;
            }
            else
            {    
                DoubleNode tempNode = head;

                 for(int i=0;i<=location-1;i++)
                 {
                     tempNode = tempNode.getNext();
                 }
                 
                 node.setPrev(tempNode);
                 node.setNext(tempNode.getNext());
                 tempNode.setNext(node);
                 node.getNext().setPrev(node);
            }
            size++;
        }

        public void traverseLinkedList()
        {
              if(existLinkedList())
              {
                  DoubleNode tempNode = head;
                  for(int i=0; i< size; i++)
                  {   
                      Console.Write(tempNode.getValue());
                      if(i != size-1)
                      {
                          Console.Write("-->");
                      }
                      tempNode = tempNode.getNext();
                  }

              }
              else {
                  Console.WriteLine("LinkedList Doesn't Exists...");
              }

              Console.WriteLine("\n");
        }

        public void traverseLinkedListInReverseOrder()
        {
            if(existLinkedList())
            {
                DoubleNode tempNode = tail;
                for(int i=0; i<size ; i++)
                {
                    Console.Write(tempNode.getValue());
                    if(i != size-1)
                    {
                      Console.Write("<--");
                    }
                    tempNode = tempNode.getPrev();
                }
            }
            else
            {
               Console.WriteLine("LinkedList Doesn't Exists...");
            }

            Console.WriteLine("\n");
        }

        public void deleteLinkedList()
        {
            Console.WriteLine("\n\nDeleting the LinkedList...");

            DoubleNode tempNode = head;

            for(int i=0; i< size;i++)
            { 
                tempNode.setPrev(null);
                tempNode = tempNode.getNext();
            }

            head = null;
            tail = null;

            Console.WriteLine("Deleted the LinkedList Successfully..");
        }

        public Boolean searchNode(int nodeValue)
        {
            if(existLinkedList())
            {
                DoubleNode tempNode = head;
                for(int i = 0 ; i< size; i++)
                {
                    if(tempNode.getValue() == nodeValue)
                    {
                        Console.WriteLine("Node value found at location: "+ i);
                        return true;
                    }

                    tempNode = tempNode.getNext();
                }
            }
            Console.WriteLine("Node not Found...");
            return false;
        }

        public void deleteNodeInLinkedList(int location)
        {
            if(!existLinkedList())
            {
                Console.WriteLine("LinkedList Doesn't exists...");
                return;
            }
            else if(location == 0)
            {
                if(getSize() == 1)
                { 
                    head = tail = null;
                    setSize(getSize()-1);
                    return;
                }
                else
                {
                    head = head.getNext();
                    head.setPrev(null);
                    setSize(getSize()-1);
                }
            }
            else if(location >= getSize())
            {  
                DoubleNode tempNode = tail.getPrev();
                if(tempNode == head)
                {
                    tail = head = null;
                    setSize(getSize()-1);
                    return;
                }

                tempNode.setNext(null); 
                tail = tempNode;
                setSize(getSize()-1);
            }
            else
            {
                DoubleNode tempNode = head;
                for(int i=0; i<location-1;i++)
                {
                    tempNode = tempNode.getNext();
                }
                
                tempNode.setNext(tempNode.getNext().getNext());
                tempNode.getNext().setPrev(tempNode);
                setSize(getSize()-1);
            }
        }
    } 
}