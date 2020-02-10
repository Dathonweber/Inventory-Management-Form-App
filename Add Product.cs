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
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            AssociatedPartsGridView.DataSource = Product.AssociatedParts;
            AllPartsGridView.DataSource = Inventory.AllParts;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(IdTextBox.Text);
                string Name = NameTextBox.Text;
                decimal Price = Decimal.Parse(PriceTextBox.Text);
                int InStock = int.Parse(InStockTextBox.Text);
                int Max = int.Parse(MaxTextBox.Text);
                int Min = int.Parse(MinTextBox.Text);

                Inventory.AddProduct(new Product(ID, Name, Price, InStock, Max, Min));
                Form.ActiveForm.Close();
            }

            catch(Exception formatException)
            {
                
                MessageBox.Show(formatException.Message,"Format Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
