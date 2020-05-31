namespace DataStructure_Algo.node
{
    public class DoubleNode
    {
        public int value;
        public DoubleNode prev;
        public DoubleNode next;

        public int getValue()
        {
           return value;   
        }
        public void setValue(int value)
        {
            this.value = value;
        }
        public DoubleNode getPrev()
        {
           return this.prev;
        }

        public void setPrev(DoubleNode node)
        {
            this.prev = node;
        }

        public DoubleNode getNext()
        {
            return this.next;
        }
        
        public void setNext(DoubleNode node)
        {
            this.next = node;
        }
    }
}