using AdaCredit.UI.UseCases;

namespace TesteForm.UseCasesForms
{
    public partial class CheckActiveEmployees : Form
    {
        private string[][] data;
        public CheckActiveEmployees()
        {
            InitializeComponent();

            data = AdaCredit.UI.UseCases.CheckActiveEmployees.Execute();

            foreach (var row in data)
            {
                dataList.Items.Add($"Nome: {row[0]}");
                dataList.Items.Add($"CPF: {row[1]}");
                dataList.Items.Add($"Usuário: {row[2]}");
                dataList.Items.Add($"Último Login: {row[3]}");
                dataList.Items.Add("---------------------------------------------------------------");
            }
            dataList.Items.Add("Relatório finalizado.");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Download.Execute(data, "Funcionários_Ativos.txt", "Nome, CPF, Usuário, ÚltimoAcesso");

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
