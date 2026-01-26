using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GambluUsume
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.CloseIfOpen(
                typeof(Form3),
                typeof(Form4),
                typeof(Form5),
                typeof(Form6),
                typeof(Form7),
                typeof(Form8),
                typeof(Form9)
            );

            // Pobierz lub utwórz Form1
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 == null)
            {
                form1 = new Form1();
            }

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Show();
            form1.Activate();

            // Zamknij Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy Form3 już istnieje
            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();

            // Jeśli istnieje Form4-9/3 – zamknij go
            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form5),
                typeof(Form6),
                typeof(Form7),
                typeof(Form8),
                typeof(Form9)
            );

            // Jeśli Form3 już istnieje – tylko aktywuj
            if (form3 != null)
            {
                form3.Activate();
                return;
            }

            // Utwórz nowy Form3
            form3 = new Form3();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy Form4 już istnieje
            Form4 form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault();

            // Jeśli istnieje Form3-9/4 – zamknij go
            Class1.CloseIfOpen(
                            typeof(Form3),
                            typeof(Form5),
                            typeof(Form6),
                            typeof(Form7),
                            typeof(Form8),
                            typeof(Form9)
                        );

            // Jeśli Form4 już istnieje – tylko aktywuj
            if (form4 != null)
            {
                form4.Activate();
                return;
            }

            // Utwórz nowy Form4
            form4 = new Form4();
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy Form5 już istnieje
            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault();

            // Jeśli istnieje Form3-9/5 – zamknij go
            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form3),
                typeof(Form6),
                typeof(Form7),
                typeof(Form8),
                typeof(Form9)
            );

            // Jeśli Form5 już istnieje – tylko aktywuj
            if (form5 != null)
            {
                form5.Activate();
                return;
            }

            // Utwórz nowy Form5
            form5 = new Form5();
            form5.StartPosition = FormStartPosition.Manual;
            form5.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form6 form6 = Application.OpenForms.OfType<Form6>().FirstOrDefault();


            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form3),
                typeof(Form5),
                typeof(Form7),
                typeof(Form8),
                typeof(Form9)
            );


            if (form6 != null)
            {
                form6.Activate();
                return;
            }


            form6 = new Form6();
            form6.StartPosition = FormStartPosition.Manual;
            form6.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = Application.OpenForms.OfType<Form7>().FirstOrDefault();


            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form3),
                typeof(Form5),
                typeof(Form6),
                typeof(Form8),
                typeof(Form9)
            );


            if (form7 != null)
            {
                form7.Activate();
                return;
            }


            form7 = new Form7();
            form7.StartPosition = FormStartPosition.Manual;
            form7.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = Application.OpenForms.OfType<Form8>().FirstOrDefault();


            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form3),
                typeof(Form5),
                typeof(Form6),
                typeof(Form7),
                typeof(Form9)
            );


            if (form8 != null)
            {
                form8.Activate();
                return;
            }


            form8 = new Form8();
            form8.StartPosition = FormStartPosition.Manual;
            form8.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form9 = Application.OpenForms.OfType<Form9>().FirstOrDefault();


            Class1.CloseIfOpen(
                typeof(Form4),
                typeof(Form3),
                typeof(Form5),
                typeof(Form6),
                typeof(Form7),
                typeof(Form8)
            );


            if (form9 != null)
            {
                form9.Activate();
                return;
            }


            form9 = new Form9();
            form9.StartPosition = FormStartPosition.Manual;
            form9.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );

            form9.Show();
        }
    }
}
