namespace OrderManagement
{
    partial class SelfCenterForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.showUserNameLabel = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.showBalanceLabel = new System.Windows.Forms.Label();
            this.xinYuLabel = new System.Windows.Forms.Label();
            this.xinYuRichTextBox = new System.Windows.Forms.RichTextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(124, 74);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(67, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "用户名：";
            // 
            // showUserNameLabel
            // 
            this.showUserNameLabel.AutoSize = true;
            this.showUserNameLabel.Location = new System.Drawing.Point(197, 74);
            this.showUserNameLabel.Name = "showUserNameLabel";
            this.showUserNameLabel.Size = new System.Drawing.Size(55, 15);
            this.showUserNameLabel.TabIndex = 1;
            this.showUserNameLabel.Text = "label1";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(124, 109);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(82, 15);
            this.nameLable.TabIndex = 2;
            this.nameLable.Text = "真实姓名：";
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Location = new System.Drawing.Point(212, 109);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(55, 15);
            this.showNameLabel.TabIndex = 3;
            this.showNameLabel.Text = "label1";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(124, 145);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(52, 15);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "余额：";
            // 
            // showBalanceLabel
            // 
            this.showBalanceLabel.AutoSize = true;
            this.showBalanceLabel.Location = new System.Drawing.Point(182, 145);
            this.showBalanceLabel.Name = "showBalanceLabel";
            this.showBalanceLabel.Size = new System.Drawing.Size(55, 15);
            this.showBalanceLabel.TabIndex = 5;
            this.showBalanceLabel.Text = "label1";
            // 
            // xinYuLabel
            // 
            this.xinYuLabel.AutoSize = true;
            this.xinYuLabel.Location = new System.Drawing.Point(124, 183);
            this.xinYuLabel.Name = "xinYuLabel";
            this.xinYuLabel.Size = new System.Drawing.Size(75, 15);
            this.xinYuLabel.TabIndex = 6;
            this.xinYuLabel.Text = "信誉状况:";
            // 
            // xinYuRichTextBox
            // 
            this.xinYuRichTextBox.Location = new System.Drawing.Point(205, 183);
            this.xinYuRichTextBox.Name = "xinYuRichTextBox";
            this.xinYuRichTextBox.ReadOnly = true;
            this.xinYuRichTextBox.Size = new System.Drawing.Size(194, 96);
            this.xinYuRichTextBox.TabIndex = 8;
            this.xinYuRichTextBox.Text = "";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(131, 345);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(91, 36);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "修改密码";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(290, 345);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 36);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(324, 132);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 41);
            this.depositButton.TabIndex = 11;
            this.depositButton.Text = "充值";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // SelfCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 471);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.xinYuRichTextBox);
            this.Controls.Add(this.xinYuLabel);
            this.Controls.Add(this.showBalanceLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.showNameLabel);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.showUserNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "SelfCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人中心";
            this.Load += new System.EventHandler(this.SelfCenterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label showUserNameLabel;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label showNameLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label showBalanceLabel;
        private System.Windows.Forms.Label xinYuLabel;
        private System.Windows.Forms.RichTextBox xinYuRichTextBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button depositButton;
    }
}