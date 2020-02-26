namespace BFM1_Inventory_System
{
    partial class MainScreen
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PartsGridView = new System.Windows.Forms.DataGridView();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModPartBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.ProdModBtn = new System.Windows.Forms.Button();
            this.ProdDeleteBtn = new System.Windows.Forms.Button();
            this.ProdSearchBox = new System.Windows.Forms.TextBox();
            this.ProdSearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(241, 59);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(66, 20);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management System";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(418, 267);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(50, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PartsGridView
            // 
            this.PartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGridView.Location = new System.Drawing.Point(28, 111);
            this.PartsGridView.Name = "PartsGridView";
            this.PartsGridView.ReadOnly = true;
            this.PartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsGridView.Size = new System.Drawing.Size(443, 150);
            this.PartsGridView.TabIndex = 5;
            this.PartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsGridView_CellClick);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Location = new System.Drawing.Point(890, 339);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(56, 23);
            this.Exit_Btn.TabIndex = 7;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(334, 59);
            this.SearchTxtBox.Multiline = true;
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(134, 20);
            this.SearchTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parts";
            // 
            // ModPartBtn
            // 
            this.ModPartBtn.Location = new System.Drawing.Point(362, 267);
            this.ModPartBtn.Name = "ModPartBtn";
            this.ModPartBtn.Size = new System.Drawing.Size(50, 23);
            this.ModPartBtn.TabIndex = 10;
            this.ModPartBtn.Text = "Modify";
            this.ModPartBtn.UseVisualStyleBackColor = true;
            this.ModPartBtn.Click += new System.EventHandler(this.ModPartBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Location = new System.Drawing.Point(785, 267);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(50, 23);
            this.ProductAddBtn.TabIndex = 14;
            this.ProductAddBtn.Text = "Add";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // ProdModBtn
            // 
            this.ProdModBtn.Location = new System.Drawing.Point(841, 267);
            this.ProdModBtn.Name = "ProdModBtn";
            this.ProdModBtn.Size = new System.Drawing.Size(50, 23);
            this.ProdModBtn.TabIndex = 13;
            this.ProdModBtn.Text = "Modify";
            this.ProdModBtn.UseVisualStyleBackColor = true;
            this.ProdModBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProdDeleteBtn
            // 
            this.ProdDeleteBtn.Location = new System.Drawing.Point(896, 267);
            this.ProdDeleteBtn.Name = "ProdDeleteBtn";
            this.ProdDeleteBtn.Size = new System.Drawing.Size(50, 23);
            this.ProdDeleteBtn.TabIndex = 12;
            this.ProdDeleteBtn.Text = "Delete";
            this.ProdDeleteBtn.UseVisualStyleBackColor = true;
            this.ProdDeleteBtn.Click += new System.EventHandler(this.ProdDeleteBtn_Click);
            // 
            // ProdSearchBox
            // 
            this.ProdSearchBox.Location = new System.Drawing.Point(812, 59);
            this.ProdSearchBox.Multiline = true;
            this.ProdSearchBox.Name = "ProdSearchBox";
            this.ProdSearchBox.Size = new System.Drawing.Size(134, 20);
            this.ProdSearchBox.TabIndex = 16;
            // 
            // ProdSearchBtn
            // 
            this.ProdSearchBtn.Location = new System.Drawing.Point(720, 58);
            this.ProdSearchBtn.Name = "ProdSearchBtn";
            this.ProdSearchBtn.Size = new System.Drawing.Size(66, 20);
            this.ProdSearchBtn.TabIndex = 17;
            this.ProdSearchBtn.Text = "Search";
            this.ProdSearchBtn.UseVisualStyleBackColor = true;
            this.ProdSearchBtn.Click += new System.EventHandler(this.ProdSearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Products";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowDrop = true;
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(506, 112);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGridView.Size = new System.Drawing.Size(446, 150);
            this.ProductsGridView.TabIndex = 19;
            this.ProductsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 375);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProdSearchBtn);
            this.Controls.Add(this.ProdSearchBox);
            this.Controls.Add(this.ProductAddBtn);
            this.Controls.Add(this.ProdModBtn);
            this.Controls.Add(this.ProdDeleteBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ModPartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.PartsGridView);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModPartBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ProductAddBtn;
        private System.Windows.Forms.Button ProdModBtn;
        private System.Windows.Forms.Button ProdDeleteBtn;
        private System.Windows.Forms.TextBox ProdSearchBox;
        private System.Windows.Forms.Button ProdSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductsGridView;
        public System.Windows.Forms.DataGridView PartsGridView;
    }
}

