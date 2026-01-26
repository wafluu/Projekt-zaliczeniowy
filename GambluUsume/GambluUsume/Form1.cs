namespace GambluUsume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Ustawiamy pozycjê okna dok³adnie tam, gdzie chcemy
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location; // to sprawi, ¿e pojawi siê w tym samym miejscu co Form1

            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            // Ustawiamy pozycjê okna dok³adnie tam, gdzie chcemy
            form10.StartPosition = FormStartPosition.Manual;
            form10.Location = this.Location; // to sprawi, ¿e pojawi siê w tym samym miejscu co Form1

            this.Hide();
            form10.Show();
        }
    }
}
