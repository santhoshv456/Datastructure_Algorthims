using System;

namespace DataStructure_Algo.BinaryTree
{
    public class BinaryTreeByArray
    {
        int[] arr;
        int lastUsedIndex;

        public BinaryTreeByArray(int size)
        {
            arr = new int[size+1];
            this.lastUsedIndex = 0;
            Console.WriteLine("Blank Tree of Size "+size+" has been created! \n");
        }

        public Boolean isArrayFull()
        {
            if(arr.Length-1 == lastUsedIndex)
            return true;
            else
            return false;
        }

        public void insert(int value)
        {
            if(!isArrayFull())
            {
                arr[lastUsedIndex+1] = value;
                lastUsedIndex++;
                Console.WriteLine("Inserted value "+value+ " in the array");
            }
            else
            {
                Console.WriteLine("Could not insert value in the Tree as it is full..");
            }
        }

        public int search(int value)
        {
            for(int i=0;i<=lastUsedIndex;i++)
            {
                if(arr[i]==value)
                {
                    Console.WriteLine(value+" exists in the Tree!");
                    Console.WriteLine("It is at the location "+i);
                    return i;
                }
            }

            Console.WriteLine(value+ " does not exists in Tree!");
            return -1;
        }


        public void delete(int value)
        {
            int location = search(value);
            if(location == -1){
              return;
            }
            else
            {
                arr[location] = arr[lastUsedIndex];
                lastUsedIndex--;
                Console.WriteLine("Successfully deleted "+value+ " from the Tree !");
            }
        }

        public void preOrderTraversal(int index)
        { 
            if(index>lastUsedIndex)
            {
                return;
            }
           Console.WriteLine(arr[index]+" ");
           preOrderTraversal(index * 2);
           preOrderTraversal(index * 2 + 1);
        }

        public void postOrderTraversal(int index)
        {
             if(index>lastUsedIndex)
             {
                 return;
             }
             postOrderTraversal(index * 2);
             postOrderTraversal(index * 2 + 1);
             Console.WriteLine(arr[index]+" ");
        }

        public void levelOrderTraversal()
        {
            for(int i=1;i<=lastUsedIndex;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }

        public void inOrderTraversal(int index)
        {
            if(index>lastUsedIndex)
            {
                return;
            }
            inOrderTraversal(index * 2);
            Console.WriteLine(arr[index]+ " ");
            inOrderTraversal(index * 2 + 1);
        }

        public void deleteTree()
        {
            try
            {
                 arr= null;
                 Console.WriteLine("Tree has been deleted successfully");
            }
            catch
            {
                Console.WriteLine("There was an error deleting the tree");
            }
        }
    }
}