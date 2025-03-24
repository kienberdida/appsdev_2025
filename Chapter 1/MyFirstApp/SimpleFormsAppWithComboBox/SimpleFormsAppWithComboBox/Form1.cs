using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            combocBox1.Items.AddRange(cuisine);
            combocBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            combocBox1.SelectedIndex = 0;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" };
            string[] japaneseCuisineList = { "Takoyaki", "Onigiri", "Soba & Udon Noodles", "Sushi" };
            string[] chineseCuisineList = { "Hot Pot", "Roasted duck", "Dumplings", "Kung Pao Chicken" };
            string[] koreanCuisineList = { "Kimchi", "Bulgogi", "Hanbok", "Soju" };

            checkedListBox1.Items.Clear();

            if (combocBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoCuisineList);
            }
            else if (combocBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(japaneseCuisineList);
            }
            else if (combocBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseCuisineList);
            }
            else if (combocBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(koreanCuisineList);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1) {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}



