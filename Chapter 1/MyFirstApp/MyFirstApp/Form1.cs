namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fNameValue = firstName.Text;
            string lNameValue = lastName.Text;
            MessageBox.Show($"Hello World! {fNameValue} {lNameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
