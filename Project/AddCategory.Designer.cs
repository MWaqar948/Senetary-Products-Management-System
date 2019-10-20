namespace Project
{
    partial class AddCategory
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.addCategoryBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.boreBox = new System.Windows.Forms.ComboBox();
            this.guageBox = new System.Windows.Forms.ComboBox();
            this.colourBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(179, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Guage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(179, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Bore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(179, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(395, 98);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(227, 20);
            this.nameTxt.TabIndex = 45;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price.Location = new System.Drawing.Point(179, 229);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(55, 20);
            this.Price.TabIndex = 35;
            this.Price.Text = "Colour";
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Depth = 0;
            this.addCategoryBtn.Location = new System.Drawing.Point(430, 355);
            this.addCategoryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Primary = true;
            this.addCategoryBtn.Size = new System.Drawing.Size(192, 33);
            this.addCategoryBtn.TabIndex = 46;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // boreBox
            // 
            this.boreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boreBox.FormattingEnabled = true;
            this.boreBox.Items.AddRange(new object[] {
            "GAS",
            "LEVEL",
            "1/2",
            "3/4",
            "1\".0",
            "1(1/4)",
            "1(1/2)",
            "2.0"});
            this.boreBox.Location = new System.Drawing.Point(395, 144);
            this.boreBox.Name = "boreBox";
            this.boreBox.Size = new System.Drawing.Size(227, 21);
            this.boreBox.TabIndex = 43;
            // 
            // guageBox
            // 
            this.guageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guageBox.FormattingEnabled = true;
            this.guageBox.Items.AddRange(new object[] {
            "1.0 mm",
            "1.1 mm",
            "1.2 mm",
            "1.3 mm",
            "1.4 mm ",
            "1.5 mm",
            "1.6 mm",
            "1.7 mm",
            "1.8 mm",
            "1.9 mm",
            "2.0 mm",
            "2.1 mm",
            "2.2 mm",
            "2.3 mm",
            "2.4 mm",
            "2.5 mm",
            "2.6 mm",
            "2.7 mm",
            "2.8 mm",
            "2.9 mm",
            "3.0 mm",
            "3.1 mm",
            "3.2 mm",
            "3.3 mm",
            "3.4 mm",
            "3.5 mm",
            "3.6 mm",
            "3.7 mm",
            "3.8 mm",
            "3.9 mm",
            "4.0 mm",
            "4.1 mm",
            "4.2 mm",
            "4.3 mm",
            "4.4 mm",
            "4.5 mm",
            "4.6 mm",
            "4.7 mm",
            "4.8 mm",
            "4.9 mm",
            "5.0 mm",
            "5.1 mm",
            "5.2 mm",
            "5.3 mm",
            "5.4 mm",
            "5.5 mm",
            "5.6 mm",
            "5.7 mm",
            "5.8 mm",
            "5.9 mm",
            "6.0 mm"});
            this.guageBox.Location = new System.Drawing.Point(395, 187);
            this.guageBox.Name = "guageBox";
            this.guageBox.Size = new System.Drawing.Size(227, 21);
            this.guageBox.TabIndex = 43;
            // 
            // colourBox
            // 
            this.colourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourBox.FormattingEnabled = true;
            this.colourBox.Items.AddRange(new object[] {
            "RED TRANSPARENT",
            "RED NON TRANSPARENT",
            "GREEN TRANSPARENT",
            "GREEN NON TRANSPARENT",
            "YELLOW TRANSPARENT",
            "YELLOW NON TRANSPARENT",
            "WHITE TRANSPARENT",
            "WHITE NON TRANSPARENT",
            "CRYSTAL TRANSPARENT",
            "CRYSTAL NON TRANSPARENT",
            "BLUE TRANSPARENT",
            "BLUE NON TRANSPARENT"});
            this.colourBox.Location = new System.Drawing.Point(395, 228);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(227, 21);
            this.colourBox.TabIndex = 43;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.guageBox);
            this.Controls.Add(this.boreBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label Price;
        private MaterialSkin.Controls.MaterialRaisedButton addCategoryBtn;
        private System.Windows.Forms.ComboBox boreBox;
        private System.Windows.Forms.ComboBox guageBox;
        private System.Windows.Forms.ComboBox colourBox;
    }
}