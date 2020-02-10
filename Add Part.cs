using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Inventory_System
{
    public partial class Add_Part : Form
    {
        private TextBox MachineIdTextbox = new TextBox();
        private Label OutsourcedLabel = new Label();
        public Add_Part()
        {
            InitializeComponent();
           
        }

        private void Add_Part_Load(object sender, EventArgs e)
        {
            this.OutsourcedLabel.Text = "OutSourced ID";
            this.Controls.Add(OutsourcedLabel);
            OutsourcedLabel.Size = new Size(85, 13);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDTextBox.Text);
            string Name = NameTextBox.Text;
            decimal Price = decimal.Parse(PriceTextBox.Text);
            int InStock = int.Parse(InventoryTextBox.Text);
            int Max = int.Parse(MaxTextBox.Text);
            int Min = int.Parse(MinTextBox.Text);
            Inventory.AddPart(new Part(ID,Name,Price,InStock,Max,Min));
            Form.ActiveForm.Close();

        }
       
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OutsourcedLabel.Text = "Company Name:";     
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdTextbox.Size = new Size(100, 20);
            MachineIdTextbox.Location = new Point(137, 292);
            this.Controls.Add(MachineIdTextbox);
            OutsourcedLabel.Location = new Point(45, 292);
            OutsourcedLabel.Text = "Outsourced ID:";

        }

       
    }
}
