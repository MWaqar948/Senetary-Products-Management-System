namespace Project
{
    partial class UpdateProduct
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
            this.components = new System.ComponentModel.Container();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.updateProductBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.priceText = new System.Windows.Forms.TextBox();
            this.productBrandBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.database1DataSet = new Project.Database1DataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project.Database1DataSetTableAdapters.CategoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(395, 209);
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(227, 20);
            this.qtyUpDown.TabIndex = 56;
            this.qtyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Depth = 0;
            this.updateProductBtn.Location = new System.Drawing.Point(430, 364);
            this.updateProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Primary = true;
            this.updateProductBtn.Size = new System.Drawing.Size(192, 33);
            this.updateProductBtn.TabIndex = 55;
            this.updateProductBtn.Text = "Update Product";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(395, 254);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(227, 20);
            this.priceText.TabIndex = 54;
            // 
            // productBrandBox
            // 
            this.productBrandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBrandBox.FormattingEnabled = true;
            this.productBrandBox.Items.AddRange(new object[] {
            "Allied",
            "Other"});
            this.productBrandBox.Location = new System.Drawing.Point(395, 159);
            this.productBrandBox.Name = "productBrandBox";
            this.productBrandBox.Size = new System.Drawing.Size(227, 21);
            this.productBrandBox.TabIndex = 52;
            // 
            // nameBox
            // 
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "Pipe",
            "Gas Pipe"});
            this.nameBox.Location = new System.Drawing.Point(395, 109);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(227, 21);
            this.nameBox.TabIndex = 53;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price.Location = new System.Drawing.Point(179, 252);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 50;
            this.Price.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(179, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(179, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(179, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.database1DataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "label1";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyUpDown);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.productBrandBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "UpdateProduct";
            this.Sizable = false;
            this.Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private MaterialSkin.Controls.MaterialRaisedButton updateProductBtn;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.ComboBox productBrandBox;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Database1DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}