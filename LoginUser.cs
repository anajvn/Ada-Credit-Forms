using AdaCredit.UI.Data;
using AdaCredit.UI.Testing;
using AdaCredit.UI.UseCases;

namespace TesteForm
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
            logginMsgLabel.Text = "";
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;

            string cleanPassword = passwordInput.Text;


            if (username == "user" && cleanPassword == "pass" && IsFirstAccess.Execute())
            {
                FirstAccess fa = new FirstAccess();
                fa.Show();
                Visible = false;
                logginMsgLabel.Text = "     Login efetuado com sucesso.     \nEntre no sistema:";
                enterSystemButton.BringToFront();
                return;
            }
            Visible = true;

            var repository = new EmployeeRepository();
            var result = repository.IsLoginValid(username, cleanPassword);

            if (result)
            {
                repository.SaveAccess(username);
            logginMsgLabel.Text = "     Login efetuado com sucesso.     \nEntre no sistema:";
            enterSystemButton.BringToFront();
            }
            else
            {
                logginMsgLabel.Text = "Login não efetuado. \nPor favor, verifique as informações.";
                usernameInput.Text = "";
                passwordInput.Text = "";
            }
        }

        private void enterSystemButton_Click(object sender, EventArgs e)
        {
            CreateClients.Execute();
            CreateTransactions.Execute();
            Menu menu = new Menu();
            menu.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
