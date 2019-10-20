namespace Project
{
    partial class AddProduct
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
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.addBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(179, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Brand";
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
            // nameBox
            // 
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "Pipe",
            "Gas Pipe"});
            this.nameBox.Location = new System.Drawing.Point(395, 100);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(227, 21);
            this.nameBox.TabIndex = 43;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(395, 245);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(227, 20);
            this.priceText.TabIndex = 45;
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price.Location = new System.Drawing.Point(179, 243);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 35;
            this.Price.Text = "Price";
            // 
            // addBtn
            // 
            this.addBtn.Depth = 0;
            this.addBtn.Location = new System.Drawing.Point(430, 355);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Primary = true;
            this.addBtn.Size = new System.Drawing.Size(192, 33);
            this.addBtn.TabIndex = 46;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // brandBox
            // 
            this.brandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Items.AddRange(new object[] {
            "Allied",
            "Other"});
            this.brandBox.Location = new System.Drawing.Point(395, 150);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(227, 21);
            this.brandBox.TabIndex = 43;
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(395, 200);
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(227, 20);
            this.qtyUpDown.TabIndex = 47;
            this.qtyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qtyUpDown);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label Price;
        private MaterialSkin.Controls.MaterialRaisedButton addBtn;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
    }
}