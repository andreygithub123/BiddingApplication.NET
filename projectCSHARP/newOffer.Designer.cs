namespace projectCSHARP
{
    partial class newOffer
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
            this.dataGridViewOffers = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOffer = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbOffer = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xMLSERIALIZATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDESERIALIZATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).BeginInit();
            this.gbOffer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOffers
            // 
            this.dataGridViewOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.offerColumn});
            this.dataGridViewOffers.Location = new System.Drawing.Point(449, 32);
            this.dataGridViewOffers.Name = "dataGridViewOffers";
            this.dataGridViewOffers.Size = new System.Drawing.Size(321, 346);
            this.dataGridViewOffers.TabIndex = 0;
            this.dataGridViewOffers.MouseLeave += new System.EventHandler(this.dataGridViewOffers_MouseLeave);
            this.dataGridViewOffers.MouseHover += new System.EventHandler(this.dataGridViewOffers_MouseHover);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "NAME";
            this.nameColumn.Name = "nameColumn";
            // 
            // offerColumn
            // 
            this.offerColumn.HeaderText = "OFFER ( $ )";
            this.offerColumn.Name = "offerColumn";
            // 
            // gbOffer
            // 
            this.gbOffer.Controls.Add(this.btAdd);
            this.gbOffer.Controls.Add(this.tbOffer);
            this.gbOffer.Controls.Add(this.tbName);
            this.gbOffer.Controls.Add(this.tbId);
            this.gbOffer.Controls.Add(this.label4);
            this.gbOffer.Controls.Add(this.label2);
            this.gbOffer.Controls.Add(this.label1);
            this.gbOffer.Location = new System.Drawing.Point(33, 32);
            this.gbOffer.Name = "gbOffer";
            this.gbOffer.Size = new System.Drawing.Size(394, 382);
            this.gbOffer.TabIndex = 1;
            this.gbOffer.TabStop = false;
            this.gbOffer.Text = "Offer Details";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(120, 269);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(135, 37);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseLeave += new System.EventHandler(this.btAdd_MouseLeave);
            this.btAdd.MouseHover += new System.EventHandler(this.btAdd_MouseHover);
            // 
            // tbOffer
            // 
            this.tbOffer.Location = new System.Drawing.Point(139, 203);
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.Size = new System.Drawing.Size(205, 20);
            this.tbOffer.TabIndex = 7;
            this.tbOffer.MouseLeave += new System.EventHandler(this.tbOffer_MouseLeave);
            this.tbOffer.MouseHover += new System.EventHandler(this.tbOffer_MouseHover);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 132);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 20);
            this.tbName.TabIndex = 5;
            this.tbName.MouseLeave += new System.EventHandler(this.tbName_MouseLeave);
            this.tbName.MouseHover += new System.EventHandler(this.tbName_MouseHover);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(139, 48);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(205, 20);
            this.tbId.TabIndex = 4;
            this.tbId.MouseLeave += new System.EventHandler(this.tbId_MouseLeave);
            this.tbId.MouseHover += new System.EventHandler(this.tbId_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Offer ( $ )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Offer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offer Id ";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(449, 400);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 26);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            this.btEdit.MouseLeave += new System.EventHandler(this.btEdit_MouseLeave);
            this.btEdit.MouseHover += new System.EventHandler(this.btEdit_MouseHover);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(676, 400);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 26);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            this.btDelete.MouseLeave += new System.EventHandler(this.btDelete_MouseLeave);
            this.btDelete.MouseHover += new System.EventHandler(this.btDelete_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLSERIALIZATIONToolStripMenuItem,
            this.xMLDESERIALIZATIONToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 48);
            // 
            // xMLSERIALIZATIONToolStripMenuItem
            // 
            this.xMLSERIALIZATIONToolStripMenuItem.Name = "xMLSERIALIZATIONToolStripMenuItem";
            this.xMLSERIALIZATIONToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.xMLSERIALIZATIONToolStripMenuItem.Text = "XML SERIALIZATION";
            this.xMLSERIALIZATIONToolStripMenuItem.Click += new System.EventHandler(this.xMLSERIALIZATIONToolStripMenuItem_Click);
            // 
            // xMLDESERIALIZATIONToolStripMenuItem
            // 
            this.xMLDESERIALIZATIONToolStripMenuItem.Name = "xMLDESERIALIZATIONToolStripMenuItem";
            this.xMLDESERIALIZATIONToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.xMLDESERIALIZATIONToolStripMenuItem.Text = "XML DESERIALIZATION";
            this.xMLDESERIALIZATIONToolStripMenuItem.Click += new System.EventHandler(this.xMLDESERIALIZATIONToolStripMenuItem_Click);
            // 
            // btXML
            // 
            this.btXML.Location = new System.Drawing.Point(565, 400);
            this.btXML.Name = "btXML";
            this.btXML.Size = new System.Drawing.Size(82, 26);
            this.btXML.TabIndex = 9;
            this.btXML.Text = "XML";
            this.btXML.UseVisualStyleBackColor = true;
            this.btXML.Click += new System.EventHandler(this.btXML_Click);
            this.btXML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btXML_KeyDown);
            this.btXML.MouseLeave += new System.EventHandler(this.btXML_MouseLeave);
            this.btXML.MouseHover += new System.EventHandler(this.btXML_MouseHover);
            // 
            // newOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btXML);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.gbOffer);
            this.Controls.Add(this.dataGridViewOffers);
            this.Name = "newOffer";
            this.Text = "newOffer";
            this.Load += new System.EventHandler(this.newOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).EndInit();
            this.gbOffer.ResumeLayout(false);
            this.gbOffer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOffers;
        private System.Windows.Forms.GroupBox gbOffer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerColumn;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbOffer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xMLSERIALIZATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDESERIALIZATIONToolStripMenuItem;
        private System.Windows.Forms.Button btXML;
    }
}