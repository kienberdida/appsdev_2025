namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Spongebob":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\oo108\\Desktop\\Cartoon Characters\\Spongebob\\CgcxnFVXEAERlcU.jpg_large");
                    break;
                case "Patrick":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\oo108\\Desktop\\Cartoon Characters\\Patrick\\maaa3ocuvkh21.jpg");
                    break;
                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\oo108\\Desktop\\Cartoon Characters\\Mr. Krabs\\525c31875af9f44a3e8be295a63a1a9e.jpg");
                    break;
                case "Sandy":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\oo108\\Desktop\\Cartoon Characters\\Sandy\\bluespeedo_buffcheeks_by_sandypantybuffpants_df1nma8-414w.jpg");
                    break;
                default:
                    pictureBox1.Image = null; // Clear if no match
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
