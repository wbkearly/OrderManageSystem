namespace OrderManagement
{
    partial class ShoppingCart
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.goodsIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.goodsDescColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.goodsAmountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.goodsIdColumnHeader,
            this.goodsDescColumnHeader,
            this.priceColumnHeader,
            this.numColumnHeader,
            this.goodsAmountColumnHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // goodsIdColumnHeader
            // 
            this.goodsIdColumnHeader.Text = "货物号";
            // 
            // goodsDescColumnHeader
            // 
            this.goodsDescColumnHeader.Text = "货物描述";
            this.goodsDescColumnHeader.Width = 78;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "单价";
            this.priceColumnHeader.Width = 64;
            // 
            // numColumnHeader
            // 
            this.numColumnHeader.Text = "订货数目";
            this.numColumnHeader.Width = 84;
            // 
            // goodsAmountColumnHeader
            // 
            this.goodsAmountColumnHeader.Text = "总金额";
            this.goodsAmountColumnHeader.Width = 73;
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Location = new System.Drawing.Point(23, 26);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(60, 15);
            this.shoppingCartLabel.TabIndex = 1;
            this.shoppingCartLabel.Text = "购物车:";
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(87, 330);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(75, 31);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "下单";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(258, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 31);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(492, 390);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.listView1);
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的购物车";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader goodsIdColumnHeader;
        private System.Windows.Forms.ColumnHeader goodsDescColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.ColumnHeader numColumnHeader;
        private System.Windows.Forms.ColumnHeader goodsAmountColumnHeader;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
    }
}