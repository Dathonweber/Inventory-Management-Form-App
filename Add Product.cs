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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
            AssociatedPartsGridView.DataSource = Product.AssociatedParts;
            AllPartsGridView.DataSource = List.AllParts;
            AllPartsGridView.DefaultCellStyle.SelectionBackColor = AllPartsGridView.DefaultCellStyle.BackColor;
            AllPartsGridView.DefaultCellStyle.SelectionForeColor = AllPartsGridView.DefaultCellStyle.ForeColor;
            AllPartsGridView.AutoGenerateColumns = false;
            AllPartsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            AllPartsGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            AllPartsGridView.RowHeadersVisible = false;
            
        }

        private void ProdSaveBtn_Click(object sender, EventArgs e)
        {
            String Name = NameTextBox.Text;
            int Instock = int.Parse(InStockTextBox.Text);
            decimal Price = Decimal.Parse(PriceTextBox.Text);
            int Min = int.Parse(MinTextBox.Text);
            int Max = int.Parse(MaxTextBox.Text);
            Inventory.AddProduct(new Product(Name, Instock, Price, Min, Max));
            Form.ActiveForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void AllPartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Product.lookupAssociatedPart(Inventory.CurrentPartIndex);
            AllPartsGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        private void AssociatedDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentPartIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this Part?", "Remove Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Product.removeAssociatedPart(Inventory.CurrentPartIndex);
                }
            }
            else
            {
                MessageBox.Show("Please Select Something");
            }
        }

        private void AssociatedPartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Product.lookupAssociatedPart(Inventory.CurrentPartIndex);
        }

        private void AllPartsAddBtn_Click(object sender, EventArgs e)
        {
            Product.AssociatedParts.Add(Inventory.CurrentPart);
        }
    }
}
