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
        bool isInhouse;
        public Add_Part()
        {
            InitializeComponent();

           
        }

        private void CheckRadioButton()
        {
            int number;
            if (string.IsNullOrWhiteSpace(PartSourceTxt.Text) || (isInhouse && !Int32.TryParse(PartSourceTxt.Text, out number)))
            {
                PartSourceTxt.BackColor = System.Drawing.Color.Salmon;
              
            }
            else
            {
                PartSourceTxt.BackColor = System.Drawing.Color.White;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
  
        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = "Company Name";
            this.SourceLabel.Location = new Point(50, 291);
            isInhouse = false;
            CheckRadioButton();
        }
        
       private void InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = "Machine ID";
            isInhouse = true;
            CheckRadioButton();
        }
        public void Save(object sender, EventArgs e)
        {
            
            if (isInhouse)
            {
                
                string Name = NameTextBox.Text;
                decimal Price = decimal.Parse(PriceTextBox.Text);
                int InStock = int.Parse(InventoryTextBox.Text);
                int Max = int.Parse(MaxTextBox.Text);
                int Min = int.Parse(MinTextBox.Text);
                int MachineID = int.Parse(PartSourceTxt.Text);       
                List.AllParts.Add(new Inhouse(Name,InStock,Price,Min,Max,MachineID));
                Form.ActiveForm.Close();
            } 
            else
            {
                
                string Name = NameTextBox.Text;
                int InStock = int.Parse(InventoryTextBox.Text);
                decimal Price = decimal.Parse(PriceTextBox.Text);
                int Max = int.Parse(MaxTextBox.Text);
                int Min = int.Parse(MinTextBox.Text);
                string CompanyName = PartSourceTxt.Text;
                List.AllParts.Add(new Outsourced( Name, InStock, Price, Min, Max, CompanyName));
                Form.ActiveForm.Close();
            }

        }

    }
}
