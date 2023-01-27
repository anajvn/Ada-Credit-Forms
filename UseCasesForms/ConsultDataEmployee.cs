using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class ConsultDataEmployee : Form
    {
        public ConsultDataEmployee()
        {
            InitializeComponent();
            messageInput.Text = "Nome";
            label11.Text = "";
        }
        private void InitializeDataGridView(string[][] rows = null)
        {
            // Create an unbound DataGridView by declaring a column count.
            clientsInfoTable.ColumnCount = 5;
            clientsInfoTable.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Gray;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            clientsInfoTable.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            clientsInfoTable.Columns[0].Name = "Nome";
            clientsInfoTable.Columns[1].Name = "CPF";
            clientsInfoTable.Columns[2].Name = "Usuário";
            clientsInfoTable.Columns[3].Name = "Situação";
            clientsInfoTable.Columns[4].Name = "Ulitmo Login";

            if (rows != null)
            {
                foreach (string[] rowArray in rows)
                {
                    clientsInfoTable.Rows.Add(rowArray);
                }
            }
        }

        private void byNameButton_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            messageInput.Text = "Nome";
        }

        private void byDocumentButton_Click(object sender, EventArgs e)
        {
            messageInput.Text = "CPF";
            textInput.Text = "Somente Números";
        }

        private void byUsernameButton_Click(object sender, EventArgs e)
        {
            messageInput.Text = "Usuário";
            textInput.Text = "";
        }

        private void consultButton_Click(object sender, EventArgs e)
        {
            clientsInfoTable.Rows.Clear();
            string[][] data;
            bool result;
            var info = messageInput.Text;
            switch (info)
            {
                case "Nome":
                    result = ConsultEmployeeData.Execute(1, textInput.Text, out data);
                    break;
                case "CPF":
                    result = ConsultEmployeeData.Execute(2, textInput.Text, out data);
                    break;
                default:
                    result = ConsultEmployeeData.Execute(3, textInput.Text, out data);
                    break;
            }

            if (!result)
                label11.Text = "Não foi possível encontrar o cadastro.\n Verifique os dados ou cadastre um funcionário novo.";
            else
                InitializeDataGridView(data);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textInput_Enter(object sender, EventArgs e)
        {
            if (textInput.Text == "Somente Números" && messageInput.Text == "CPF")
            {
                textInput.Text = "";
                textInput.ForeColor = Color.Black;
            }
        }

        private void textInput_Leave(object sender, EventArgs e)
        {
            if (textInput.Text == "" && messageInput.Text == "CPF")
            {
                textInput.Text = "Somente Números";
                textInput.ForeColor = Color.Black;
            }
        }
    }
}
