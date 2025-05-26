using System.Text.RegularExpressions;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Changer_Click(object sender, EventArgs e)
        {
            if (listWords.SelectedItem != null)
            {
                string input = listWords.SelectedItem.ToString();
                string output = Regex.Replace(input, "[a-zA-Z]", "+");
                Result.Text = output;
            }
        }

        private void listWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
