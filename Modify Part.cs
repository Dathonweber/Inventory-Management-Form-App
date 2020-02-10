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
        public Modify_Part()
        {
            InitializeComponent();
        }

        private TextBox MachineIdTextbox = new TextBox();
        private Label MachineIdLabel = new Label();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdTextbox.Size = new Size(100, 20);
            MachineIdTextbox.Location = new Point(111, 288);
            this.Controls.Add(MachineIdTextbox);

            MachineIdLabel.Size = new Size(62, 13);
            MachineIdLabel.Location = new Point(40, 288);
            MachineIdLabel.Text = "Machine ID";
            this.Controls.Add(MachineIdLabel);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(MachineIdLabel);
            this.Controls.Remove(MachineIdTextbox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
