namespace projectCSHARP
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBidderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.offerToolStripMenuItem,
            this.auctionToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBidderToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newBidderToolStripMenuItem
            // 
            this.newBidderToolStripMenuItem.Name = "newBidderToolStripMenuItem";
            this.newBidderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newBidderToolStripMenuItem.Text = "New Bidder";
            this.newBidderToolStripMenuItem.Click += new System.EventHandler(this.newBidderToolStripMenuItem_Click);
            // 
            // offerToolStripMenuItem
            // 
            this.offerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOfferToolStripMenuItem,
            this.bindingOfferToolStripMenuItem});
            this.offerToolStripMenuItem.Name = "offerToolStripMenuItem";
            this.offerToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.offerToolStripMenuItem.Text = "Offer";
            // 
            // newOfferToolStripMenuItem
            // 
            this.newOfferToolStripMenuItem.Name = "newOfferToolStripMenuItem";
            this.newOfferToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newOfferToolStripMenuItem.Text = "New Offer";
            this.newOfferToolStripMenuItem.Click += new System.EventHandler(this.newOfferToolStripMenuItem_Click);
            // 
            // bindingOfferToolStripMenuItem
            // 
            this.bindingOfferToolStripMenuItem.Name = "bindingOfferToolStripMenuItem";
            this.bindingOfferToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bindingOfferToolStripMenuItem.Text = "Binding Offer";
            this.bindingOfferToolStripMenuItem.Click += new System.EventHandler(this.bindingOfferToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // auctionToolStripMenuItem
            // 
            this.auctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAuctionToolStripMenuItem});
            this.auctionToolStripMenuItem.Name = "auctionToolStripMenuItem";
            this.auctionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.auctionToolStripMenuItem.Text = "Auction";
            // 
            // newAuctionToolStripMenuItem
            // 
            this.newAuctionToolStripMenuItem.Name = "newAuctionToolStripMenuItem";
            this.newAuctionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAuctionToolStripMenuItem.Text = "New Auction";
            this.newAuctionToolStripMenuItem.Click += new System.EventHandler(this.newAuctionToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBidderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindingOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAuctionToolStripMenuItem;
    }
}