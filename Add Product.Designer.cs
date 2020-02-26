namespace BFM1_Inventory_System
{
    partial class Add_Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.AllPartsGridView = new System.Windows.Forms.DataGridView();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InStockTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.AllPartsSearchBtn = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AllPartsAddBtn = new System.Windows.Forms.Button();
            this.ProdSaveBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AssociatedDeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // AllPartsGridView
            // 
            this.AllPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsGridView.Location = new System.Drawing.Point(316, 76);
            this.AllPartsGridView.Name = "AllPartsGridView";
            this.AllPartsGridView.ReadOnly = true;
            this.AllPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsGridView.Size = new System.Drawing.Size(440, 140);
            this.AllPartsGridView.TabIndex = 1;
            this.AllPartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPartsGridView_CellClick);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(223, 288);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(57, 20);
            this.MinTextBox.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Max";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(110, 288);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.MaxTextBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Min";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(110, 251);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Price / Cost";
            // 
            // InStockTextBox
            // 
            this.InStockTextBox.Location = new System.Drawing.Point(110, 212);
            this.InStockTextBox.Name = "InStockTextBox";
            this.InStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.InStockTextBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Inventory";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(110, 170);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(110, 129);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID";
            // 
            // AssociatedPartsGridView
            // 
            this.AssociatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssociatedPartsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsGridView.Location = new System.Drawing.Point(316, 271);
            this.AssociatedPartsGridView.Name = "AssociatedPartsGridView";
            this.AssociatedPartsGridView.ReadOnly = true;
            this.AssociatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsGridView.Size = new System.Drawing.Size(440, 118);
            this.AssociatedPartsGridView.TabIndex = 43;
            this.AssociatedPartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsGridView_CellClick);
            // 
            // AllPartsSearchBtn
            // 
            this.AllPartsSearchBtn.Location = new System.Drawing.Point(505, 33);
            this.AllPartsSearchBtn.Name = "AllPartsSearchBtn";
            this.AllPartsSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.AllPartsSearchBtn.TabIndex = 44;
            this.AllPartsSearchBtn.Text = "Search";
            this.AllPartsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(597, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Parts Associated this Product";
            // 
            // AllPartsAddBtn
            // 
            this.AllPartsAddBtn.Location = new System.Drawing.Point(701, 222);
            this.AllPartsAddBtn.Name = "AllPartsAddBtn";
            this.AllPartsAddBtn.Size = new System.Drawing.Size(55, 33);
            this.AllPartsAddBtn.TabIndex = 48;
            this.AllPartsAddBtn.Text = "Add";
            this.AllPartsAddBtn.UseVisualStyleBackColor = true;
            this.AllPartsAddBtn.Click += new System.EventHandler(this.AllPartsAddBtn_Click);
            // 
            // ProdSaveBtn
            // 
            this.ProdSaveBtn.Location = new System.Drawing.Point(677, 448);
            this.ProdSaveBtn.Name = "ProdSaveBtn";
            this.ProdSaveBtn.Size = new System.Drawing.Size(43, 28);
            this.ProdSaveBtn.TabIndex = 50;
            this.ProdSaveBtn.Text = "Save";
            this.ProdSaveBtn.UseVisualStyleBackColor = true;
            this.ProdSaveBtn.Click += new System.EventHandler(this.ProdSaveBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 28);
            this.button4.TabIndex = 49;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AssociatedDeleteBtn
            // 
            this.AssociatedDeleteBtn.Location = new System.Drawing.Point(701, 393);
            this.AssociatedDeleteBtn.Name = "AssociatedDeleteBtn";
            this.AssociatedDeleteBtn.Size = new System.Drawing.Size(55, 33);
            this.AssociatedDeleteBtn.TabIndex = 51;
            this.AssociatedDeleteBtn.Text = "Delete";
            this.AssociatedDeleteBtn.UseVisualStyleBackColor = true;
            this.AssociatedDeleteBtn.Click += new System.EventHandler(this.AssociatedDeleteBtn_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.AssociatedDeleteBtn);
            this.Controls.Add(this.ProdSaveBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AllPartsAddBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.AllPartsSearchBtn);
            this.Controls.Add(this.AssociatedPartsGridView);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InStockTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllPartsGridView);
            this.Controls.Add(this.label1);
            this.Name = "Add_Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllPartsGridView;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InStockTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AssociatedPartsGridView;
        private System.Windows.Forms.Button AllPartsSearchBtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AllPartsAddBtn;
        private System.Windows.Forms.Button ProdSaveBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AssociatedDeleteBtn;
    }
}