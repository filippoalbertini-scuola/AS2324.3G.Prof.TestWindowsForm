namespace AS2324._3G.Prof.TestWindowsForm
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

        private void btnSaluta_Click(object sender, EventArgs e)
        {
            lblSaluto.Text = "Ciao " + txtNome.Text;
        }
    }
}
