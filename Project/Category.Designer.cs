namespace Project
{
    partial class Category
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryDetail = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.sideBarPanel.Controls.Add(this.materialRaisedButton1);
            this.sideBarPanel.Controls.Add(this.categoryDetail);
            this.sideBarPanel.Controls.Add(this.addBtn);
            this.sideBarPanel.Controls.Add(this.deleteBtn);
            this.sideBarPanel.Location = new System.Drawing.Point(0, 64);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 471);
            this.sideBarPanel.TabIndex = 1;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(4, 185);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(192, 33);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Update Category";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // categoryDetail
            // 
            this.categoryDetail.Depth = 0;
            this.categoryDetail.Location = new System.Drawing.Point(4, 309);
            this.categoryDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryDetail.Name = "categoryDetail";
            this.categoryDetail.Primary = true;
            this.categoryDetail.Size = new System.Drawing.Size(192, 33);
            this.categoryDetail.TabIndex = 6;
            this.categoryDetail.Text = "Category Details";
            this.categoryDetail.UseVisualStyleBackColor = true;
            this.categoryDetail.Click += new System.EventHandler(this.categoryDetail_Click);
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
            this.addBtn.Text = "Add Category";
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
            this.deleteBtn.Text = "Delete Category";
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
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton categoryDetail;
        private MaterialSkin.Controls.MaterialRaisedButton addBtn;
        private MaterialSkin.Controls.MaterialRaisedButton deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}