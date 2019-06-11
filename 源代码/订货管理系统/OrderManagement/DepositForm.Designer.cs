namespace OrderManagement
{
    partial class DepositForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.showCurrentBalanceLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(83, 184);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(103, 68);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(75, 15);
            this.currentBalanceLabel.TabIndex = 2;
            this.currentBalanceLabel.Text = "当前余额:";
            // 
            // showCurrentBalanceLabel
            // 
            this.showCurrentBalanceLabel.AutoSize = true;
            this.showCurrentBalanceLabel.Location = new System.Drawing.Point(186, 68);
            this.showCurrentBalanceLabel.Name = "showCurrentBalanceLabel";
            this.showCurrentBalanceLabel.Size = new System.Drawing.Size(55, 15);
            this.showCurrentBalanceLabel.TabIndex = 3;
            this.showCurrentBalanceLabel.Text = "label2";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(103, 107);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(75, 15);
            this.depositLabel.TabIndex = 4;
            this.depositLabel.Text = "充值金额:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(184, 104);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 25);
            this.depositTextBox.TabIndex = 5;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(404, 272);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.showCurrentBalanceLabel);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充值";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Label showCurrentBalanceLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.TextBox depositTextBox;
    }
}