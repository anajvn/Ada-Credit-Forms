using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent(); 
            label11.Text = "";
        }

        private void addNewClientButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            string name = nameInput.Text;
            bool flag = long.TryParse(documentInput.Text, out long document);
            string phone = phoneInput.Text;
            string address = AddressInput.Text;

            if (flag)
                result = AddNewClient.Execute(name, document, phone, address);



            if (result)
                label11.Text = "Tudo certo! Cliente adicionado com sucesso!";
            else
                label11.Text = "Ops! Falha ao cadastrar novo cliente.\n Tente Novamente.";
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentInput_Enter(object sender, EventArgs e)
        {
            if (documentInput.Text == "Somente Números")
            {
                documentInput.Text = "";
                documentInput.ForeColor = Color.Black;
            }
        }

        private void documentInput_Leave(object sender, EventArgs e)
        {
            if (documentInput.Text == "")
            {
                documentInput.Text = "Somente Números";
                documentInput.ForeColor = Color.Gray;
            }
        }

        private void phoneInput_Enter(object sender, EventArgs e)
        {
            if(phoneInput.Text == "(XX) XXXXX-XXXX")
            {
                phoneInput.Text = "";
                phoneInput.ForeColor = Color.Black;
            }
        }

        private void phoneInput_Leave(object sender, EventArgs e)
        {
            if (phoneInput.Text == "")
            {
                phoneInput.Text = "(XX) XXXXX-XXXX";
                phoneInput.ForeColor = Color.Gray;
            }
        }
    }
}
