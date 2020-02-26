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
            PartsGridView.DataSource = List.AllParts;
            PartsGridView.DefaultCellStyle.SelectionBackColor = PartsGridView.DefaultCellStyle.BackColor;
            PartsGridView.DefaultCellStyle.SelectionForeColor = PartsGridView.DefaultCellStyle.ForeColor;
            PartsGridView.AutoGenerateColumns = false;
            PartsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsGridView.RowHeadersVisible = false;
            PartsGridView.ClearSelection();


            ProductsGridView.DataSource = List.Products;
            ProductsGridView.DefaultCellStyle.SelectionBackColor = ProductsGridView.DefaultCellStyle.BackColor;
            ProductsGridView.DefaultCellStyle.SelectionForeColor = ProductsGridView.DefaultCellStyle.ForeColor;
            ProductsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsGridView.RowHeadersVisible = false;
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

        private void ModPartBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentPartIndex >= 0)
            {
                var Modify_Part = new Modify_Part();
                Modify_Part.Show();
            }
            else
            {
                MessageBox.Show("Please Select Something to Modify");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var addProd = new Add_Product();
            addProd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentProductIndex >= 0)
            {
                var modProd = new Modify_Product();
                modProd.Show();
            } else
            {
                MessageBox.Show("Please Select Something to Modify");
            }
        }

  
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentPartIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this part?", "Remove Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inventory.DeletePart(Inventory.CurrentPart);
                }
            }
            else
            {
                MessageBox.Show("Please Select Something");
            }
        }

        private void PartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartIndex);
            PartsGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> SearchList = new BindingList<Part>();

            bool isFound = false;

            if (SearchTxtBox.Text != "")
            {
                for (int x = 0; x < List.AllParts.Count; x++)
                {
                    if (List.AllParts[x].Name.ToUpper().Contains(SearchTxtBox.Text.ToUpper()))
                    {
                        SearchList.Add(List.AllParts[x]);
                        isFound = true;
                    }
                }
                if (isFound) 
                
                    PartsGridView.DataSource = SearchList;
            }
            if (!isFound)
            {
                MessageBox.Show("Nothing Found.");
                PartsGridView.DataSource = List.AllParts;
            }
        }

        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentProductIndex = e.RowIndex;
            Inventory.CurrentProduct = Inventory.lookupProduct(Inventory.CurrentProductIndex);
            ProductsGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        private void ProdDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentProductIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this Product?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(Inventory.CurrentProductIndex);
                }
            }
            else
            {
                MessageBox.Show("Please Select Something");
            }
        }

        private void ProdSearchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Product> SearchList = new BindingList<Product>();
            bool isFound = false;

            if (ProdSearchBox.Text != "")
            {
                for (int x = 0; x < List.Products.Count; x++ )
                {
                    if (List.Products[x].Name.ToUpper().Contains(ProdSearchBox.Text.ToUpper()))
                    {
                        SearchList.Add(List.Products[x]);
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    ProductsGridView.DataSource = SearchList;
                }
            }
            if (!isFound)
            {
                MessageBox.Show("Nothing Found.");
                ProductsGridView.DataSource = List.Products;
            }
        }

     
    }
}
