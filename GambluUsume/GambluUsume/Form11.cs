using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GambluUsume
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            // Ustawiamy pozycję okna dokładnie tam, gdzie chcemy
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location; // to sprawi, że pojawi się w tym samym miejscu co Form1

            this.Hide();
            form10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Ustawiamy pozycję okna dokładnie tam, gdzie chcemy
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location; // to sprawi, że pojawi się w tym samym miejscu co Form1

            this.Hide();
            form1.Show();
        }
    }
}
