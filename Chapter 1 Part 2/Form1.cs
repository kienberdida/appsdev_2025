namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fNameValue = firstName.Text;
            var lNameValue = lastName.Text;
            var mNameValue = middleName.Text; 
            var sNameValue = suffixName.Text;

            
            var result = MessageBox.Show("Are you sure you want to submit?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
            if (result == DialogResult.Yes)
            {
                
                MessageBox.Show($"Hello There! {fNameValue} {mNameValue} {lNameValue} {sNameValue}",
                    "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("Submission cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
