namespace projectCSHARP
{
    partial class BindingOffer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOffer = new System.Windows.Forms.TextBox();
            this.dataGridViewOffers2 = new System.Windows.Forms.DataGridView();
            this.btBindingAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OFFER ( $ )";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(155, 47);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(219, 20);
            this.tbId.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(155, 90);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbOffer
            // 
            this.tbOffer.Location = new System.Drawing.Point(155, 135);
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.Size = new System.Drawing.Size(219, 20);
            this.tbOffer.TabIndex = 5;
            // 
            // dataGridViewOffers2
            // 
            this.dataGridViewOffers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffers2.Location = new System.Drawing.Point(438, 27);
            this.dataGridViewOffers2.Name = "dataGridViewOffers2";
            this.dataGridViewOffers2.Size = new System.Drawing.Size(321, 280);
            this.dataGridViewOffers2.TabIndex = 6;
            // 
            // btBindingAdd
            // 
            this.btBindingAdd.Location = new System.Drawing.Point(118, 234);
            this.btBindingAdd.Name = "btBindingAdd";
            this.btBindingAdd.Size = new System.Drawing.Size(150, 37);
            this.btBindingAdd.TabIndex = 7;
            this.btBindingAdd.Text = "Binding Add";
            this.btBindingAdd.UseVisualStyleBackColor = true;
            this.btBindingAdd.Click += new System.EventHandler(this.btBindingAdd_Click);
            // 
            // BindingOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBindingAdd);
            this.Controls.Add(this.dataGridViewOffers2);
            this.Controls.Add(this.tbOffer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BindingOffer";
            this.Text = "BindingOffer";
            this.Load += new System.EventHandler(this.BindingOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOffer;
        private System.Windows.Forms.DataGridView dataGridViewOffers2;
        private System.Windows.Forms.Button btBindingAdd;
    }
}