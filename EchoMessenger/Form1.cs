using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(myTextBox.Text))
                return;

            string msg = myTextBox.Text.Trim();

            string time = DateTime.Now.ToString("HH:mm:ss");

            string result = $"[{time}] {msg}";

            myListBox.Items.Add(result);

            countLabel.Text = $"현재 대화: {myListBox.Items.Count}개";

            myTextBox.Clear();
            myTextBox.Focus();
        }

        private void myTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton.PerformClick();
            }
        }

        private void myListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
