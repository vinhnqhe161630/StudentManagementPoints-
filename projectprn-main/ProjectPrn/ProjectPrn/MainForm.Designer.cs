namespace ProjectPrn
{
    partial class MainForm
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
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            subject_Class = new ComboBox();
            button3 = new Button();
            rollNumber = new TextBox();
            addnewStudent = new TextBox();
            label4 = new Label();
            button1 = new Button();
            nameTeacher = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(984, 806);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(931, 568);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(30, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 583);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 156);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 6;
            label1.Text = "Grading details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 97);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 7;
            label2.Text = "Subject/Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 96);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 8;
            label3.Text = "Roll Number";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(841, 88);
            button2.Name = "button2";
            button2.Size = new Size(90, 33);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // subject_Class
            // 
            subject_Class.FormattingEnabled = true;
            subject_Class.Location = new Point(153, 89);
            subject_Class.Name = "subject_Class";
            subject_Class.Size = new Size(182, 33);
            subject_Class.TabIndex = 14;
            subject_Class.SelectedIndexChanged += subject_Class_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(351, 91);
            button3.Name = "button3";
            button3.Size = new Size(101, 29);
            button3.TabIndex = 15;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // rollNumber
            // 
            rollNumber.Location = new Point(631, 89);
            rollNumber.Name = "rollNumber";
            rollNumber.Size = new Size(204, 31);
            rollNumber.TabIndex = 16;
            rollNumber.TextChanged += rollNumber_TextChanged;
            // 
            // addnewStudent
            // 
            addnewStudent.Location = new Point(707, 809);
            addnewStudent.Name = "addnewStudent";
            addnewStudent.Size = new Size(240, 31);
            addnewStudent.TabIndex = 17;
            addnewStudent.TextChanged += addnewStudent_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 815);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 18;
            label4.Text = "Add new Student";
            // 
            // button1
            // 
            button1.Location = new Point(1236, 880);
            button1.Name = "button1";
            button1.Size = new Size(176, 34);
            button1.TabIndex = 22;
            button1.Text = "Manage Coure";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTeacher
            // 
            nameTeacher.AutoSize = true;
            nameTeacher.Location = new Point(63, 139);
            nameTeacher.Name = "nameTeacher";
            nameTeacher.Size = new Size(59, 25);
            nameTeacher.TabIndex = 23;
            nameTeacher.Text = "label5";
            nameTeacher.Click += nameTeacher_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 948);
            Controls.Add(nameTeacher);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(addnewStudent);
            Controls.Add(rollNumber);
            Controls.Add(button3);
            Controls.Add(subject_Class);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private ComboBox subject_Class;
        private Button button3;
        private TextBox rollNumber;
        private TextBox addnewStudent;
        private Label label4;
        private Button button1;
        private Label nameTeacher;
    }

}