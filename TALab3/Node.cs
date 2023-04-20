namespace TALab3.Data
{
    public class Node
    {
        public string information;
        public string firstQuestion;
        public string secondQuestion;
        public Node? pointer;

        public Node() { }

        public Node(string _info)
        {
            information = _info;
        }

        public Node(string _info, string _firstQuestion, string _secondQuestion) 
        {
            information = _info;
            firstQuestion = _firstQuestion;
            secondQuestion = _secondQuestion;
        }
    }
}
