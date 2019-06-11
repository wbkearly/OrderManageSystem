namespace OrderManagement
{
    partial class SalesmanForm
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.orderQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderQueryToolStripMenuItem,
            this.orderStatisticToolStripMenuItem,
            this.stockStatisticToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(728, 28);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // orderQueryToolStripMenuItem
            // 
            this.orderQueryToolStripMenuItem.Name = "orderQueryToolStripMenuItem";
            this.orderQueryToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.orderQueryToolStripMenuItem.Text = "订单查询";
            this.orderQueryToolStripMenuItem.Click += new System.EventHandler(this.orderQueryToolStripMenuItem_Click);
            // 
            // orderStatisticToolStripMenuItem
            // 
            this.orderStatisticToolStripMenuItem.Name = "orderStatisticToolStripMenuItem";
            this.orderStatisticToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.orderStatisticToolStripMenuItem.Text = "订单统计";
            this.orderStatisticToolStripMenuItem.Click += new System.EventHandler(this.orderStatisticToolStripMenuItem_Click);
            // 
            // stockStatisticToolStripMenuItem
            // 
            this.stockStatisticToolStripMenuItem.Name = "stockStatisticToolStripMenuItem";
            this.stockStatisticToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.stockStatisticToolStripMenuItem.Text = "库存统计";
            this.stockStatisticToolStripMenuItem.Click += new System.EventHandler(this.stockStatisticToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(627, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(486, 7);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 15);
            this.welcomeLabel.TabIndex = 6;
            // 
            // SalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(728, 451);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "SalesmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售管理员";
            this.Load += new System.EventHandler(this.SalesmanForm_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem orderQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockStatisticToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}