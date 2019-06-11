namespace OrderManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.salesmanRadioButton = new System.Windows.Forms.RadioButton();
            this.registerButton = new System.Windows.Forms.Button();
            this.userGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(162, 178);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(52, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "用户名";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(162, 240);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(37, 15);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "密码";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(253, 175);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(152, 25);
            this.userNameTextBox.TabIndex = 2;
            this.userNameToolTip.SetToolTip(this.userNameTextBox, "请输入数字，不超过10位");
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(253, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(152, 25);
            this.passwordTextBox.TabIndex = 3;
            this.passwordToolTip.SetToolTip(this.passwordTextBox, "请输入数字或字母，不超过14位");
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(139, 304);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(330, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // userNameToolTip
            // 
            this.userNameToolTip.AutoPopDelay = 5000;
            this.userNameToolTip.InitialDelay = 300;
            this.userNameToolTip.ReshowDelay = 500;
            this.userNameToolTip.ShowAlways = true;
            this.userNameToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // passwordToolTip
            // 
            this.passwordToolTip.AutoPopDelay = 5000;
            this.passwordToolTip.InitialDelay = 300;
            this.passwordToolTip.ReshowDelay = 500;
            this.passwordToolTip.ShowAlways = true;
            this.passwordToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(6, 7);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(58, 19);
            this.customerRadioButton.TabIndex = 6;
            this.customerRadioButton.Text = "客户";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.salesmanRadioButton);
            this.userGroupBox.Controls.Add(this.customerRadioButton);
            this.userGroupBox.Location = new System.Drawing.Point(177, 122);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(218, 32);
            this.userGroupBox.TabIndex = 7;
            this.userGroupBox.TabStop = false;
            // 
            // salesmanRadioButton
            // 
            this.salesmanRadioButton.AutoSize = true;
            this.salesmanRadioButton.Location = new System.Drawing.Point(88, 7);
            this.salesmanRadioButton.Name = "salesmanRadioButton";
            this.salesmanRadioButton.Size = new System.Drawing.Size(103, 19);
            this.salesmanRadioButton.TabIndex = 7;
            this.salesmanRadioButton.Text = "销售管理员";
            this.salesmanRadioButton.UseVisualStyleBackColor = true;
            this.salesmanRadioButton.CheckedChanged += new System.EventHandler(this.salesmanRadioButton_CheckedChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(233, 304);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 28);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订货管理系统-登录";
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip userNameToolTip;
        private System.Windows.Forms.ToolTip passwordToolTip;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.RadioButton salesmanRadioButton;
        private System.Windows.Forms.Button registerButton;
    }
}

