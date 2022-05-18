using System.Diagnostics;
namespace RSv1CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onClickBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(420);
            string name = userInput.Text;
            resultText.Text = rndNum + name;
        }

        private void userInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void authorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/swarnab69");
        }
    }
}