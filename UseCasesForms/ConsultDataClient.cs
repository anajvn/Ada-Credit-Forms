using AdaCredit.UI.UseCases;
using System.Windows.Forms;
using AdaCredit.UI.Domain;

namespace TesteForm.UseCasesForms
{
    public partial class ConsultDataClient : Form
    {
        public ConsultDataClient()
        {
            InitializeComponent();
            messageInput.Text = "Nome";
            backgroundInfo2.Visible = false;
            info2.Visible = false;
            textInfo2.Visible = false;
            label11.Text = "";
        }
        private void InitializeDataGridView(string[][] rows = null)
        { 
            // Create an unbound DataGridView by declaring a column count.
            clientsInfoTable.ColumnCount = 8;
            clientsInfoTable.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Gray;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            clientsInfoTable.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            clientsInfoTable.Columns[0].Name = "Nome";
            clientsInfoTable.Columns[1].Name = "CPF";
            clientsInfoTable.Columns[2].Name = "Telefone";
            clientsInfoTable.Columns[3].Name = "Endereço";
            clientsInfoTable.Columns[4].Name = "Número da Conta";
            clientsInfoTable.Columns[5].Name = "Agência";
            clientsInfoTable.Columns[6].Name = "Saldo";
            clientsInfoTable.Columns[7].Name = "Situação";

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
            backgroundInfo2.Visible = false;
            info2.Visible = false;
            textInfo2.Visible = false;
            textInput.Text = "";
            messageInput.Text = "Nome";
            
        }
        private void byDocumentButton_Click(object sender, EventArgs e)
        {
            backgroundInfo2.Visible = false;
            info2.Visible = false;
            textInfo2.Visible = false;
            textInput.Text = "";
            messageInput.Text = "CPF";
            textInput.Text = "Somente Números";
        }
        private void byAccountButton_Click(object sender, EventArgs e)
        {
            messageInput.Text = "Conta";
            textInput.Text = "XXXXX-X";
            backgroundInfo2.Visible = true;
            backgroundInfo2.SendToBack();
            info2.Visible = true;
            textInfo2.Visible = true;
            info2.Text = "Agência";
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
                    result = ConsultClientData.Execute(1, textInput.Text, out data);
                    break;
                case "CPF":
                    result = ConsultClientData.Execute(2, textInput.Text, out data);
                    break;
                default:
                    result = ConsultClientData.Execute(3, textInput.Text, out data, textInfo2.Text);
                    break;
            }

            if (!result)
                label11.Text = "Não foi possível encontrar o cadastro.\n Verifique os dados ou cadastre um cliente novo.";
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
            if (textInput.Text == "XXXXX-X" && messageInput.Text == "Conta")
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
            if (textInput.Text == "" && messageInput.Text == "Conta")
            {
                textInput.Text = "XXXXX-X";
                textInput.ForeColor = Color.Black;
            }
        }
    }
}
