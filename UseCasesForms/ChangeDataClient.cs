using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class ChangeDataClient : Form
    {
        private bool stop = false;
        public ChangeDataClient()
        {
            InitializeComponent();
            InfoRestriction();
            label11.Text = "";
        }

        private void InfoRestriction()
        {
            do
            {
                while (changesCB.Text == "Conta")
                {
                    infoInput.Visible = false;
                    changeInfo.Visible = false;
                }

                infoInput.Visible = true;
                changeInfo.Visible = true;
            } while (stop);
        }

        private void addNewClientButton_Click(object sender, EventArgs e)
        {
            stop = true;
            string info = infoInput.Text;
            var flag = long.TryParse(documentInput.Text, out var document);
            bool result = false;

            if (flag)
            {
                switch (changesCB.SelectedItem.ToString())
                {
                    case "Nome":
                        result = ChangeClientData.Execute(1, document, info);
                        break;
                    case "CPF":
                        result = ChangeClientData.Execute(2, document, info);
                        break;
                    case "Telefone":
                        result = ChangeClientData.Execute(3, document, info);
                        break;
                    case "Endereço":
                        result = ChangeClientData.Execute(4, document, info);
                        break;
                    //case "Conta":
                    //    result = ChangeClientData.Execute(5, document, info);
                    //    break;
                    default:
                        result = false;
                        break;
                }
            }
            if (!result)
                label11.Text = "Não foi possível alterar o cadastro. \nVerifique os dados ou cadastre um cliente novo.";
            else
                label11.Text = "Alteração finalizada com sucesso!";
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentInput_Enter_1(object sender, EventArgs e)
        {
            if (documentInput.Text == "Somente Números")
            {
                documentInput.Text = "";
                documentInput.ForeColor = Color.Black;
            }
        }
        private void documentInput_Leave_1(object sender, EventArgs e)
        {
            if (documentInput.Text == "")
            {
                documentInput.Text = "Somente Números";
                documentInput.ForeColor = Color.Gray;
            }
        }
    }
}
