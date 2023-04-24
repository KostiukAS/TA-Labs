namespace TALab3.Data
{
    public class WorkWithLists
    {
        public static void ReadListOfStudents(string path, LinkedList<Node> studentList)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                var line = sr.ReadLine();

                if (line == null)
                {
                    MessageBox.Show("File does not contains students");
                }

                while (line != null) 
                { 
                    LinkedListNode.Add(studentList, new Node(line));
                    line = sr.ReadLine();
                }

                sr.Close();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
        }

        public static void generateArrayOfQuestions(LinkedList<string> listOfQuestions)
        {
            Random random = new Random();
            
            try
            {
                StreamReader sr = new StreamReader("..//..//..//Questions.txt");
                var line = sr.ReadLine();

                while (line != null)
                {
                    var index = random.Next(listOfQuestions.length);
                    LinkedListString.AddAt(listOfQuestions, line, index);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Exeption: " + ex.Message);
            }
        }
    }
}
