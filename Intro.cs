namespace TesteForm
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Visible = false;
        }
    }
}