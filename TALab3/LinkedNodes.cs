namespace TALab3.Data
{
    public class LinkedNodes
    {
        public string PIB;
        public string FirstQuestion;
        public string SecondQuestion;
        public LinkedNodes? next;

        public LinkedNodes(string _PIB, string _FirstQuestion, string _SecondQuestion)
        {
            PIB = _PIB;
            FirstQuestion = _FirstQuestion;
            SecondQuestion = _SecondQuestion;
            next = null;
        }
        public LinkedNodes() 
        { 

        }

        public static void Add(LinkedNodes head, LinkedNodes newObj)
        {
            LinkedNodes next_point = head;

            while (next_point.next != null)
            {
                next_point = next_point.next;
            }
            next_point.next = newObj;
            next_point.next.next = null;
        }

        public static void AddAt(LinkedNodes head, LinkedNodes newObj, int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            else if (index == 0)
            {
                newObj.next = head;
                head = newObj;
            }
            else
            {
                LinkedNodes next_point = head;
                
                for (int i = 0; i < (index - 1); i++)
                {
                    next_point = next_point.next;
                }
                newObj.next = next_point.next;
                next_point.next = newObj;
            }
        }
        
        public static void RemoveLast(LinkedNodes head)
        {
            LinkedNodes next_point = head;

            while (next_point.next.next != null) 
            {
                next_point = next_point.next;
            }
            next_point.next = null;
        }

        public static void RemoveAt(LinkedNodes head, int index, int numOfElem)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            else if (index == 0)
            {
                head = head.next;
            }
            else if (index == (numOfElem - 1))
            {
                LinkedNodes.RemoveLast(head);
            }
            else
            {
                LinkedNodes next_point = head;
                
                for (int i = 0; i < (index - 1); i++)
                {
                    next_point = next_point.next;
                }
                next_point.next = next_point.next.next;
            }
        }
    }
}
