namespace DataStructure_Algo.node
{
    public class SingleNode
    {
         private int value;
         private SingleNode Next;

         public int getValue()
         {
             return value;
         }

         public void setValue(int value)
         {
             this.value = value;
         }

         public SingleNode getNext()
         {
             return Next;
         }

         
         public void setNext(SingleNode next)
         {
            this.Next = next;
         }
    }
}