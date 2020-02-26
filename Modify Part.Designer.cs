namespace BFM1_Inventory_System
{
    partial class Modify_Part
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
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.TxtMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtInventory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPartID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtPartSource = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(111, 26);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(211, 26);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // TxtMax
            // 
            this.TxtMax.Location = new System.Drawing.Point(224, 245);
            this.TxtMax.Name = "TxtMax";
            this.TxtMax.Size = new System.Drawing.Size(57, 20);
            this.TxtMax.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Max";
            // 
            // TxtMin
            // 
            this.TxtMin.Location = new System.Drawing.Point(111, 245);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(57, 20);
            this.TxtMin.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Min";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(111, 208);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtPrice.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Price / Cost";
            // 
            // TxtInventory
            // 
            this.TxtInventory.Location = new System.Drawing.Point(111, 169);
            this.TxtInventory.Name = "TxtInventory";
            this.TxtInventory.Size = new System.Drawing.Size(100, 20);
            this.TxtInventory.TabIndex = 24;
            this.TxtInventory.TextChanged += new System.EventHandler(this.TxtInventory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inventory";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 127);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 22;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // TxtPartID
            // 
            this.TxtPartID.Enabled = false;
            this.TxtPartID.Location = new System.Drawing.Point(111, 86);
            this.TxtPartID.Name = "TxtPartID";
            this.TxtPartID.ReadOnly = true;
            this.TxtPartID.Size = new System.Drawing.Size(100, 20);
            this.TxtPartID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(210, 342);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(43, 28);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPartSource
            // 
            this.TxtPartSource.Location = new System.Drawing.Point(111, 295);
            this.TxtPartSource.Name = "TxtPartSource";
            this.TxtPartSource.Size = new System.Drawing.Size(100, 20);
            this.TxtPartSource.TabIndex = 35;
            this.TxtPartSource.TextChanged += new System.EventHandler(this.TxtPartSource_TextChanged);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(32, 298);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(62, 13);
            this.SourceLabel.TabIndex = 36;
            this.SourceLabel.Text = "Machine ID";
            // 
            // Modify_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 382);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.TxtPartSource);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtInventory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPartID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.label1);
            this.Name = "Modify_Part";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.TextBox TxtMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPartID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtPartSource;
        private System.Windows.Forms.Label SourceLabel;
    }
}