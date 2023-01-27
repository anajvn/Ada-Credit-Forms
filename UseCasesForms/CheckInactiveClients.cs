using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class CheckInactiveClients : Form
    {
        private string[][] data;
        public CheckInactiveClients()
        {
            InitializeComponent();

            data = AdaCredit.UI.UseCases.CheckInactiveClients.Execute();

            foreach (var row in data)
            {
                dataList.Items.Add($"Nome: {row[0]}");
                dataList.Items.Add($"CPF: {row[1]}");
                dataList.Items.Add($"Agência: {row[2]}");
                dataList.Items.Add($"Número da conta: {row[3]}");
                dataList.Items.Add("---------------------------------------------------------------");
            }
            dataList.Items.Add("Relatório finalizado.");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Download.Execute(data, "Clientes_Inativos.txt", "Nome, CPF, Agência, Conta");

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
