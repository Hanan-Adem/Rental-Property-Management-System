namespace RentalApp
{
    partial class LoginForm
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
            Logintitel = new Label();
            btnlogin = new Button();
            Usertxt = new Label();
            Passtxt = new Label();
            usertxtBox = new TextBox();
            passtxtBox = new TextBox();
            SuspendLayout();
            // 
            // Logintitel
            // 
            Logintitel.AutoSize = true;
            Logintitel.Font = new Font("Segoe UI", 15F);
            Logintitel.ForeColor = Color.CornflowerBlue;
            Logintitel.ImageAlign = ContentAlignment.TopCenter;
            Logintitel.Location = new Point(241, 69);
            Logintitel.Name = "Logintitel";
            Logintitel.Size = new Size(165, 41);
            Logintitel.TabIndex = 0;
            Logintitel.Text = "Login Page";
            Logintitel.Click += label1_Click;
            // 
            // btnlogin
            // 
            btnlogin.ForeColor = SystemColors.Highlight;
            btnlogin.Location = new Point(243, 310);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(163, 34);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Usertxt
            // 
            Usertxt.AutoSize = true;
            Usertxt.ForeColor = SystemColors.Highlight;
            Usertxt.Location = new Point(106, 166);
            Usertxt.Name = "Usertxt";
            Usertxt.Size = new Size(91, 25);
            Usertxt.TabIndex = 2;
            Usertxt.Text = "Username";
            // 
            // Passtxt
            // 
            Passtxt.AutoSize = true;
            Passtxt.ForeColor = SystemColors.Highlight;
            Passtxt.Location = new Point(106, 230);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(87, 25);
            Passtxt.TabIndex = 3;
            Passtxt.Text = "Password";
            Passtxt.Click += label3_Click;
            // 
            // usertxtBox
            // 
            usertxtBox.Location = new Point(227, 165);
            usertxtBox.Name = "usertxtBox";
            usertxtBox.Size = new Size(236, 31);
            usertxtBox.TabIndex = 4;
            usertxtBox.TextChanged += textBox1_TextChanged;
            // 
            // passtxtBox
            // 
            passtxtBox.Location = new Point(227, 229);
            passtxtBox.Name = "passtxtBox";
            passtxtBox.Size = new Size(236, 31);
            passtxtBox.TabIndex = 4;
            passtxtBox.TextChanged += textBox1_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(passtxtBox);
            Controls.Add(usertxtBox);
            Controls.Add(Passtxt);
            Controls.Add(Usertxt);
            Controls.Add(btnlogin);
            Controls.Add(Logintitel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Logintitel;
        private Button btnlogin;
        private Label Usertxt;
        private Label Passtxt;
        private TextBox usertxtBox;
        private TextBox passtxtBox;
    }
}
