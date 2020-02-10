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
    public partial class  MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            ProductsGridView.DataSource = Inventory.Products;
            PartsGridView.DataSource = Inventory.AllParts;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      private void button3_Click(object sender, EventArgs e)
        {
         var Add_Part = new Add_Part();
            Add_Part.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Modify_Part = new Modify_Part();
            Modify_Part.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var addProd = new Add_Product();
            addProd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var modProd = new Modify_Product();
            modProd.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Part DeletedPart = new Part(Convert.ToInt32(PartsGridView.SelectedCells[0].Value), PartsGridView.SelectedCells[1].Value.ToString(), Convert.ToDecimal(PartsGridView.SelectedCells[2].Value),
                                      Convert.ToInt32(PartsGridView.SelectedCells[3].Value), Convert.ToInt32(PartsGridView.SelectedCells[4].Value), Convert.ToInt32(PartsGridView.SelectedCells[5].Value));

            Part testPart = new Part(5, PartsGridView.SelectedCells[1].Value.ToString(), 5, 5, 5, 5);
            MessageBox.Show(DeletedPart.PartID.ToString(), "Test Part", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Inventory.deletePart(DeletedPart);



            //if (MessageBox.Show("Are you sure you want to remove this part?", "Remove Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //   PartsGridView.Rows.RemoveAt(PartsGridView.CurrentRow.Index);
            //}
        }
    }
}
