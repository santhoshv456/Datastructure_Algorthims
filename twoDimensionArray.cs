using System;

namespace  DataStructure_Algo
{
    public class twoDimensionArray
    {

        int[,] arr = null;

        public twoDimensionArray(int rows, int cols)
        {
            arr = new int[rows,cols];
            for(int i =0 ; i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    arr[i,j]= Int32.MinValue;
                }
            }
        }


        public void traverseArray()
        {
            try
            {
                Console.WriteLine("Printing the Array Now!");
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for(int j=0;j<arr.GetLength(1);j++)
                    {
                        Console.WriteLine(arr[i,j]);
                    }
                }
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }


        public void insertTheValueInTheArray(int row, int col, int value)
        {
            try
            {
                 if(arr[row,col]==Int32.MinValue)
                 {
                    arr[row,col] = value;
                    Console.WriteLine("Successfully inserted value "+value+" in the Array");
                    return;
                 }
                 else
                 {
                     Console.WriteLine("The cell is already occupied by another value");
                 }
            }
            catch(System.IndexOutOfRangeException ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

         
        public void accessingTheCell(int row,int col)
        {
            Console.WriteLine("Accessing the Row#"+ row+ ", Col#"+ col+"...");
            try
            {
              Console.WriteLine("Cell value is: "+arr[row,col]);
            }
            catch(System.IndexOutOfRangeException ex)
            {
               Console.WriteLine(ex.Message);
            }
        }


        public void searchingSingleValue(int value)
        {
            Console.WriteLine("Searching for the value#"+ value+" in the array");
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    if(arr[i,j]==value)
                    {
                       Console.WriteLine("Found the value "+value+" at row "+i+" col "+j);
                       return;
                    }
                }
            }

        }

        public void deleteCellValueFromArray(int row, int col)
        {
           Console.WriteLine("Deleting value from row "+row+" column "+col);   
           try
           {
              arr[row,col] = Int32.MinValue;
              Console.WriteLine("Successfully Deleted value from the row# "+row +" col# "+col);
           }
           catch(System.IndexOutOfRangeException ex)
           {
              Console.WriteLine(ex.Message);   
           }
        }

        public void deleteArray()
        {
            arr = null;
            Console.WriteLine("Array has been successfully deleted");
        }
    }
}