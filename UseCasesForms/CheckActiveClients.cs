using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class CheckActiveClients : Form
    {
        private string[][] data;
        public CheckActiveClients()
        {
            InitializeComponent();

            data = AdaCredit.UI.UseCases.CheckActiveClients.Execute();

            foreach (var row in data)
            {
                dataList.Items.Add($"Nome: {row[0]}");
                dataList.Items.Add($"CPF: {row[1]}");
                dataList.Items.Add($"Agência: {row[2]}");
                dataList.Items.Add($"Número da conta: {row[3]}");
                dataList.Items.Add($"Saldo: R$ {row[4]}");
                dataList.Items.Add("---------------------------------------------------------------");
            }
            dataList.Items.Add("Relatório finalizado.");
        }
        private void downloadButton_Click(object sender, EventArgs e)
        {
            Download.Execute(data, "Clientes_Ativos_e_Saldo.txt", "Nome, CPF, Agência, Conta, Saldo");

            // Message box items
            string message = "Relatório salvo na área de trabalho.";
           
            string caption = "Download de Relatório";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays message
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
