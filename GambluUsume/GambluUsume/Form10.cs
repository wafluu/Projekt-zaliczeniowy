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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 == null)
            {
                form1 = new Form1();
            }

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Show();
            form1.Activate();

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();

            // Ustawiamy pozycję okna dokładnie tam, gdzie chcemy
            form11.StartPosition = FormStartPosition.Manual;
            form11.Location = this.Location; // to sprawi, że pojawi się w tym samym miejscu co Form1

            this.Hide();
            form11.Show();
        }
    }
}
