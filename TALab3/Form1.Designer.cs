namespace TALab3
{
    partial class TALab3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelOfStudentList = new Label();
            listBoxStudents = new ListBox();
            btnGroup1 = new Button();
            btnGroup2 = new Button();
            btnGroup3 = new Button();
            btnClearListOfStudents = new Button();
            labelOfSurveyList = new Label();
            listBoxSurvey = new ListBox();
            btnFirstMethod = new Button();
            btnSecondMethod = new Button();
            btnClearSurveyList = new Button();
            labelOfQuestions = new Label();
            listBoxQuestions = new ListBox();
            SuspendLayout();
            // 
            // labelOfStudentList
            // 
            labelOfStudentList.AutoSize = true;
            labelOfStudentList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfStudentList.Location = new Point(32, 21);
            labelOfStudentList.Name = "labelOfStudentList";
            labelOfStudentList.Size = new Size(143, 28);
            labelOfStudentList.TabIndex = 0;
            labelOfStudentList.Text = "List of students";
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 20;
            listBoxStudents.Location = new Point(32, 60);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(299, 484);
            listBoxStudents.TabIndex = 1;
            // 
            // btnGroup1
            // 
            btnGroup1.Location = new Point(32, 569);
            btnGroup1.Name = "btnGroup1";
            btnGroup1.Size = new Size(299, 29);
            btnGroup1.TabIndex = 2;
            btnGroup1.Text = "Group - X1";
            btnGroup1.UseVisualStyleBackColor = true;
            btnGroup1.Click += btnGroup1_Click;
            // 
            // btnGroup2
            // 
            btnGroup2.Location = new Point(32, 616);
            btnGroup2.Name = "btnGroup2";
            btnGroup2.Size = new Size(299, 29);
            btnGroup2.TabIndex = 3;
            btnGroup2.Text = "Group - X2";
            btnGroup2.UseVisualStyleBackColor = true;
            btnGroup2.Click += btnGroup2_Click;
            // 
            // btnGroup3
            // 
            btnGroup3.Location = new Point(32, 663);
            btnGroup3.Name = "btnGroup3";
            btnGroup3.Size = new Size(299, 29);
            btnGroup3.TabIndex = 4;
            btnGroup3.Text = "Group - X3";
            btnGroup3.UseVisualStyleBackColor = true;
            btnGroup3.Click += btnGroup3_Click;
            // 
            // btnClearListOfStudents
            // 
            btnClearListOfStudents.Location = new Point(32, 710);
            btnClearListOfStudents.Name = "btnClearListOfStudents";
            btnClearListOfStudents.Size = new Size(299, 29);
            btnClearListOfStudents.TabIndex = 5;
            btnClearListOfStudents.Text = "Clear";
            btnClearListOfStudents.UseVisualStyleBackColor = true;
            btnClearListOfStudents.Click += btnClearListOfStudents_Click;
            // 
            // labelOfSurveyList
            // 
            labelOfSurveyList.AutoSize = true;
            labelOfSurveyList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfSurveyList.Location = new Point(362, 21);
            labelOfSurveyList.Name = "labelOfSurveyList";
            labelOfSurveyList.Size = new Size(125, 28);
            labelOfSurveyList.TabIndex = 6;
            labelOfSurveyList.Text = "List of survey";
            // 
            // listBoxSurvey
            // 
            listBoxSurvey.FormattingEnabled = true;
            listBoxSurvey.ItemHeight = 20;
            listBoxSurvey.Location = new Point(362, 60);
            listBoxSurvey.Name = "listBoxSurvey";
            listBoxSurvey.Size = new Size(299, 484);
            listBoxSurvey.TabIndex = 7;
            // 
            // btnFirstMethod
            // 
            btnFirstMethod.Location = new Point(362, 569);
            btnFirstMethod.Name = "btnFirstMethod";
            btnFirstMethod.Size = new Size(299, 29);
            btnFirstMethod.TabIndex = 8;
            btnFirstMethod.Text = "First method";
            btnFirstMethod.UseVisualStyleBackColor = true;
            btnFirstMethod.Click += btnFirstMethod_Click;
            // 
            // btnSecondMethod
            // 
            btnSecondMethod.Location = new Point(362, 616);
            btnSecondMethod.Name = "btnSecondMethod";
            btnSecondMethod.Size = new Size(299, 29);
            btnSecondMethod.TabIndex = 9;
            btnSecondMethod.Text = "Second method";
            btnSecondMethod.UseVisualStyleBackColor = true;
            btnSecondMethod.Click += btnSecondMethod_Click;
            // 
            // btnClearSurveyList
            // 
            btnClearSurveyList.Location = new Point(362, 663);
            btnClearSurveyList.Name = "btnClearSurveyList";
            btnClearSurveyList.Size = new Size(299, 29);
            btnClearSurveyList.TabIndex = 12;
            btnClearSurveyList.Text = "Clear";
            btnClearSurveyList.UseVisualStyleBackColor = true;
            btnClearSurveyList.Click += btnClearSurveyList_Click;
            // 
            // labelOfQuestions
            // 
            labelOfQuestions.AutoSize = true;
            labelOfQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOfQuestions.Location = new Point(692, 21);
            labelOfQuestions.Name = "labelOfQuestions";
            labelOfQuestions.Size = new Size(153, 28);
            labelOfQuestions.TabIndex = 13;
            labelOfQuestions.Text = "List of questions";
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 20;
            listBoxQuestions.Location = new Point(692, 60);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(299, 484);
            listBoxQuestions.TabIndex = 14;
            // 
            // TALab3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 809);
            Controls.Add(listBoxQuestions);
            Controls.Add(labelOfQuestions);
            Controls.Add(btnClearSurveyList);
            Controls.Add(btnSecondMethod);
            Controls.Add(btnFirstMethod);
            Controls.Add(listBoxSurvey);
            Controls.Add(labelOfSurveyList);
            Controls.Add(btnClearListOfStudents);
            Controls.Add(btnGroup3);
            Controls.Add(btnGroup2);
            Controls.Add(btnGroup1);
            Controls.Add(listBoxStudents);
            Controls.Add(labelOfStudentList);
            Name = "TALab3";
            Text = "TA Lab 3";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOfStudentList;
        private ListBox listBoxStudents;
        private Button btnGroup1;
        private Button btnGroup2;
        private Button btnGroup3;
        private Button btnClearListOfStudents;
        private Label labelOfSurveyList;
        private ListBox listBoxSurvey;
        private Button btnFirstMethod;
        private Button btnSecondMethod;
        private Button btnClearSurveyList;
        private Label labelOfQuestions;
        private ListBox listBoxQuestions;
    }
}