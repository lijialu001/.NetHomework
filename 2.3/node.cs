namespace _2._3
{
    public class Node<T>
    {
        public Node(T t)
        {
            Next = null;
            Data = t;
        }

        public Node<T> Next { get; set; }
        public T Data { get; set; }
    }
}