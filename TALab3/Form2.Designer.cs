namespace TALab3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelStudentIndex = new Label();
            numUDStudentIndex = new NumericUpDown();
            btnSaveIndex = new Button();
            ((System.ComponentModel.ISupportInitialize)numUDStudentIndex).BeginInit();
            SuspendLayout();
            // 
            // labelStudentIndex
            // 
            labelStudentIndex.AutoSize = true;
            labelStudentIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentIndex.Location = new Point(12, 9);
            labelStudentIndex.Name = "labelStudentIndex";
            labelStudentIndex.Size = new Size(323, 28);
            labelStudentIndex.TabIndex = 0;
            labelStudentIndex.Text = "Enter position of new student in list:";
            // 
            // numUDStudentIndex
            // 
            numUDStudentIndex.Location = new Point(12, 56);
            numUDStudentIndex.Name = "numUDStudentIndex";
            numUDStudentIndex.Size = new Size(323, 27);
            numUDStudentIndex.TabIndex = 1;
            // 
            // btnSaveIndex
            // 
            btnSaveIndex.Location = new Point(12, 102);
            btnSaveIndex.Name = "btnSaveIndex";
            btnSaveIndex.Size = new Size(323, 29);
            btnSaveIndex.TabIndex = 2;
            btnSaveIndex.Text = "Accept";
            btnSaveIndex.UseVisualStyleBackColor = true;
            btnSaveIndex.Click += btnSaveIndex_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 165);
            Controls.Add(btnSaveIndex);
            Controls.Add(numUDStudentIndex);
            Controls.Add(labelStudentIndex);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Add student";
            ((System.ComponentModel.ISupportInitialize)numUDStudentIndex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStudentIndex;
        private NumericUpDown numUDStudentIndex;
        private Button btnSaveIndex;
    }
}