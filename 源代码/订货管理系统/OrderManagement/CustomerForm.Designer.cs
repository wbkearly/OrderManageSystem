namespace OrderManagement
{
    partial class CustomerForm
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
            this.goodsBrowseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wecomeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsBrowseToolStripMenuItem,
            this.myOrderToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.selfCenterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goodsBrowseToolStripMenuItem
            // 
            this.goodsBrowseToolStripMenuItem.Name = "goodsBrowseToolStripMenuItem";
            this.goodsBrowseToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.goodsBrowseToolStripMenuItem.Text = "货物浏览";
            this.goodsBrowseToolStripMenuItem.Click += new System.EventHandler(this.goodsBrowseToolStripMenuItem_Click);
            // 
            // myOrderToolStripMenuItem
            // 
            this.myOrderToolStripMenuItem.Name = "myOrderToolStripMenuItem";
            this.myOrderToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.myOrderToolStripMenuItem.Text = "我的订单";
            this.myOrderToolStripMenuItem.Click += new System.EventHandler(this.myOrderToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.depositToolStripMenuItem.Text = "充值";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // selfCenterToolStripMenuItem
            // 
            this.selfCenterToolStripMenuItem.Name = "selfCenterToolStripMenuItem";
            this.selfCenterToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.selfCenterToolStripMenuItem.Text = "个人中心";
            this.selfCenterToolStripMenuItem.Click += new System.EventHandler(this.selfCenterToolStripMenuItem_Click);
            // 
            // wecomeLabel
            // 
            this.wecomeLabel.AutoSize = true;
            this.wecomeLabel.Location = new System.Drawing.Point(547, 9);
            this.wecomeLabel.Name = "wecomeLabel";
            this.wecomeLabel.Size = new System.Drawing.Size(0, 15);
            this.wecomeLabel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(678, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wecomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户服务中心";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goodsBrowseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfCenterToolStripMenuItem;
        private System.Windows.Forms.Label wecomeLabel;
        private System.Windows.Forms.Button exitButton;
    }
}