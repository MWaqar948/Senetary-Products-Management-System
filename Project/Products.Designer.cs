namespace Project
{
    partial class Products
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.productUpdateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.detailBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideBarPanel.Controls.Add(this.productUpdateBtn);
            this.sideBarPanel.Controls.Add(this.detailBtn);
            this.sideBarPanel.Controls.Add(this.addBtn);
            this.sideBarPanel.Controls.Add(this.deleteBtn);
            this.sideBarPanel.Location = new System.Drawing.Point(0, 64);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 471);
            this.sideBarPanel.TabIndex = 1;
            // 
            // productUpdateBtn
            // 
            this.productUpdateBtn.Depth = 0;
            this.productUpdateBtn.Location = new System.Drawing.Point(4, 185);
            this.productUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.productUpdateBtn.Name = "productUpdateBtn";
            this.productUpdateBtn.Primary = true;
            this.productUpdateBtn.Size = new System.Drawing.Size(192, 33);
            this.productUpdateBtn.TabIndex = 7;
            this.productUpdateBtn.Text = "Update Product";
            this.productUpdateBtn.UseVisualStyleBackColor = true;
            this.productUpdateBtn.Click += new System.EventHandler(this.productUpdateBtn_Click);
            // 
            // detailBtn
            // 
            this.detailBtn.Depth = 0;
            this.detailBtn.Location = new System.Drawing.Point(4, 309);
            this.detailBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Primary = true;
            this.detailBtn.Size = new System.Drawing.Size(192, 33);
            this.detailBtn.TabIndex = 6;
            this.detailBtn.Text = "Product Details";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Depth = 0;
            this.addBtn.Location = new System.Drawing.Point(4, 115);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Primary = true;
            this.addBtn.Size = new System.Drawing.Size(192, 33);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Depth = 0;
            this.deleteBtn.Location = new System.Drawing.Point(4, 248);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Primary = true;
            this.deleteBtn.Size = new System.Drawing.Size(192, 33);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Product";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 471);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private MaterialSkin.Controls.MaterialRaisedButton productUpdateBtn;
        private MaterialSkin.Controls.MaterialRaisedButton detailBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addBtn;
        private MaterialSkin.Controls.MaterialRaisedButton deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}