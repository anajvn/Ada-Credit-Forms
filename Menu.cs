using TesteForm.UseCasesForms;

namespace TesteForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            clientPanel.Visible = false;
            employeePanel.Visible = false;
            transactionsPanel.Visible = false;
            reportsPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (clientPanel.Visible)
                clientPanel.Visible = false;
            if (employeePanel.Visible)
                employeePanel.Visible = false;
            if (transactionsPanel.Visible)
                transactionsPanel.Visible = false;
            if (reportsPanel.Visible)
                reportsPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private static void OpenChildForm(Form childForm, Panel controlPanel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(childForm);
            controlPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void controlPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control item in controlPanel.Controls)
            {
                var frm = (Form)item;
                frm.Width = controlPanel.Width;
                frm.Height = controlPanel.Height;
            }
        }

        #region Client
        private void clientButton_Click(object sender, EventArgs e)
        {
            showSubMenu(clientPanel);
        }
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddClient(), controlPanel);
        }
        private void ConsultClientDataButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultDataClient(), controlPanel);
        }
        private void ChangeDataClientButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeDataClient(), controlPanel);
        }
        private void deactivateClientButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeactivateClient(), controlPanel);
        }
        #endregion

        #region Employee
        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            showSubMenu(employeePanel);
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEmployee(), controlPanel);
        }
        private void consultEmployeeDataButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultDataEmployee(), controlPanel);
        }
        private void changeEmployeeDataButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeDataEmployee(), controlPanel);
        }
        private void deactivateEmployeeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeactivateEmployee(), controlPanel);
        }
        #endregion

        #region Transactions
        private void transactionsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(transactionsPanel);
        }
        private void processTransactionsButton_Click(object sender, EventArgs e)
        {
            bool result = AdaCredit.UI.UseCases.ProcessTransactions.Execute();

            // Message box items
            string message = "Transações processadas com sucesso!";
            if (!result)
                message = "Não existem transações a serem processadas.";
            string caption = "Processar transações";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays message
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
        }
        #endregion

        #region Reports
        private void reportsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(reportsPanel);
        }
        private void activeClientsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckActiveClients(), controlPanel);
        }
        private void InactiveClientsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckInactiveClients(), controlPanel);
        }
        private void activeEmployeesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckActiveEmployees(), controlPanel);
        }
        private void failedTransactionsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckFailedTransactions(), controlPanel);
        }

        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




