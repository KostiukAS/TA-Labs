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
    }
}
