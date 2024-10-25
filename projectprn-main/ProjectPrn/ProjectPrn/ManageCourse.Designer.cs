namespace ProjectPrn
{
    partial class ManageCourse
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
            courseList = new ComboBox();
            grade = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            weight = new NumericUpDown();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weight).BeginInit();
            SuspendLayout();
            // 
            // courseList
            // 
            courseList.FormattingEnabled = true;
            courseList.Location = new Point(168, 103);
            courseList.Name = "courseList";
            courseList.Size = new Size(182, 33);
            courseList.TabIndex = 9;
            courseList.SelectedIndexChanged += courseList_SelectedIndexChanged;
            // 
            // grade
            // 
            grade.Location = new Point(229, 229);
            grade.Name = "grade";
            grade.Size = new Size(150, 31);
            grade.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 106);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 11;
            label2.Text = "Course";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 229);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 13;
            label1.Text = "Name grade";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(238, 506);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 419);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Refesh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 324);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 16;
            label4.Text = "Percent";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(562, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(444, 408);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // weight
            // 
            weight.Location = new Point(229, 318);
            weight.Name = "weight";
            weight.Size = new Size(150, 31);
            weight.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(93, 419);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 19;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 506);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 20;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(387, 103);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 21;
            button5.Text = "Show";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(807, 618);
            button6.Name = "button6";
            button6.Size = new Size(199, 34);
            button6.TabIndex = 23;
            button6.Text = "Return Manage Grade";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ManageCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 681);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(weight);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(grade);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(courseList);
            Name = "ManageCourse";
            Text = "ManageCourse";
            Load += ManageClass_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)weight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox courseList;
        private TextBox grade;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label4;
        private DataGridView dataGridView1;
        private NumericUpDown weight;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}