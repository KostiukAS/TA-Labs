namespace TALab3.Data
{
    public class LinkedList
    {
        public Node[] list;
        public string[] listString;
        public int numberOfElements { get; private set; }
        public int strNumberOfElements { get; private set; }

        public LinkedList() 
        { 
            list = new Node[100];
            listString = new string[100];
            numberOfElements = 0;
            strNumberOfElements = 0;
        }

        public static void Add(LinkedList linkedList, Node node)
        {
            if (linkedList.numberOfElements == 100)
            {
                throw new ArgumentOutOfRangeException("You can`t add more elements!");
            }
            else
            {
                linkedList.list[linkedList.numberOfElements] = node;
                linkedList.numberOfElements++;
            }
        }

        public static void AddAt(LinkedList linkedList, Node node, int index)
        {
            if (index > linkedList.numberOfElements || index < 0)
            {
                throw new ArgumentOutOfRangeException("You can`t add element here!");
            }
            else if (index == linkedList.numberOfElements)
            {
                LinkedList.Add(linkedList, node);
            }
            else
            {
                Node axNode = linkedList.list[index];  
                int iter = index;

                do
                {
                    linkedList.list[iter] = node;
                    node = linkedList.list[iter + 1];
                    linkedList.list[iter + 1] = axNode;
                    axNode = linkedList.list[iter + 2];
                    iter += 2;
                } while (iter < linkedList.numberOfElements);

                if (iter == linkedList.numberOfElements)
                {
                    linkedList.list[iter] = node;
                }
                linkedList.numberOfElements++;

            }
        }

        public static void RemoveLast(LinkedList linkedList)
        {
            if (linkedList.numberOfElements == 0)
            {
                throw new ArgumentOutOfRangeException("You can`t remove more elements!");
            }
            else
            {
                linkedList.list[linkedList.numberOfElements - 1] = null;
                linkedList.numberOfElements--;
            }
        }

        public static void RemoveAt(LinkedList linkedList, int index)
        {
            if (index >= linkedList.numberOfElements || index < 0)
            {
                throw new ArgumentOutOfRangeException("You can`t remove this element!");
            }
            else if (index == (linkedList.numberOfElements - 1))
            {
                LinkedList.RemoveLast(linkedList);
            }
            else
            {
                Node axNode = linkedList.list[index + 1];
                int iter = index;

                while (iter < linkedList.numberOfElements - 1)
                {
                    linkedList.list[iter] = axNode;
                    axNode = linkedList.list[iter + 2];
                    iter++;
                }

                linkedList.list[linkedList.numberOfElements - 1] = null;
                linkedList.numberOfElements--;
            }
        }

        public static void Clear(LinkedList linkedList)
        {
            for (int i = 0; i < linkedList.numberOfElements; i++)
            {
                linkedList.list[i] = null;
            }
            linkedList.numberOfElements = 0;
        }

        public static void StrAdd(LinkedList linkedList, string str)
        {
            if (linkedList.strNumberOfElements == 100)
            {
                throw new ArgumentOutOfRangeException("You can`t add more elements!");
            }
            else
            {
                linkedList.listString[linkedList.strNumberOfElements] = str;
                linkedList.strNumberOfElements++;
            }
        }

        public static void StrAddAt(LinkedList linkedList, string str, int index)
        {
            if (index > linkedList.strNumberOfElements || index < 0)
            {
                throw new ArgumentOutOfRangeException("You can`t add element here!");
            }
            else if (index == linkedList.strNumberOfElements)
            {
                LinkedList.StrAdd(linkedList, str);
            }
            else
            {
                string axString = linkedList.listString[index];
                int iter = index;

                do
                {
                    linkedList.listString[iter] = str;
                    str = linkedList.listString[iter + 1];
                    linkedList.listString[iter + 1] = axString;
                    axString = linkedList.listString[iter + 2];
                    iter += 2;
                } while (iter < linkedList.strNumberOfElements);

                if (iter == linkedList.strNumberOfElements)
                {
                    linkedList.listString[iter] = str;
                }
                linkedList.strNumberOfElements++;

            }
        }

        public static void StrRemoveLast(LinkedList linkedList)
        {
            if (linkedList.strNumberOfElements == 0)
            {
                throw new ArgumentOutOfRangeException("You can`t remove more elements!");
            }
            else
            {
                linkedList.listString[linkedList.strNumberOfElements - 1] = null;
                linkedList.strNumberOfElements--;
            }
        }

        public static void StrRemoveAt(LinkedList linkedList, int index)
        {
            if (index >= linkedList.strNumberOfElements || index < 0)
            {
                throw new ArgumentOutOfRangeException("You can`t remove this element!");
            }
            else if (index == (linkedList.strNumberOfElements - 1))
            {
                LinkedList.StrRemoveLast(linkedList);
            }
            else
            {
                string axString = linkedList.listString[index + 1];
                int iter = index;

                while (iter < linkedList.strNumberOfElements - 1)
                {
                    linkedList.listString[iter] = axString;
                    axString = linkedList.listString[iter + 2];
                    iter++;
                }

                linkedList.listString[linkedList.strNumberOfElements - 1] = null;
                linkedList.strNumberOfElements--;
            }
        }

        public static void StrClear(LinkedList linkedList)
        {
            for (int i = 0; i < linkedList.strNumberOfElements; i++)
            {
                linkedList.listString[i] = null;
            }
            linkedList.strNumberOfElements = 0;
        }
    }
}
