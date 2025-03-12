namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom" };
            moviesCheckBoxList.Items.AddRange(movies);
            moviesCheckBoxList.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movie in moviesCheckBoxList.Items)
            {
                bool isSelected = moviesCheckBoxList.GetItemChecked(moviesCheckBoxList.Items.IndexOf(movie));
                if (isSelected && !programmingLanguageListBox.Items.Contains(movie))
                {
                    programmingLanguageListBox.Items.Add(movie);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (programmingLanguageListBox.Items.Count >= 1)
            {
                programmingLanguageListBox.Items.Remove(programmingLanguageListBox.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            programmingLanguageListBox.Items.Clear();
        }
    }
}
