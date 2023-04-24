namespace TALab3.Data
{
    public class LinkedList <T>
    {
        public T[] list;
        public int length { get { return list.Length; } }

        public LinkedList() 
        {
            list = new T[0];
        }

        public static void Add(LinkedList<T> linkedList, T node)
        {
            LinkedList<T>.AddAt(linkedList, node, linkedList.length);
        }

        public static void AddAt(LinkedList<T> linkedList, T item, int index)
        {
            if (index < 0 || index > linkedList.length)
            {
                throw new ArgumentOutOfRangeException("You can`t remove more elements!");
            }
            T[] list = new T[linkedList.length + 1];
            int i = 0;
            for (; i < index; i++)
            {
                list[i] = linkedList.list[i];
            }
            list[i] = item;
            for (; i < linkedList.length; i++)
            {
                list[i + 1] = linkedList.list[i];
            }
            linkedList.list = list;
        }

        public static void Remove(LinkedList<T> linkedList)
        {
            LinkedList<T>.RemoveAt(linkedList, linkedList.length-1);
        }

        public static void RemoveAt(LinkedList<T> linkedList, int index)
        {
            if (index > linkedList.length || index < 0)
            {
                throw new ArgumentOutOfRangeException("You can`t remove this element!");
            }
            T[] list = new T[linkedList.length-1];
            int i = 0;
            for (; i < index; i++)
            {
                list[i] = linkedList.list[i];
            }
            i++;
            for (; i < linkedList.length; i++)
            {
                list[i - 1] = linkedList.list[i];
            }
            linkedList.list = list;
        }
        public static void Clear(LinkedList<T> linkedList)
        {
            linkedList.list = new T[0];
        }
    }
    public class LinkedListNode: LinkedList<Node> {}
    public class LinkedListString : LinkedList<string> { }
}

