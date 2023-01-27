using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class CheckFailedTransactions : Form
    {
        private string[][] data;
        public CheckFailedTransactions()
        {
            InitializeComponent();

            data = AdaCredit.UI.UseCases.CheckFailedTransactions.Execute();

            foreach (var row in data)
            {
                dataList.Items.Add($"Data: {row[0]}");
                dataList.Items.Add($"Transação: {row[1]}");
                dataList.Items.Add($"Motivo: {row[2]}");
                dataList.Items.Add("---------------------------------------------------------------");
            }
            dataList.Items.Add("Relatório finalizado.");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Download.Execute(data, "Transacoes_com_erros.txt", "Data, Transação, Motivo");

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
