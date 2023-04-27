using System;
using System.Reflection;
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

        LinkedListNode studentList = new();
        LinkedListString listOfQuestions = new();
        public LinkedNodes head = new();
        LinkedNodes next_point = new();

        bool isFirstMethod = false;
        bool isSecondMethod = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGroup1_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedListNode.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 1.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.length; i++)
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
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedListNode.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 2.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.length; i++)
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
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedListNode.Clear(studentList);

            WorkWithLists.ReadListOfStudents("..//..//..//Group 3.txt", studentList);

            try
            {
                for (int i = 0; i < studentList.length; i++)
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
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedListNode.Clear(studentList);
        }

        private void btnFirstMethod_Click(object sender, EventArgs e)
        {
            listBoxSurvey.Items.Clear();
            listBoxQuestions.Items.Clear();
            LinkedListString.Clear(listOfQuestions);
            isFirstMethod = true;
            isSecondMethod = false;

            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("List of students is empty!");
                return;
            }

            WorkWithLists.generateArrayOfQuestions(listOfQuestions);

            try
            {
                head = new LinkedNodes(studentList.list[0].information, listOfQuestions.list[0], listOfQuestions.list[1]);
                next_point = head;

                for (int i = 0; i < studentList.length; i++)
                {
                    if (i == 0)
                    {
                        listBoxSurvey.Items.Add(next_point.PIB);
                        listBoxQuestions.Items.Add(next_point.FirstQuestion + " " + next_point.SecondQuestion);
                        continue;
                    }
                    else
                    {
                        next_point.next = new LinkedNodes(studentList.list[i].information, next_point.SecondQuestion, listOfQuestions.list[i + 1]);
                        next_point = next_point.next;
                        if (i == (studentList.length - 1))
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
            LinkedListString.Clear(listOfQuestions);
            isFirstMethod = false;
            isSecondMethod = true;

            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("List of students is empty!");
                return;
            }

            WorkWithLists.generateArrayOfQuestions(listOfQuestions);

            for (int i = 0; i < studentList.length; i++)
            {
                studentList.list[i].secondQuestion = listOfQuestions.list[i + 1];

                if (i == 0)
                {
                    studentList.list[i].firstQuestion = listOfQuestions.list[i];
                    studentList.list[i].pointer = studentList.list[i + 1];
                }
                else if (i == (studentList.length - 1))
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
            LinkedListString.Clear(listOfQuestions);
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
            else if (studentList.length == 0)
            {
                MessageBox.Show("Generate List of students firstly!");
                return;
            }

            Random rnd = new Random();

            if (isFirstMethod)
            {
                Form2 f2 = new Form2();
                f2.numberOfStudentsInSurvey = listBoxSurvey.Items.Count;
                f2.ShowDialog();

                if (indexFromSecondForm != 0)
                {
                    LinkedNodes newObj = new();
                    
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
                            newObj.FirstQuestion = listOfQuestions.list[rnd.Next(listOfQuestions.length)];
                            newObj.SecondQuestion = listOfQuestions.list[rnd.Next(listOfQuestions.length)];

                            if (indexFromSecondForm != (listBoxSurvey.Items.Count + 1))
                            {
                                LinkedNodes next_point = head;

                                for (int k = 0; k < (indexFromSecondForm - 1); k++)
                                {
                                    next_point = next_point.next;
                                }

                                next_point.FirstQuestion = newObj.SecondQuestion;

                                listBoxQuestions.Items.RemoveAt(indexFromSecondForm - 1);
                                listBoxQuestions.Items.Insert(indexFromSecondForm - 1, next_point.FirstQuestion + " " + next_point.SecondQuestion);
                            }
                            if (indexFromSecondForm != 1)
                            {
                                LinkedNodes next_point = head;

                                for (int k = 0; k < (indexFromSecondForm - 2); k++)
                                {
                                    next_point = next_point.next;
                                }

                                next_point.SecondQuestion = newObj.FirstQuestion;

                                listBoxQuestions.Items.RemoveAt(indexFromSecondForm - 2);
                                listBoxQuestions.Items.Insert(indexFromSecondForm - 2, next_point.FirstQuestion + " " + next_point.SecondQuestion);
                            }
                            LinkedNodes.AddAt(head, newObj, indexFromSecondForm - 1);
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
                            newElem.firstQuestion = listOfQuestions.list[rnd.Next(listOfQuestions.length)];
                            newElem.secondQuestion = listOfQuestions.list[rnd.Next(listOfQuestions.length)];
                            if (indexFromSecondForm == 1)
                            {
                                newElem.pointer = studentList.list[indexFromSecondForm];
                                studentList.list[indexFromSecondForm - 1].firstQuestion = newElem.secondQuestion;
                            }
                            else if (indexFromSecondForm == (listBoxSurvey.Items.Count + 1))
                            {
                                newElem.pointer = null;
                                studentList.list[indexFromSecondForm - 2].pointer = newElem;
                                studentList.list[indexFromSecondForm - 2].secondQuestion = newElem.firstQuestion;
                            }
                            else
                            {
                                newElem.pointer = studentList.list[indexFromSecondForm];
                                studentList.list[indexFromSecondForm - 2].pointer = newElem;
                                studentList.list[indexFromSecondForm - 2].secondQuestion = newElem.firstQuestion;
                                studentList.list[indexFromSecondForm - 1].firstQuestion = newElem.secondQuestion;
                            }
                            if (indexFromSecondForm != (listBoxSurvey.Items.Count + 1))
                            {
                                listBoxQuestions.Items.RemoveAt(indexFromSecondForm - 1);
                                listBoxQuestions.Items.Insert(indexFromSecondForm - 1,
                                    studentList.list[indexFromSecondForm - 1].firstQuestion + " " + studentList.list[indexFromSecondForm - 1].secondQuestion);
                            }
                            if (indexFromSecondForm != 1)
                            {
                                listBoxQuestions.Items.RemoveAt(indexFromSecondForm - 2);
                                listBoxQuestions.Items.Insert(indexFromSecondForm - 2,
                                    studentList.list[indexFromSecondForm - 2].firstQuestion + " " + studentList.list[indexFromSecondForm - 2].secondQuestion);
                            }
                            LinkedListNode.AddAt(studentList, newElem, indexFromSecondForm - 1);
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
            if (listBoxQuestions.Items.Count == 1)
            {
                listBoxStudents.Items.Clear();
            }

            if (isFirstMethod)
            {
                int index = listBoxSurvey.SelectedIndex;
                int lenOfList = listBoxSurvey.Items.Count;

                try
                {
                    LinkedNodes.RemoveAt(head, index, listBoxSurvey.Items.Count);
                    listBoxSurvey.Items.RemoveAt(index);
                    listBoxQuestions.Items.RemoveAt(index);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Exception: " + ex);
                }

                if (index == 0)
                {
                    return;
                }

                LinkedNodes next_point = head;

                for (int i = 0; i < (index - 1); i++)
                {
                    next_point = next_point.next;
                }

                if (index != (lenOfList - 1))
                {
                    next_point.next.FirstQuestion = next_point.SecondQuestion;
                    listBoxQuestions.Items.RemoveAt(index);
                    listBoxQuestions.Items.Insert(index, next_point.next.FirstQuestion + " " + next_point.next.SecondQuestion);
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
                    LinkedListNode.RemoveAt(studentList, index);
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
                    studentList.list[index].firstQuestion = studentList.list[index - 1].secondQuestion;
                    listBoxQuestions.Items.RemoveAt(index);
                    listBoxQuestions.Items.Insert(index, studentList.list[index].firstQuestion + " " + studentList.list[index].secondQuestion);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}