namespace RentalApp
{
    partial class AdminDashboard
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
            // if
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
            IbTitel = new Label();
            btnManageUsers = new Button();
            btnViewProperties = new Button();
            btnInvoices = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // IbTitel
            // 
            IbTitel.AutoSize = true;
            IbTitel.Font = new Font("Segoe UI", 15F);
            IbTitel.ForeColor = SystemColors.Highlight;
            IbTitel.Location = new Point(187, 35);
            IbTitel.Name = "IbTitel";
            IbTitel.Size = new Size(258, 41);
            IbTitel.TabIndex = 0;
            IbTitel.Text = "Admin Dashboard";
            IbTitel.Click += IbTitel_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.ForeColor = SystemColors.Highlight;
            btnManageUsers.Location = new Point(221, 120);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(191, 56);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnViewProperties
            // 
            btnViewProperties.ForeColor = SystemColors.Highlight;
            btnViewProperties.Location = new Point(221, 182);
            btnViewProperties.Name = "btnViewProperties";
            btnViewProperties.Size = new Size(191, 55);
            btnViewProperties.TabIndex = 2;
            btnViewProperties.Text = "View All Properties";
            btnViewProperties.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            btnInvoices.ForeColor = SystemColors.Highlight;
            btnInvoices.Location = new Point(221, 243);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(191, 53);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "Manage Invoices";
            btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.ForeColor = SystemColors.Highlight;
            btnReports.Location = new Point(221, 302);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(191, 53);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Highlight;
            btnLogout.Location = new Point(54, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 478);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnInvoices);
            Controls.Add(btnViewProperties);
            Controls.Add(btnManageUsers);
            Controls.Add(IbTitel);
            Name = "Form2";
            Text = "AdminForm";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbTitel;
        private Button btnManageUsers;
        private Button btnViewProperties;
        private Button btnInvoices;
        private Button btnReports;
        private Button btnLogout;
    }
}