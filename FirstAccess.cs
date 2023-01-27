using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdaCredit.UI.Testing;
using AdaCredit.UI.UseCases;
using Microsoft.VisualBasic.Logging;

namespace TesteForm
{
    public partial class FirstAccess : Form
    {
        public FirstAccess()
        {
            InitializeComponent();
            resultLabel.Text = "";
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            string name = nameInput.Text;
            bool flag = long.TryParse(documentInput.Text, out long document);
            string username = usernameInput.Text;
            string cleanPassword1 = passwordInput1.Text;
            string cleanPassword2 = passwordInput2.Text;

            var flag2 = cleanPassword1 == cleanPassword2;

            if (flag && flag2)
                result = AddNewEmployee.Execute(name, document, username, cleanPassword2, out var reason);

            if (result)
            {
                resultLabel.Text = "Tudo certo! Funcionário adicionado com sucesso!";
                CreateEmployees.Execute();
                goBackButton.BringToFront();
            }
            else
                resultLabel.Text = "Ops! Falha ao cadastrar novo funcionário.\n Tente Novamente.";
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["LoginUser"];
            frm.Visible = true;
            this.Close();
        }
    }
}
