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
    public partial class Modify_Part : Form
    {
        bool isInhouse;

        private void CheckRadioButton()
        {
            int number;
            if (string.IsNullOrWhiteSpace(TxtPartSource.Text) || (isInhouse && !Int32.TryParse(TxtPartSource.Text, out number)))
            {
                TxtPartSource.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TxtPartSource.BackColor = System.Drawing.Color.White;
            }
            
        }

        public Modify_Part()
        {
            
            InitializeComponent();
            TxtPartID.Text = Inventory.CurrentPart.PartID.ToString();
            TxtName.Text = Inventory.CurrentPart.Name;
            TxtInventory.Text = Inventory.CurrentPart.InStock.ToString();
            TxtPrice.Text = Inventory.CurrentPart.Price.ToString();
            TxtMin.Text = Inventory.CurrentPart.Min.ToString();
            TxtMax.Text = Inventory.CurrentPart.Max.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = Inventory.CurrentPart as Inhouse;
                TxtPartSource.Text = e.MachineID.ToString();
                isInhouse = true;
                InHouseRadio.Checked = true;
            }
            else
            {
                Outsourced e = Inventory.CurrentPart as Outsourced;
                TxtPartSource.Text = e.CompanyName;
                isInhouse = false;
                OutsourcedRadio.Checked = true;
                SourceLabel.Location = new Point(25, 298);
            }
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = "Company Name";
            SourceLabel.Location = new Point(25, 298);
            isInhouse = false;
            CheckRadioButton();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceLabel.Text = "Machine ID";
            isInhouse = true;
            CheckRadioButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInhouse == true)
                {
                    Part part = new Inhouse(Convert.ToInt32(TxtPartID.Text), TxtName.Text, Convert.ToInt32(TxtInventory.Text), Convert.ToDecimal(TxtPrice.Text),
                        Convert.ToInt32(TxtMin.Text), Convert.ToInt32(TxtMax.Text), Convert.ToInt32(TxtPartSource.Text));

                    Inventory.UpdatePart(Inventory.CurrentPartIndex, part);
                    Form.ActiveForm.Close();
                }
                else if (isInhouse == false)
                {
                    Part part = new Outsourced(Convert.ToInt32(TxtPartID.Text), TxtName.Text, Convert.ToInt32(TxtInventory.Text), Convert.ToDecimal(TxtPrice.Text),
                        Convert.ToInt32(TxtMin.Text), Convert.ToInt32(TxtMax.Text), TxtPartSource.Text);
                    Inventory.UpdatePart(Inventory.CurrentPartIndex, part);
                    Form.ActiveForm.Close();
                }
            }
            catch (FormatException FormatException) 
            {
                MessageBox.Show(FormatException.Message, "Format Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                TxtName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TxtName.BackColor = System.Drawing.Color.White;
            }
        }

        private void TxtInventory_TextChanged(object sender, EventArgs e)
        {
            
            if ( string.IsNullOrWhiteSpace(TxtInventory.Text))
            {
                TxtInventory.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                TxtInventory.BackColor = System.Drawing.Color.White;
            }
        }

        private void TxtPartSource_TextChanged(object sender, EventArgs e)
        {
            CheckRadioButton();
        }

       
    }
}
