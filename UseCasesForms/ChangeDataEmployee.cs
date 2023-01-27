using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class ChangeDataEmployee : Form
    {
        private string typeSelected;
        public ChangeDataEmployee()
        {
            InitializeComponent();
            label11.Text = "";
            changeInfo.Visible = false;
            infoInput.Visible = false;
            changeInfoBG.Visible = false;
            info2BG.Visible = false;
            info2Lb.Visible = false;
            info2TB.Visible = false;

        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (changesCB.SelectedItem.ToString() == "Senha")
            {
                infoInput.PasswordChar = '*';
                info2BG.Visible = true;
                info2BG.SendToBack();
                info2Lb.Visible = true;
                info2TB.Visible = true;
                changeInfo.Visible = true;
                infoInput.Visible = true;
                changeInfoBG.Visible = true;
            }
            else
            {
                infoInput.PasswordChar = default;
                info2BG.Visible = false;
                info2Lb.Visible = false;
                info2TB.Visible = false;
                changeInfo.Visible = true;
                infoInput.Visible = true;
                changeInfoBG.Visible = true;
            }
            
            typeSelected = changesCB.SelectedItem.ToString();
        }

        private void addNewClientButton_Click(object sender, EventArgs e)
        {
            string info = infoInput.Text;
            string info2 = info2TB.Text;
            var flag = long.TryParse(documentInput.Text, out var document);
            bool result = false;


            if (changesCB.SelectedItem.ToString() != typeSelected)
                flag = false;

            if (flag)
            {
                switch (changesCB.SelectedItem.ToString())
                {
                    case "Nome":
                        result = ChangeEmployeeData.Execute(1, document, info);
                        break;
                    case "CPF":
                        result = ChangeEmployeeData.Execute(2, document, info);
                        break;
                    case "Usuário":
                        result = ChangeEmployeeData.Execute(3, document, info);
                        break;
                    case "Senha":
                        if(info == info2)
                            result = ChangeEmployeeData.Execute(4, document, info);
                        break;
                    default:
                        result = false;
                        break;
                }
            }
            if (!result)
                label11.Text = "Não foi possível alterar o cadastro. \nVerifique os dados ou cadastre um cliente novo.";
            else
                label11.Text = "Alteração finalizada com sucesso!";

            infoInput.Text = "";
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
        
}
}
