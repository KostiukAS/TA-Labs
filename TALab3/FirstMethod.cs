namespace TALab3.Data
{
    public class FirstMethod
    {
        public string PIB;
        public string FirstQuestion;
        public string SecondQuestion;
        public FirstMethod? next;

        public FirstMethod(string _PIB, string _FirstQuestion, string _SecondQuestion)
        {
            PIB = _PIB;
            FirstQuestion = _FirstQuestion;
            SecondQuestion = _SecondQuestion;
            next = null;
        }
        public FirstMethod() 
        { 

        }

        public static void Add(FirstMethod head, FirstMethod newObj)
        {
            FirstMethod next_point = head;

            while (next_point.next != null)
            {
                next_point = next_point.next;
            }
            next_point.next = newObj;
            next_point.next.next = null;
        }

        public static void AddAt(FirstMethod head, FirstMethod newObj, int index)
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
                FirstMethod next_point = head;
                
                for (int i = 0; i < (index - 1); i++)
                {
                    next_point = next_point.next;
                }
                newObj.next = next_point.next;
                next_point.next = newObj;
            }
        }
        
        public static void RemoveLast(FirstMethod head)
        {
            FirstMethod next_point = head;

            while (next_point.next.next != null) 
            {
                next_point = next_point.next;
            }
            next_point.next = null;
        }

        public static void RemoveAt(FirstMethod head, int index, int numOfElem)
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
                FirstMethod.RemoveLast(head);
            }
            else
            {
                FirstMethod next_point = head;
                
                for (int i = 0; i < (index - 1); i++)
                {
                    next_point = next_point.next;
                }
                next_point.next = next_point.next.next;
            }
        }
    }
}
