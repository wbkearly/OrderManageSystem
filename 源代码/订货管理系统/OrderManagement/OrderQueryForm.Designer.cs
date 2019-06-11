namespace OrderManagement
{
    partial class OrderQueryForm
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
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.orderQueryButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.inputOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(143, 84);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(67, 15);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "订单号：";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(143, 120);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(60, 15);
            this.customerIdLabel.TabIndex = 2;
            this.customerIdLabel.Text = "顾客号:";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(143, 182);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(52, 15);
            this.detailLabel.TabIndex = 4;
            this.detailLabel.Text = "详情：";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(143, 150);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(75, 15);
            this.CustomerNameLabel.TabIndex = 6;
            this.CustomerNameLabel.Text = "顾客姓名:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(288, 367);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 33);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "关闭";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(135, 41);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(165, 15);
            this.promptLabel.TabIndex = 8;
            this.promptLabel.Text = "请输入要查询的订单号:";
            // 
            // orderQueryButton
            // 
            this.orderQueryButton.Location = new System.Drawing.Point(455, 24);
            this.orderQueryButton.Name = "orderQueryButton";
            this.orderQueryButton.Size = new System.Drawing.Size(75, 37);
            this.orderQueryButton.TabIndex = 10;
            this.orderQueryButton.Text = "查询";
            this.orderQueryButton.UseVisualStyleBackColor = true;
            this.orderQueryButton.Click += new System.EventHandler(this.orderQueryButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(165, 367);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 33);
            this.dealButton.TabIndex = 11;
            this.dealButton.Text = "支付";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(216, 81);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ReadOnly = true;
            this.orderIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.orderIdTextBox.TabIndex = 12;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(218, 116);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.ReadOnly = true;
            this.customerIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.customerIdTextBox.TabIndex = 13;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(224, 147);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.customerNameTextBox.TabIndex = 14;
            // 
            // inputOrderIdTextBox
            // 
            this.inputOrderIdTextBox.Location = new System.Drawing.Point(315, 36);
            this.inputOrderIdTextBox.Name = "inputOrderIdTextBox";
            this.inputOrderIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.inputOrderIdTextBox.TabIndex = 15;
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(146, 200);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.RowTemplate.Height = 27;
            this.myDataGridView.Size = new System.Drawing.Size(316, 150);
            this.myDataGridView.TabIndex = 16;
            // 
            // OrderQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.inputOrderIdTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.orderQueryButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Name = "OrderQueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单详细信息查询";
            this.Load += new System.EventHandler(this.OrderQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button orderQueryButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox inputOrderIdTextBox;
        private System.Windows.Forms.DataGridView myDataGridView;

    }
}