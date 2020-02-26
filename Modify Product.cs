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
    public partial class Modify_Product : Form
    {
        public Modify_Product()
        {
            InitializeComponent();
            ProdIDTxtBox.Text = Inventory.CurrentProduct.ProductID.ToString();
            ProdNameTxtBox.Text = Inventory.CurrentProduct.Name;
            ProdInStockTxtBox.Text = Inventory.CurrentProduct.InStock.ToString();
            ProdPriceTxtBox.Text = Inventory.CurrentProduct.Price.ToString();
            ProdMaxTxtBox.Text = Inventory.CurrentProduct.Max.ToString();
            ProdMinTxtBox.Text = Inventory.CurrentProduct.Min.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentProductIndex = e.RowIndex;
            Inventory.CurrentProduct = Inventory.lookupProduct(Inventory.CurrentProductIndex);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(Convert.ToInt32(ProdIDTxtBox.Text), ProdNameTxtBox.Text, Convert.ToInt32(ProdInStockTxtBox.Text),
                    Convert.ToDecimal(ProdPriceTxtBox.Text), Convert.ToInt32(ProdMaxTxtBox.Text), Convert.ToInt32(ProdMinTxtBox.Text));
                Inventory.UpdateProduct(Inventory.CurrentProductIndex, product);
                this.Hide();
            }
            catch (FormatException formatError)
            {
                MessageBox.Show(formatError.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
