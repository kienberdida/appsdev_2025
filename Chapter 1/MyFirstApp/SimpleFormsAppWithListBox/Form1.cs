namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !listBox.Items.Contains(txtBox.Text))
            {
                listBox.Items.Add(txtBox.Text);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
