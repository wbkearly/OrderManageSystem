namespace OrderManagement
{
    partial class GoodsBrowseForm
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
            this.addGoodsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.goodsBrowseDataGridView = new System.Windows.Forms.DataGridView();
            this.goodsIdLabel = new System.Windows.Forms.Label();
            this.goodsIdTextBox = new System.Windows.Forms.TextBox();
            this.goodsDescLabel = new System.Windows.Forms.Label();
            this.goodsDescTextBox = new System.Windows.Forms.TextBox();
            this.orderNumLabel = new System.Windows.Forms.Label();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.shuaXinButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBrowseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addGoodsButton
            // 
            this.addGoodsButton.Location = new System.Drawing.Point(142, 427);
            this.addGoodsButton.Name = "addGoodsButton";
            this.addGoodsButton.Size = new System.Drawing.Size(137, 36);
            this.addGoodsButton.TabIndex = 0;
            this.addGoodsButton.Text = "添加进购物车";
            this.addGoodsButton.UseVisualStyleBackColor = true;
            this.addGoodsButton.Click += new System.EventHandler(this.addGoodsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(435, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 36);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goodsBrowseDataGridView
            // 
            this.goodsBrowseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsBrowseDataGridView.Location = new System.Drawing.Point(31, 26);
            this.goodsBrowseDataGridView.Name = "goodsBrowseDataGridView";
            this.goodsBrowseDataGridView.ReadOnly = true;
            this.goodsBrowseDataGridView.RowTemplate.Height = 27;
            this.goodsBrowseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsBrowseDataGridView.Size = new System.Drawing.Size(614, 275);
            this.goodsBrowseDataGridView.TabIndex = 2;
            this.goodsBrowseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsBrowseDataGridView_CellContentClick);
            // 
            // goodsIdLabel
            // 
            this.goodsIdLabel.AutoSize = true;
            this.goodsIdLabel.Location = new System.Drawing.Point(47, 354);
            this.goodsIdLabel.Name = "goodsIdLabel";
            this.goodsIdLabel.Size = new System.Drawing.Size(52, 15);
            this.goodsIdLabel.TabIndex = 3;
            this.goodsIdLabel.Text = "货物号";
            // 
            // goodsIdTextBox
            // 
            this.goodsIdTextBox.Location = new System.Drawing.Point(125, 349);
            this.goodsIdTextBox.Name = "goodsIdTextBox";
            this.goodsIdTextBox.ReadOnly = true;
            this.goodsIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.goodsIdTextBox.TabIndex = 4;
            // 
            // goodsDescLabel
            // 
            this.goodsDescLabel.AutoSize = true;
            this.goodsDescLabel.Location = new System.Drawing.Point(248, 354);
            this.goodsDescLabel.Name = "goodsDescLabel";
            this.goodsDescLabel.Size = new System.Drawing.Size(67, 15);
            this.goodsDescLabel.TabIndex = 5;
            this.goodsDescLabel.Text = "货物描述";
            // 
            // goodsDescTextBox
            // 
            this.goodsDescTextBox.Location = new System.Drawing.Point(321, 349);
            this.goodsDescTextBox.Name = "goodsDescTextBox";
            this.goodsDescTextBox.ReadOnly = true;
            this.goodsDescTextBox.Size = new System.Drawing.Size(100, 25);
            this.goodsDescTextBox.TabIndex = 6;
            // 
            // orderNumLabel
            // 
            this.orderNumLabel.AutoSize = true;
            this.orderNumLabel.Location = new System.Drawing.Point(444, 354);
            this.orderNumLabel.Name = "orderNumLabel";
            this.orderNumLabel.Size = new System.Drawing.Size(67, 15);
            this.orderNumLabel.TabIndex = 7;
            this.orderNumLabel.Text = "订货数量";
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(517, 349);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(100, 25);
            this.orderNumTextBox.TabIndex = 8;
            // 
            // shuaXinButton
            // 
            this.shuaXinButton.Location = new System.Drawing.Point(664, 26);
            this.shuaXinButton.Name = "shuaXinButton";
            this.shuaXinButton.Size = new System.Drawing.Size(75, 37);
            this.shuaXinButton.TabIndex = 9;
            this.shuaXinButton.Text = "刷新";
            this.shuaXinButton.UseVisualStyleBackColor = true;
            this.shuaXinButton.Click += new System.EventHandler(this.shuaXinButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(310, 427);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(100, 36);
            this.shopButton.TabIndex = 10;
            this.shopButton.Text = "查看购物车";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // GoodsBrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(780, 515);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.shuaXinButton);
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.orderNumLabel);
            this.Controls.Add(this.goodsDescTextBox);
            this.Controls.Add(this.goodsDescLabel);
            this.Controls.Add(this.goodsIdTextBox);
            this.Controls.Add(this.goodsIdLabel);
            this.Controls.Add(this.goodsBrowseDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addGoodsButton);
            this.Name = "GoodsBrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "货物浏览";
            this.Load += new System.EventHandler(this.GoodsBrowseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBrowseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGoodsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView goodsBrowseDataGridView;
        private System.Windows.Forms.Label goodsIdLabel;
        private System.Windows.Forms.TextBox goodsIdTextBox;
        private System.Windows.Forms.Label goodsDescLabel;
        private System.Windows.Forms.TextBox goodsDescTextBox;
        private System.Windows.Forms.Label orderNumLabel;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Button shuaXinButton;
        private System.Windows.Forms.Button shopButton;
    }
}