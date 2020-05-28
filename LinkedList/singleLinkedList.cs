using System;
using DataStructure_Algo.node;

namespace DataStructure_Algo
{
    public class singleLinkedList
    {
        private SingleNode head;
        private SingleNode tail;
        private int size;


        public SingleNode createSingleLinkedList(int nodeValue)
        {
            head = new SingleNode();
            SingleNode node = new SingleNode();
            node.setValue(nodeValue);
            node.setNext(null);
            head = node;
            tail = node;
            size = 1;
            return head;
        }

        public SingleNode getHead()
        {
            return head;
        }

        public void setHead(SingleNode node)
        {
            head = node;
        }

        public SingleNode getTail()
        {
            return tail;
        }

        public void setTail(SingleNode node)
        {
            tail = node;
        }

        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public Boolean existsLinkedList()
        {
            return head != null;
        }


        public void insertInLinkedList(int nodeValue, int location)
        {
            SingleNode node = new SingleNode();
            node.setValue(nodeValue);

            if (!existsLinkedList())
            {
                Console.WriteLine("List Doesn't exist...");
                return;
            }
            else if (location == 0)
            {
                node.setNext(head);
                head = node;
            }
            else if (location >= size)
            {
                node.setNext(null);
                tail.setNext(node);
                tail = node;
            }
            else
            {
                SingleNode tempNode = head;
                int index = 0;
                while (index < location - 1)
                {
                    tempNode = tempNode.getNext();
                    index++;
                }

                SingleNode nextNode = tempNode.getNext();
                tempNode.setNext(node);
                node.setNext(nextNode);
            }
            setSize(getSize() + 1);
        }


        public void traverseLinkedList()
        {
            if (existsLinkedList())
            {
                SingleNode tempNode = head;
                for (int i = 0; i < getSize(); i++)
                {
                    Console.Write(tempNode.getValue());
                    if (i != getSize() - 1)
                    {
                        Console.Write("-->");
                    }
                    tempNode = tempNode.getNext();
                }
            }
            else
            {
                Console.WriteLine("Linked list does not exist");
            }

            Console.WriteLine("\n");
        }

        public void DeleteLinkedList()
        {
            Console.WriteLine("Deleting Linked List...");
            head = null;
            tail = null;
            Console.WriteLine("Linked list is deleted successfully");
        }


        public Boolean searchNode(int nodeValue)
        {
            SingleNode tempNode = head;
            for (int i = 0; i < getSize(); i++)
            {
                if (tempNode.getValue() == nodeValue)
                {
                    Console.WriteLine("Found the node at location " + i + "\n");
                    return true;
                }
                tempNode = tempNode.getNext();
            }
            Console.WriteLine("Node not found!");
            return false;
        }

        public void deletionOfNode(int location)
        {
            if (!existsLinkedList())
            {
                Console.WriteLine("LinkedList Doesnot exists");
                return;
            }
            else if (location == 0)
            {
                head = head.getNext();
                setSize(getSize() - 1);
                if (getSize() == 0)
                {
                    tail = null;
                }
            }
            else if (location >= getSize())
            {
                SingleNode tempNode = head;
                for (int i = 0; i < size - 1; i++)
                {
                    tempNode = tempNode.getNext();
                }

                if (tempNode == head)
                {
                    head = tail = null;
                    setSize(getSize() - 1);
                    return;
                }
                tempNode.setNext(null);
                tail = tempNode;
                setSize(getSize() - 1);
            }
            else
            {
                SingleNode tempNode = head;
                for (int i = 0; i < location - 1; i++)
                {
                    tempNode = tempNode.getNext();
                }

                tempNode.setNext(tempNode.getNext().getNext());
                setSize(getSize() - 1);
            }
        }
    }
}