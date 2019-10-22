namespace Project
{
    partial class AddBrand
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addBrandBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(179, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(395, 149);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(227, 20);
            this.nameTxt.TabIndex = 45;
            // 
            // addBrandBtn
            // 
            this.addBrandBtn.Depth = 0;
            this.addBrandBtn.Location = new System.Drawing.Point(458, 317);
            this.addBrandBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBrandBtn.Name = "addBrandBtn";
            this.addBrandBtn.Primary = true;
            this.addBrandBtn.Size = new System.Drawing.Size(192, 33);
            this.addBrandBtn.TabIndex = 46;
            this.addBrandBtn.Text = "Add Brand";
            this.addBrandBtn.UseVisualStyleBackColor = true;
            this.addBrandBtn.Click += new System.EventHandler(this.addBrandBtn_Click);
            // 
            // AddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBrandBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddBrand";
            this.Text = "Add Brand";
            this.Load += new System.EventHandler(this.AddBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private MaterialSkin.Controls.MaterialRaisedButton addBrandBtn;
    }
}