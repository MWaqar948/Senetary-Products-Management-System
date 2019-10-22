namespace Project
{
    partial class Brand
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
            this.brandDetail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideBarPanel.Controls.Add(this.brandDetail);
            this.sideBarPanel.Controls.Add(this.addBtn);
            this.sideBarPanel.Controls.Add(this.deleteBtn);
            this.sideBarPanel.Location = new System.Drawing.Point(0, 64);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 470);
            this.sideBarPanel.TabIndex = 1;
            // 
            // brandDetail
            // 
            this.brandDetail.Depth = 0;
            this.brandDetail.Location = new System.Drawing.Point(4, 236);
            this.brandDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.brandDetail.Name = "brandDetail";
            this.brandDetail.Primary = true;
            this.brandDetail.Size = new System.Drawing.Size(192, 33);
            this.brandDetail.TabIndex = 6;
            this.brandDetail.Text = "Brand Details";
            this.brandDetail.UseVisualStyleBackColor = true;
            this.brandDetail.Click += new System.EventHandler(this.categoryDetail_Click);
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
            this.addBtn.Text = "Add Brand";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Depth = 0;
            this.deleteBtn.Location = new System.Drawing.Point(5, 173);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Primary = true;
            this.deleteBtn.Size = new System.Drawing.Size(192, 33);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete Brand";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 388);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Depth = 0;
            this.refreshBtn.Location = new System.Drawing.Point(707, 100);
            this.refreshBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Primary = true;
            this.refreshBtn.Size = new System.Drawing.Size(136, 33);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Depth = 0;
            this.searchBtn.Location = new System.Drawing.Point(544, 100);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Primary = true;
            this.searchBtn.Size = new System.Drawing.Size(141, 33);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(206, 108);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(320, 20);
            this.nameTxt.TabIndex = 14;
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sideBarPanel);
            this.MaximizeBox = false;
            this.Name = "Brand";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_Load);
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private MaterialSkin.Controls.MaterialRaisedButton brandDetail;
        private MaterialSkin.Controls.MaterialRaisedButton addBtn;
        private MaterialSkin.Controls.MaterialRaisedButton deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton refreshBtn;
        private MaterialSkin.Controls.MaterialRaisedButton searchBtn;
        private System.Windows.Forms.TextBox nameTxt;
    }
}