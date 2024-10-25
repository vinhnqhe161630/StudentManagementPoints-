namespace ProjectPrn
{
    partial class Login
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
            email = new TextBox();
            password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(350, 146);
            email.Name = "email";
            email.Size = new Size(215, 31);
            email.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(350, 213);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(215, 31);
            password.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(382, 301);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(395, 81);
            label1.Name = "label1";
            label1.Size = new Size(85, 38);
            label1.TabIndex = 3;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 141);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 219);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(email);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private TextBox password;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}