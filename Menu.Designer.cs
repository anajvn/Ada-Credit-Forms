namespace TesteForm
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.failedTransactionsButton = new System.Windows.Forms.Button();
            this.activeEmployeesButton = new System.Windows.Forms.Button();
            this.InactiveClientsButton = new System.Windows.Forms.Button();
            this.activeClientsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.transactionsPanel = new System.Windows.Forms.Panel();
            this.processTransactionsButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.deactivateEmployeeButton = new System.Windows.Forms.Button();
            this.changeEmployeeDataButton = new System.Windows.Forms.Button();
            this.consultEmployeeDataButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.deactivateClientButton = new System.Windows.Forms.Button();
            this.ChangeDataClientButton = new System.Windows.Forms.Button();
            this.ConsultClientDataButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel.SuspendLayout();
            this.reportsPanel.SuspendLayout();
            this.transactionsPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.sideMenuPanel.Controls.Add(this.exitButton);
            this.sideMenuPanel.Controls.Add(this.reportsPanel);
            this.sideMenuPanel.Controls.Add(this.reportsButton);
            this.sideMenuPanel.Controls.Add(this.transactionsPanel);
            this.sideMenuPanel.Controls.Add(this.transactionsButton);
            this.sideMenuPanel.Controls.Add(this.employeePanel);
            this.sideMenuPanel.Controls.Add(this.EmployeeButton);
            this.sideMenuPanel.Controls.Add(this.clientPanel);
            this.sideMenuPanel.Controls.Add(this.clientButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 521);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.LightGray;
            this.exitButton.Location = new System.Drawing.Point(0, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(250, 70);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Sair";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.failedTransactionsButton);
            this.reportsPanel.Controls.Add(this.activeEmployeesButton);
            this.reportsPanel.Controls.Add(this.InactiveClientsButton);
            this.reportsPanel.Controls.Add(this.activeClientsButton);
            this.reportsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsPanel.Location = new System.Drawing.Point(0, 640);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(250, 160);
            this.reportsPanel.TabIndex = 13;
            // 
            // failedTransactionsButton
            // 
            this.failedTransactionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.failedTransactionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.failedTransactionsButton.FlatAppearance.BorderSize = 0;
            this.failedTransactionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.failedTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.failedTransactionsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.failedTransactionsButton.ForeColor = System.Drawing.Color.LightGray;
            this.failedTransactionsButton.Location = new System.Drawing.Point(0, 120);
            this.failedTransactionsButton.Name = "failedTransactionsButton";
            this.failedTransactionsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.failedTransactionsButton.Size = new System.Drawing.Size(250, 40);
            this.failedTransactionsButton.TabIndex = 16;
            this.failedTransactionsButton.Text = "Transações com Erro";
            this.failedTransactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.failedTransactionsButton.UseVisualStyleBackColor = true;
            this.failedTransactionsButton.Click += new System.EventHandler(this.failedTransactionsButton_Click);
            // 
            // activeEmployeesButton
            // 
            this.activeEmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeEmployeesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.activeEmployeesButton.FlatAppearance.BorderSize = 0;
            this.activeEmployeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.activeEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeEmployeesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeEmployeesButton.ForeColor = System.Drawing.Color.LightGray;
            this.activeEmployeesButton.Location = new System.Drawing.Point(0, 80);
            this.activeEmployeesButton.Name = "activeEmployeesButton";
            this.activeEmployeesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.activeEmployeesButton.Size = new System.Drawing.Size(250, 40);
            this.activeEmployeesButton.TabIndex = 15;
            this.activeEmployeesButton.Text = "Funcionários Ativos e Login";
            this.activeEmployeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activeEmployeesButton.UseVisualStyleBackColor = true;
            this.activeEmployeesButton.Click += new System.EventHandler(this.activeEmployeesButton_Click);
            // 
            // InactiveClientsButton
            // 
            this.InactiveClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InactiveClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InactiveClientsButton.FlatAppearance.BorderSize = 0;
            this.InactiveClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.InactiveClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InactiveClientsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InactiveClientsButton.ForeColor = System.Drawing.Color.LightGray;
            this.InactiveClientsButton.Location = new System.Drawing.Point(0, 40);
            this.InactiveClientsButton.Name = "InactiveClientsButton";
            this.InactiveClientsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.InactiveClientsButton.Size = new System.Drawing.Size(250, 40);
            this.InactiveClientsButton.TabIndex = 14;
            this.InactiveClientsButton.Text = "Clientes Inativos";
            this.InactiveClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InactiveClientsButton.UseVisualStyleBackColor = true;
            this.InactiveClientsButton.Click += new System.EventHandler(this.InactiveClientsButton_Click);
            // 
            // activeClientsButton
            // 
            this.activeClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.activeClientsButton.FlatAppearance.BorderSize = 0;
            this.activeClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.activeClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeClientsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeClientsButton.ForeColor = System.Drawing.Color.LightGray;
            this.activeClientsButton.Location = new System.Drawing.Point(0, 0);
            this.activeClientsButton.Name = "activeClientsButton";
            this.activeClientsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.activeClientsButton.Size = new System.Drawing.Size(250, 40);
            this.activeClientsButton.TabIndex = 13;
            this.activeClientsButton.Text = "Clientes Ativos e Saldos";
            this.activeClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activeClientsButton.UseVisualStyleBackColor = true;
            this.activeClientsButton.Click += new System.EventHandler(this.activeClientsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsButton.ForeColor = System.Drawing.Color.LightGray;
            this.reportsButton.Location = new System.Drawing.Point(0, 570);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportsButton.Size = new System.Drawing.Size(250, 70);
            this.reportsButton.TabIndex = 12;
            this.reportsButton.Text = "Relatórios";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // transactionsPanel
            // 
            this.transactionsPanel.Controls.Add(this.processTransactionsButton);
            this.transactionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsPanel.Location = new System.Drawing.Point(0, 530);
            this.transactionsPanel.Name = "transactionsPanel";
            this.transactionsPanel.Size = new System.Drawing.Size(250, 40);
            this.transactionsPanel.TabIndex = 11;
            // 
            // processTransactionsButton
            // 
            this.processTransactionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processTransactionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.processTransactionsButton.FlatAppearance.BorderSize = 0;
            this.processTransactionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.processTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processTransactionsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processTransactionsButton.ForeColor = System.Drawing.Color.LightGray;
            this.processTransactionsButton.Location = new System.Drawing.Point(0, 0);
            this.processTransactionsButton.Name = "processTransactionsButton";
            this.processTransactionsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.processTransactionsButton.Size = new System.Drawing.Size(250, 40);
            this.processTransactionsButton.TabIndex = 13;
            this.processTransactionsButton.Text = "Processar transações";
            this.processTransactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processTransactionsButton.UseVisualStyleBackColor = true;
            this.processTransactionsButton.Click += new System.EventHandler(this.processTransactionsButton_Click);
            // 
            // transactionsButton
            // 
            this.transactionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsButton.FlatAppearance.BorderSize = 0;
            this.transactionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.transactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionsButton.ForeColor = System.Drawing.Color.LightGray;
            this.transactionsButton.Location = new System.Drawing.Point(0, 460);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.transactionsButton.Size = new System.Drawing.Size(250, 70);
            this.transactionsButton.TabIndex = 10;
            this.transactionsButton.Text = "Transações";
            this.transactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionsButton.UseVisualStyleBackColor = true;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.deactivateEmployeeButton);
            this.employeePanel.Controls.Add(this.changeEmployeeDataButton);
            this.employeePanel.Controls.Add(this.consultEmployeeDataButton);
            this.employeePanel.Controls.Add(this.AddEmployeeButton);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeePanel.Location = new System.Drawing.Point(0, 300);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(250, 160);
            this.employeePanel.TabIndex = 9;
            // 
            // deactivateEmployeeButton
            // 
            this.deactivateEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactivateEmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deactivateEmployeeButton.FlatAppearance.BorderSize = 0;
            this.deactivateEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.deactivateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deactivateEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deactivateEmployeeButton.ForeColor = System.Drawing.Color.LightGray;
            this.deactivateEmployeeButton.Location = new System.Drawing.Point(0, 120);
            this.deactivateEmployeeButton.Name = "deactivateEmployeeButton";
            this.deactivateEmployeeButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.deactivateEmployeeButton.Size = new System.Drawing.Size(250, 40);
            this.deactivateEmployeeButton.TabIndex = 12;
            this.deactivateEmployeeButton.Text = "Desativar Cadastro";
            this.deactivateEmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deactivateEmployeeButton.UseVisualStyleBackColor = true;
            this.deactivateEmployeeButton.Click += new System.EventHandler(this.deactivateEmployeeButton_Click);
            // 
            // changeEmployeeDataButton
            // 
            this.changeEmployeeDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeEmployeeDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeEmployeeDataButton.FlatAppearance.BorderSize = 0;
            this.changeEmployeeDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.changeEmployeeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmployeeDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeEmployeeDataButton.ForeColor = System.Drawing.Color.LightGray;
            this.changeEmployeeDataButton.Location = new System.Drawing.Point(0, 80);
            this.changeEmployeeDataButton.Name = "changeEmployeeDataButton";
            this.changeEmployeeDataButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.changeEmployeeDataButton.Size = new System.Drawing.Size(250, 40);
            this.changeEmployeeDataButton.TabIndex = 11;
            this.changeEmployeeDataButton.Text = "Alterar Cadastro";
            this.changeEmployeeDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeEmployeeDataButton.UseVisualStyleBackColor = true;
            this.changeEmployeeDataButton.Click += new System.EventHandler(this.changeEmployeeDataButton_Click);
            // 
            // consultEmployeeDataButton
            // 
            this.consultEmployeeDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultEmployeeDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.consultEmployeeDataButton.FlatAppearance.BorderSize = 0;
            this.consultEmployeeDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.consultEmployeeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultEmployeeDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultEmployeeDataButton.ForeColor = System.Drawing.Color.LightGray;
            this.consultEmployeeDataButton.Location = new System.Drawing.Point(0, 40);
            this.consultEmployeeDataButton.Name = "consultEmployeeDataButton";
            this.consultEmployeeDataButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.consultEmployeeDataButton.Size = new System.Drawing.Size(250, 40);
            this.consultEmployeeDataButton.TabIndex = 10;
            this.consultEmployeeDataButton.Text = "Consultar Dados";
            this.consultEmployeeDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultEmployeeDataButton.UseVisualStyleBackColor = true;
            this.consultEmployeeDataButton.Click += new System.EventHandler(this.consultEmployeeDataButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddEmployeeButton.Location = new System.Drawing.Point(0, 0);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AddEmployeeButton.Size = new System.Drawing.Size(250, 40);
            this.AddEmployeeButton.TabIndex = 9;
            this.AddEmployeeButton.Text = "Cadastrar";
            this.AddEmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeButton.ForeColor = System.Drawing.Color.LightGray;
            this.EmployeeButton.Location = new System.Drawing.Point(0, 230);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EmployeeButton.Size = new System.Drawing.Size(250, 70);
            this.EmployeeButton.TabIndex = 5;
            this.EmployeeButton.Text = "Funcionários";
            this.EmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.deactivateClientButton);
            this.clientPanel.Controls.Add(this.ChangeDataClientButton);
            this.clientPanel.Controls.Add(this.ConsultClientDataButton);
            this.clientPanel.Controls.Add(this.AddClientButton);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientPanel.Location = new System.Drawing.Point(0, 70);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(250, 160);
            this.clientPanel.TabIndex = 1;
            // 
            // deactivateClientButton
            // 
            this.deactivateClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactivateClientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deactivateClientButton.FlatAppearance.BorderSize = 0;
            this.deactivateClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.deactivateClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deactivateClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deactivateClientButton.ForeColor = System.Drawing.Color.LightGray;
            this.deactivateClientButton.Location = new System.Drawing.Point(0, 120);
            this.deactivateClientButton.Name = "deactivateClientButton";
            this.deactivateClientButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.deactivateClientButton.Size = new System.Drawing.Size(250, 40);
            this.deactivateClientButton.TabIndex = 3;
            this.deactivateClientButton.Text = "Desativar Cadastro";
            this.deactivateClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deactivateClientButton.UseVisualStyleBackColor = true;
            this.deactivateClientButton.Click += new System.EventHandler(this.deactivateClientButton_Click);
            // 
            // ChangeDataClientButton
            // 
            this.ChangeDataClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeDataClientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeDataClientButton.FlatAppearance.BorderSize = 0;
            this.ChangeDataClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.ChangeDataClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeDataClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeDataClientButton.ForeColor = System.Drawing.Color.LightGray;
            this.ChangeDataClientButton.Location = new System.Drawing.Point(0, 80);
            this.ChangeDataClientButton.Name = "ChangeDataClientButton";
            this.ChangeDataClientButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ChangeDataClientButton.Size = new System.Drawing.Size(250, 40);
            this.ChangeDataClientButton.TabIndex = 2;
            this.ChangeDataClientButton.Text = "Alterar Cadastro";
            this.ChangeDataClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeDataClientButton.UseVisualStyleBackColor = true;
            this.ChangeDataClientButton.Click += new System.EventHandler(this.ChangeDataClientButton_Click);
            // 
            // ConsultClientDataButton
            // 
            this.ConsultClientDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultClientDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultClientDataButton.FlatAppearance.BorderSize = 0;
            this.ConsultClientDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.ConsultClientDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultClientDataButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsultClientDataButton.ForeColor = System.Drawing.Color.LightGray;
            this.ConsultClientDataButton.Location = new System.Drawing.Point(0, 40);
            this.ConsultClientDataButton.Name = "ConsultClientDataButton";
            this.ConsultClientDataButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ConsultClientDataButton.Size = new System.Drawing.Size(250, 40);
            this.ConsultClientDataButton.TabIndex = 1;
            this.ConsultClientDataButton.Text = "Consultar Dados";
            this.ConsultClientDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultClientDataButton.UseVisualStyleBackColor = true;
            this.ConsultClientDataButton.Click += new System.EventHandler(this.ConsultClientDataButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddClientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClientButton.FlatAppearance.BorderSize = 0;
            this.AddClientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.AddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddClientButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddClientButton.Location = new System.Drawing.Point(0, 0);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AddClientButton.Size = new System.Drawing.Size(250, 40);
            this.AddClientButton.TabIndex = 0;
            this.AddClientButton.Text = "Cadastrar";
            this.AddClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientButton.FlatAppearance.BorderSize = 0;
            this.clientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientButton.ForeColor = System.Drawing.Color.LightGray;
            this.clientButton.Location = new System.Drawing.Point(0, 0);
            this.clientButton.Name = "clientButton";
            this.clientButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.clientButton.Size = new System.Drawing.Size(250, 70);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Clientes";
            this.clientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.logoLabel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(250, 0);
            this.controlPanel.MinimumSize = new System.Drawing.Size(808, 520);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(808, 521);
            this.controlPanel.TabIndex = 4;
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.logoLabel.Location = new System.Drawing.Point(0, 0);
            this.logoLabel.MinimumSize = new System.Drawing.Size(503, 139);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(808, 521);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "Ada Credit";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1058, 521);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1074, 560);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ada Credit";
            this.sideMenuPanel.ResumeLayout(false);
            this.reportsPanel.ResumeLayout(false);
            this.transactionsPanel.ResumeLayout(false);
            this.employeePanel.ResumeLayout(false);
            this.clientPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sideMenuPanel;
        private Button clientButton;
        private Panel clientPanel;
        private Button AddClientButton;
        private Button deactivateClientButton;
        private Button ChangeDataClientButton;
        private Button ConsultClientDataButton;
        private Button EmployeeButton;
        private Panel employeePanel;
        private Button exitButton;
        private Panel reportsPanel;
        private Button failedTransactionsButton;
        private Button activeEmployeesButton;
        private Button InactiveClientsButton;
        private Button activeClientsButton;
        private Button reportsButton;
        private Panel transactionsPanel;
        private Button processTransactionsButton;
        private Button transactionsButton;
        private Panel controlPanel;
        private Label logoLabel;
        private Button deactivateEmployeeButton;
        private Button changeEmployeeDataButton;
        private Button consultEmployeeDataButton;
        private Button AddEmployeeButton;
    }
}