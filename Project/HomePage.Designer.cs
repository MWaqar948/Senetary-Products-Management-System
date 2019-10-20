namespace Project
{
    partial class HomePage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.CourseBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.reportBtn);
            this.panel2.Controls.Add(this.signUpBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.studentBtn);
            this.panel2.Controls.Add(this.CourseBtn);
            this.panel2.Controls.Add(this.categoryBtn);
            this.panel2.Controls.Add(this.signOutBtn);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 55);
            this.panel2.TabIndex = 1;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.reportBtn.Location = new System.Drawing.Point(521, 14);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(63, 27);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.signUpBtn.Location = new System.Drawing.Point(429, 15);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(80, 27);
            this.signUpBtn.TabIndex = 6;
            this.signUpBtn.Text = "Raw Material";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Black;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.homeBtn.Location = new System.Drawing.Point(6, 13);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(83, 27);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Dashboard";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // studentBtn
            // 
            this.studentBtn.BackColor = System.Drawing.Color.Black;
            this.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.studentBtn.Location = new System.Drawing.Point(99, 13);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(83, 27);
            this.studentBtn.TabIndex = 5;
            this.studentBtn.Text = "Products";
            this.studentBtn.UseVisualStyleBackColor = false;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // CourseBtn
            // 
            this.CourseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CourseBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.CourseBtn.Location = new System.Drawing.Point(320, 14);
            this.CourseBtn.Name = "CourseBtn";
            this.CourseBtn.Size = new System.Drawing.Size(95, 27);
            this.CourseBtn.TabIndex = 4;
            this.CourseBtn.Text = "Brand";
            this.CourseBtn.UseVisualStyleBackColor = false;
            this.CourseBtn.Click += new System.EventHandler(this.CourseBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.categoryBtn.Location = new System.Drawing.Point(200, 13);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(116, 27);
            this.categoryBtn.TabIndex = 3;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signOutBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.signOutBtn.Location = new System.Drawing.Point(678, 13);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(63, 27);
            this.signOutBtn.TabIndex = 2;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel2);
            this.Name = "HomePage";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button reportBtn;
        public System.Windows.Forms.Button signUpBtn;
        public System.Windows.Forms.Button homeBtn;
        public System.Windows.Forms.Button studentBtn;
        public System.Windows.Forms.Button CourseBtn;
        public System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button signOutBtn;
    }
}

