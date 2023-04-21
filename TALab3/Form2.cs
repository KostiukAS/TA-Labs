namespace TALab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int numberOfStudentsInSurvey;

        private void btnSaveIndex_Click(object sender, EventArgs e)
        {
            if (numUDStudentIndex.Value <= 0 || numUDStudentIndex.Value > (numberOfStudentsInSurvey + 1))
            {
                MessageBox.Show("You can`t add student here!");
                return;
            }
            else
            {;
                TALab3.indexFromSecondForm = (int)numUDStudentIndex.Value;
                this.Close();
            }
        }
    }
}
