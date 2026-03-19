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

            string typed_msg = myTextBox.Text;
            myListBox.Items.Add(typed_msg);
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
    }
}
