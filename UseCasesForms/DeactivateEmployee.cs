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
    public partial class DeactivateEmployee : Form
    {
        public DeactivateEmployee()
        {
            InitializeComponent();
            resultLb.Text = "";
            label11.Text = "";
        }

        private void DeactivateButton_Click(object sender, EventArgs e)
        {
            bool result = long.TryParse(documentInput.Text, out var document);
            bool isActive = false;

            if (result)
                result = DeactivateEmployeeRegister.Execute(document, out isActive);

            if (!result)
                label11.Text = "Não foi possível realizar a operação.";
            else
            {
                label11.Text = "Operação realizada com sucesso!";

                if (isActive)
                    resultLb.Text = "A conta foi desativada.";
                else
                    resultLb.Text = "A conta foi ativada.";
            }
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
