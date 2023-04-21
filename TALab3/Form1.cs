using TALab3.Data;

namespace TALab3
{
    public partial class TALab3 : Form
    {
        public TALab3()
        {
            InitializeComponent();
        }
        public static int indexFromSecondForm;

        LinkedList studentList = new();
        LinkedList listOfQuestions = new();
        FirstMethod head = new();
        FirstMethod next_point = new();

        bool isFirstMethod = false;
        bool isSecondMethod = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGroup1_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            LinkedList.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 1.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.numberOfElements; i++)
                {
                    listBoxStudents.Items.Add(studentList.list[i].information);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Exeption: " + ex);
            }
        }

        private void btnGroup2_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            LinkedList.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 2.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.numberOfElements; i++)
                {
                    listBoxStudents.Items.Add(studentList.list[i].information);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Exeption: " + ex);
            }
        }

        private void btnGroup3_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            LinkedList.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 3.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.numberOfElements; i++)
                {
                    listBoxStudents.Items.Add(studentList.list[i].information);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Exeption: " + ex);
            }
        }

        private void btnClearListOfStudents_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            LinkedList.Clear(studentList);
        }

        private void btnFirstMethod_Click(object sender, EventArgs e)
        {
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedList.StrClear(listOfQuestions);
            isFirstMethod = true;
            isSecondMethod = false;

            if (studentList.numberOfElements == 0)
            {
                MessageBox.Show("List of students is empty!");
                return;
            }

            WorkWithLists.generateArrayOfQuestions(listOfQuestions);

            try
            {
                head = new FirstMethod(studentList.list[0].information, listOfQuestions.listString[0], listOfQuestions.listString[1]);
                next_point = head;

                for (int i = 0; i < studentList.numberOfElements; i++)
                {
                    if (i == 0)
                    {
                        listBoxSurvey.Items.Add(next_point.PIB);
                        listBoxQuestions.Items.Add(next_point.FirstQuestion + " " + next_point.SecondQuestion);
                        continue;
                    }
                    else
                    {
                        next_point.next = new FirstMethod(studentList.list[i].information, next_point.SecondQuestion, listOfQuestions.listString[i + 1]);
                        next_point = next_point.next;
                        if (i == (studentList.numberOfElements - 1))
                        {
                            next_point.next = null;
                        }
                    }

                    listBoxSurvey.Items.Add(next_point.PIB);
                    listBoxQuestions.Items.Add(next_point.FirstQuestion + " " + next_point.SecondQuestion);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void btnSecondMethod_Click(object sender, EventArgs e)
        {
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedList.StrClear(listOfQuestions);
            isFirstMethod = false;
            isSecondMethod = true;

            if (studentList.numberOfElements == 0)
            {
                MessageBox.Show("List of students is empty!");
                return;
            }

            WorkWithLists.generateArrayOfQuestions(listOfQuestions);

            for (int i = 0; i < studentList.numberOfElements; i++)
            {
                studentList.list[i].secondQuestion = listOfQuestions.listString[i + 1];

                if (i == 0)
                {
                    studentList.list[i].firstQuestion = listOfQuestions.listString[i];
                    studentList.list[i].pointer = studentList.list[i + 1];
                }
                else if (i == (studentList.numberOfElements - 1))
                {
                    studentList.list[i].firstQuestion = studentList.list[i - 1].secondQuestion;
                    studentList.list[i].pointer = null;
                }
                else
                {
                    studentList.list[i].firstQuestion = studentList.list[i - 1].secondQuestion;
                    studentList.list[i].pointer = studentList.list[i + 1];
                }

                listBoxSurvey.Items.Add(studentList.list[i].information);
                listBoxQuestions.Items.Add(studentList.list[i].firstQuestion + " " + studentList.list[i].secondQuestion);
            }
        }

        private void btnClearSurveyList_Click(object sender, EventArgs e)
        {
            listBoxQuestions.Items.Clear();
            listBoxSurvey.Items.Clear();
            LinkedList.StrClear(listOfQuestions);
            isFirstMethod = false;
            isSecondMethod = false;
        }

        private void btbAddStudent_Click(object sender, EventArgs e)
        {
            if (listBoxSurvey.Items.Count == listBoxStudents.Items.Count)
            {
                MessageBox.Show("You can`t add new elements!");
                return;
            }
            else if (studentList.numberOfElements == 0)
            {
                MessageBox.Show("Generate List of students firstly!");
            }

            if (isFirstMethod)
            {
                Form2 f2 = new Form2();
                f2.numberOfStudentsInSurvey = listBoxSurvey.Items.Count;
                f2.ShowDialog();

                if (indexFromSecondForm != 0)
                {
                    FirstMethod newObj = new();
                    
                    for (int i = 0; i < listBoxStudents.Items.Count; i++)
                    {
                        int iter = listBoxSurvey.Items.Count;

                        for (int j = 0; j < listBoxSurvey.Items.Count; j++)
                        {
                            if (listBoxStudents.Items[i].ToString() == listBoxSurvey.Items[j].ToString())
                            {
                                break;
                            }
                            iter--;
                        }
                        if (iter == 0)
                        {
                            newObj.PIB = listBoxStudents.Items[i].ToString();
                            newObj.FirstQuestion = listOfQuestions.listString[indexFromSecondForm - 1];
                            newObj.SecondQuestion = listOfQuestions.listString[indexFromSecondForm - 1];
                            FirstMethod.AddAt(head, newObj, indexFromSecondForm - 1);
                            listBoxSurvey.Items.Insert(indexFromSecondForm - 1, newObj.PIB);
                            listBoxQuestions.Items.Insert(indexFromSecondForm - 1, newObj.FirstQuestion + " " + newObj.SecondQuestion);
                            indexFromSecondForm = 0;
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else if (isSecondMethod)
            {
                Form2 f2 = new Form2();
                f2.numberOfStudentsInSurvey = listBoxSurvey.Items.Count;
                f2.ShowDialog();

                if (indexFromSecondForm != 0)
                {
                    Node newElem = new();

                    for (int i = 0; i < listBoxStudents.Items.Count; i++)
                    {
                        int iter = listBoxSurvey.Items.Count;

                        for (int j = 0; j < listBoxSurvey.Items.Count; j++)
                        {
                            if (listBoxStudents.Items[i].ToString() == listBoxSurvey.Items[j].ToString())
                            {
                                break;
                            }
                            iter--;
                        }
                        if (iter == 0)
                        {
                            newElem.information = listBoxStudents.Items[i].ToString();
                            newElem.firstQuestion = listOfQuestions.listString[indexFromSecondForm - 1];
                            newElem.secondQuestion = listOfQuestions.listString[indexFromSecondForm - 1];
                            if (indexFromSecondForm == 1)
                            {
                                newElem.pointer = studentList.list[indexFromSecondForm];
                            }
                            else if (indexFromSecondForm == (listBoxSurvey.Items.Count + 1))
                            {
                                newElem.pointer = null;
                                studentList.list[indexFromSecondForm - 2].pointer = newElem;
                                newElem.firstQuestion = listOfQuestions.listString[indexFromSecondForm];
                                newElem.secondQuestion = listOfQuestions.listString[indexFromSecondForm + 1];
                            }
                            else
                            {
                                newElem.pointer = studentList.list[indexFromSecondForm];
                                studentList.list[indexFromSecondForm - 2].pointer = newElem;
                            }                            
                            LinkedList.AddAt(studentList, newElem, indexFromSecondForm - 1);
                            listBoxSurvey.Items.Insert(indexFromSecondForm - 1, newElem.information);
                            listBoxQuestions.Items.Insert(indexFromSecondForm - 1, newElem.firstQuestion + " " + newElem.secondQuestion);
                            indexFromSecondForm = 0;
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Generate List of survey firstly!");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (listBoxSurvey.SelectedItem == null)
            {
                MessageBox.Show("Item is not choosen!");
                return;
            }

            if (isFirstMethod)
            {
                int index = listBoxSurvey.SelectedIndex;

                try
                {
                    FirstMethod.RemoveAt(head, index, listBoxSurvey.Items.Count);
                    listBoxSurvey.Items.RemoveAt(index);
                    listBoxQuestions.Items.RemoveAt(index);                    
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Exception: " + ex);
                }
            }
            else if (isSecondMethod)
            {
                int index = listBoxSurvey.SelectedIndex;
                int lenOfList = listBoxSurvey.Items.Count;

                try
                {
                    listBoxSurvey.Items.RemoveAt(index);
                    listBoxQuestions.Items.RemoveAt(index);
                    LinkedList.RemoveAt(studentList, index);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Exception: " + ex);
                }

                if (index == 0)
                {
                    return;
                }
                else if (index == (lenOfList - 1))
                {
                    studentList.list[index - 1].pointer = null;
                }
                else
                {
                    studentList.list[index - 1].pointer = studentList.list[index];
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}