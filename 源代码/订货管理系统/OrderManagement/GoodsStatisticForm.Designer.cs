namespace OrderManagement
{
    partial class GoodsStatisticForm
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
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            this.shuaXinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(21, 24);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.RowTemplate.Height = 27;
            this.myDataGridView.Size = new System.Drawing.Size(419, 254);
            this.myDataGridView.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(262, 322);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 40);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // shuaXinButton
            // 
            this.shuaXinButton.Location = new System.Drawing.Point(132, 322);
            this.shuaXinButton.Name = "shuaXinButton";
            this.shuaXinButton.Size = new System.Drawing.Size(84, 40);
            this.shuaXinButton.TabIndex = 2;
            this.shuaXinButton.Text = "刷新";
            this.shuaXinButton.UseVisualStyleBackColor = true;
            this.shuaXinButton.Click += new System.EventHandler(this.shuaXinButton_Click);
            // 
            // GoodsStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(548, 397);
            this.Controls.Add(this.shuaXinButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.myDataGridView);
            this.Name = "GoodsStatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看库存信息";
            this.Load += new System.EventHandler(this.GoodsStatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button shuaXinButton;
    }
}