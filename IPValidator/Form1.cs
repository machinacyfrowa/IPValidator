using System.Net;

namespace IPValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            string ipString = ipAddressTextBox.Text;
            IPAddress ip;
            bool valid = IPAddress.TryParse(ipString, out ip);

            if(valid)
            {
                addressValidLabel.Text = "Adres jest poprawny";
                addressValidLabel.Visible = true;
            } 
            else
            {
                addressValidLabel.Text = "Adres jest niepoprawny";
                addressValidLabel.Visible = true;
            }
        }
    }
}