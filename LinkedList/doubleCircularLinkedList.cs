using System;
using DataStructure_Algo.node;

namespace DataStructure_Algo.LinkedList
{
    public class doubleCircularLinkedList
    {
        public DoubleNode head;
        public DoubleNode tail;
        public int size;
        
        public DoubleNode getHead()
        {    
            return head;
        }

        public void setHead(DoubleNode head)
        {
            this.head = head;
        }

        public DoubleNode getTail()
        {
            return this.tail;
        } 

        public void setTail(DoubleNode tail)
        {
            this.tail = tail;
        }

        public int getSize()
        {
            return this.size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public DoubleNode createDoubleLinkedList(int nodeValue)
        {
            head = new DoubleNode();
            DoubleNode node = new DoubleNode();
            node.setValue(nodeValue);
            node.setNext(node);
            node.setPrev(node);
            head = node;
            tail = node;
            size=1;
            return head;
        }
        
        public Boolean existsLinkedList()
        {
           return head != null;
        }

        public void insertDoubleLinkedList(int location, int nodeValue)
        {
            DoubleNode node = new DoubleNode();
            node.setValue(nodeValue);
            
            if(!existsLinkedList())
            {
                Console.WriteLine("\nLinkedList Doesn't exists");
                return;
            }
            else if(location == 0)
            {
                node.setNext(head);
                node.setPrev(tail);
                head.setPrev(node);
                tail.setNext(node);
                head = node;
            }
            else if(location >= size)
            {   
                node.setPrev(tail);
                node.setNext(head);
                head.setPrev(node);
                tail.setNext(node);
                tail = node;
            }
            else
            {
                DoubleNode tempNode = head;
                for(int i=0; i<location-1;i++)
                {
                    tempNode = tempNode.getNext();
                }
                
                node.setPrev(tempNode);
                node.setNext(tempNode.getNext());
                tempNode.getNext().setPrev(node);
                tempNode.setNext(node);
            }

            size++;
        }
       
        public void traverseLinkedList()
        {
            if(existsLinkedList())
            {
                DoubleNode tempNode = head;
                for(int i=0; i< size;i++)
                 {
                    Console.Write(tempNode.getValue());
                    if(i != size-1)
                    {
                      Console.Write("-->");
                    }
                   tempNode = tempNode.getNext();
                 }
            }
            else 
            {
                Console.WriteLine("\nLinked List Doesn't exist");
            }
           Console.WriteLine("\n");
        }

        public void traverseLinkedListFromTail()
        {
            if(existsLinkedList())
            {
                DoubleNode tempNode = tail;
                for(int i=0; i<size; i++)
                {
                    Console.Write(tempNode.getValue());
                    if(i != size-1)
                    {
                        Console.Write("-->");
                    }
                    tempNode = tempNode.getPrev();
                }
            }
            else
             {
                 Console.WriteLine("\nLinked List Doesn't exist");
             }
            
            Console.WriteLine("\n");
        }
    
        public void printHeadUsingTail()
        {
            if(existsLinkedList())
            {
                Console.WriteLine("\nPrinting Tail Value...");
                Console.WriteLine(tail.getValue());

                Console.WriteLine("\nPriniting Head Value...");
                Console.WriteLine(head.getValue());

                Console.WriteLine("\nPrinting Head using Tail Refrence");
                Console.WriteLine(tail.getNext().getValue());
            }
        }

        public void deleteLinkedList()
        {
            if(tail == null)
            {
                Console.WriteLine("\nLinked List alerdy got deleted...");
                return;
            }
            else
            {
                tail.setNext(null);
                head.setPrev(null);
                tail= null;
                head= null;
                Console.WriteLine("\nLinked List got deleted Successfully...");
            }
        }

        public Boolean searchValue(int nodeValue)
        {
            if(existsLinkedList())
            {
                DoubleNode tempNode = head;
                for(int i=0; i<size;i++)
                {
                    if(tempNode.getValue()==nodeValue)
                    {
                       Console.WriteLine("\nFound value at location:"+i);
                       return true;
                    }
                    tempNode = tempNode.getNext();
                }
            }
            Console.WriteLine("\nValue not Found...");
            return false;
        }

       
        public void deleteNodeInLinkedList(int location)
        {
            if(!existsLinkedList())
            {
                Console.WriteLine("\nLinkedList Doesn't Exists...");
                return;
            }
            else if(location==0)
            { 
               if(getSize()==1)
               {  
                   head.setNext(null);
                   head.setPrev(null);
                   head = null;
                   tail = null;
                   setSize(getSize()-1);
                   return;
               }
               else 
               {
                   head = head.getNext();
                   tail.setNext(head);
                   head.setPrev(tail);
                   setSize(getSize()-1);
               } 
            }
            else if(location >= size)
            {
                if(location==1)
                {  
                    head.setNext(null);
                    head.setPrev(null);
                    head = tail = null;
                    setSize(getSize()-1);
                    return;
                }
                tail = tail.getPrev();
                tail.setNext(head);
                head.setPrev(tail);
                setSize(getSize()-1);
            }
            else
            {
                DoubleNode tempNode = head;
                for(int i=0;i<location-1;i++)
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