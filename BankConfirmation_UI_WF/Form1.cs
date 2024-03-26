namespace BankConfirmation_UI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientClick(object sender, EventArgs e)
        {

        }

        private void AccountClick(object sender, EventArgs e)
        {
            FormAccount formAccount = new();
            formAccount.Show();
        }
    }
}
