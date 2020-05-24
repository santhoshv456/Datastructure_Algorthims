using System;

namespace DataStructure_Algo
{
    public class singleDimensionArray
    {
         int[] arr = null;
         
          public singleDimensionArray(int sizeOfTheArray)
          {
               arr = new int[sizeOfTheArray];
               for(int i=0; i<sizeOfTheArray; i++)
               {
                   arr[i] = Int32.MinValue;
               }
          }


          public void insert(int location, int value)
          { 
             try
             {   
                if(arr[location]==Int32.MinValue)
                 {
                  arr[location] = value;
                  Console.WriteLine("Successfully inserted "+value+ " at Location "+ location);
                 }
                 else
                 {
                   Console.WriteLine("The Cell is Occupied by another value!");
                 }   
             }
             catch (System.IndexOutOfRangeException e)
             {
                Console.WriteLine("Invalid Index to Access Array!");
                Console.WriteLine(e.Message);
             }
          }

          public void traverseArray()
          {
               try
               {
                  for(int i=0; i<arr.Length; i++)
                  Console.WriteLine(arr[i]);
               }
               catch(Exception ex)
               {
                  Console.WriteLine("Invalid Array...");
                  Console.WriteLine(ex.Message);
               }
          }

          public void accessingCell(int cell)
          {
               try
               {
                   Console.WriteLine(arr[cell]);
               }
               catch(System.IndexOutOfRangeException ex)
               {
                   Console.WriteLine("Index Index to access the Array...");
                   Console.WriteLine(ex.Message);
               }
          }

          public void searchValueInArray(int valueToSearch)
          {
              try
              {
                 for(int i=0; i<arr.Length;i++)
                 {
                     if(arr[i]==valueToSearch)
                     {
                        Console.WriteLine("Value Found!");
                        Console.WriteLine("Index of "+valueToSearch +" is "+ i);
                        return;
                     }
                 }
                 Console.WriteLine("Value is not Found!");
              }
              catch(Exception ex)
              {
                  Console.WriteLine(ex.Message);
              }
          }

          public void deleteValueFromArray(int deleteFromThisCell)
          {
               try
               {
                   arr[deleteFromThisCell] = Int32.MinValue;
               }
               catch(System.IndexOutOfRangeException ex)
               {
                     Console.WriteLine(ex.Message);
               }
          }


          public void deleteArray()
          {
              try
              {
                 arr = null;
              }
              catch(Exception ex)
              {
                 Console.WriteLine(ex.Message);
              }
          }
    }
} 

