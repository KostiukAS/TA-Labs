namespace TALab3.Data
{
    public class WorkWithLists
    {
        public static void ReadListOfStudents(string path, LinkedList studentList)
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
                    LinkedList.Add(studentList, new Node(line));
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

        public static void generateArrayOfQuestions(LinkedList listOfQuestions)
        {
            Random random = new Random();
            
            try
            {
                var readQuestions = new LinkedList();
                
                StreamReader sr = new StreamReader("..//..//..//Questions.txt");
                var line = sr.ReadLine();

                while (line != null)
                {
                    LinkedList.StrAdd(readQuestions, line);
                    line = sr.ReadLine();
                }

                sr.Close();

                for (int i = 0; i < readQuestions.strNumberOfElements; i++) 
                { 
                    var r = random.Next(readQuestions.strNumberOfElements);
                    LinkedList.StrAdd(listOfQuestions, readQuestions.listString[r]);
                }
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
