using AdaCredit.UI.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteForm.UseCasesForms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            label11.Text = "";
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            string name = nameInput.Text;
            bool flag = long.TryParse(documentInput.Text, out long document);
            string username = usernameInput.Text;
            string cleanPassword = cleanPasswordInput.Text;
            string passwordConfirmation = passwordInput2.Text;
            int reason = 0;

            if (flag && cleanPassword == passwordConfirmation)
                result = AddNewEmployee.Execute(name, document, username , cleanPassword, out reason);

            if (result)
                label11.Text = "Tudo certo! Cliente adicionado com sucesso!";
            else if(!result && reason==1)
                label11.Text = "Ops! Documento já cadastrado no sistema.";
            else if (!result && reason == 2)
                label11.Text = "Ops! Este usuário está em uso. Tente outro usuário.";
            else
                label11.Text = "Ops! Não foi possível realizar o cadastro. \nVerifique os dados do funcionário.";
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
