using AIMLbot;
namespace ChatBox_App
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();

            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;
            User myUser = new User("Username Here", AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(textBox1.Text, myUser, AI);
            Result res = AI.Chat(r);
            Textbox2.Text = "SILKY THE BOT: " + res.Output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}