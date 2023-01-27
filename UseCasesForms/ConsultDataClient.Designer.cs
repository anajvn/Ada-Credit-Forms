namespace TesteForm.UseCasesForms
{
    partial class ConsultDataClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.consultButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.byNameButton = new System.Windows.Forms.Button();
            this.byDocumentButton = new System.Windows.Forms.Button();
            this.byAccountButton = new System.Windows.Forms.Button();
            this.textInfo2 = new System.Windows.Forms.TextBox();
            this.info2 = new System.Windows.Forms.Label();
            this.backgroundInfo2 = new System.Windows.Forms.Label();
            this.clientsInfoTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientsInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________________________________________________";
            // 
            // messageInput
            // 
            this.messageInput.AutoSize = true;
            this.messageInput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.messageInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageInput.Location = new System.Drawing.Point(40, 168);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(37, 21);
            this.messageInput.TabIndex = 3;
            this.messageInput.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(696, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "                                                                                 " +
    "                ";
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInput.Location = new System.Drawing.Point(120, 168);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(600, 23);
            this.textInput.TabIndex = 11;
            this.textInput.Enter += new System.EventHandler(this.textInput_Enter);
            this.textInput.Leave += new System.EventHandler(this.textInput_Leave);
            // 
            // consultButton
            // 
            this.consultButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultButton.Location = new System.Drawing.Point(472, 376);
            this.consultButton.Name = "consultButton";
            this.consultButton.Size = new System.Drawing.Size(120, 64);
            this.consultButton.TabIndex = 14;
            this.consultButton.Text = "Consultar";
            this.consultButton.UseVisualStyleBackColor = true;
            this.consultButton.Click += new System.EventHandler(this.consultButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(96, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 34);
            this.label11.TabIndex = 15;
            this.label11.Text = "Não foi possível encontrar o cadastro.\r\nVerifique os dados ou cadastre um cliente" +
    " novo.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.Location = new System.Drawing.Point(600, 376);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(120, 64);
            this.goBackButton.TabIndex = 16;
            this.goBackButton.Text = "Fechar";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // byNameButton
            // 
            this.byNameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.byNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.byNameButton.Location = new System.Drawing.Point(160, 88);
            this.byNameButton.Name = "byNameButton";
            this.byNameButton.Size = new System.Drawing.Size(144, 55);
            this.byNameButton.TabIndex = 17;
            this.byNameButton.Text = "Consultar\r\npor Nome";
            this.byNameButton.UseVisualStyleBackColor = true;
            this.byNameButton.Click += new System.EventHandler(this.byNameButton_Click);
            // 
            // byDocumentButton
            // 
            this.byDocumentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.byDocumentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.byDocumentButton.Location = new System.Drawing.Point(328, 88);
            this.byDocumentButton.Name = "byDocumentButton";
            this.byDocumentButton.Size = new System.Drawing.Size(144, 55);
            this.byDocumentButton.TabIndex = 18;
            this.byDocumentButton.Text = "Consultar\r\npor CPF";
            this.byDocumentButton.UseVisualStyleBackColor = true;
            this.byDocumentButton.Click += new System.EventHandler(this.byDocumentButton_Click);
            // 
            // byAccountButton
            // 
            this.byAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.byAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.byAccountButton.Location = new System.Drawing.Point(496, 88);
            this.byAccountButton.Name = "byAccountButton";
            this.byAccountButton.Size = new System.Drawing.Size(144, 55);
            this.byAccountButton.TabIndex = 19;
            this.byAccountButton.Text = "Consultar\r\npor Conta";
            this.byAccountButton.UseVisualStyleBackColor = true;
            this.byAccountButton.Click += new System.EventHandler(this.byAccountButton_Click);
            // 
            // textInfo2
            // 
            this.textInfo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInfo2.Location = new System.Drawing.Point(120, 208);
            this.textInfo2.Name = "textInfo2";
            this.textInfo2.Size = new System.Drawing.Size(600, 23);
            this.textInfo2.TabIndex = 22;
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.info2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info2.Location = new System.Drawing.Point(40, 208);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(37, 21);
            this.info2.TabIndex = 20;
            this.info2.Text = "CPF";
            // 
            // backgroundInfo2
            // 
            this.backgroundInfo2.AutoSize = true;
            this.backgroundInfo2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backgroundInfo2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backgroundInfo2.Location = new System.Drawing.Point(32, 200);
            this.backgroundInfo2.Name = "backgroundInfo2";
            this.backgroundInfo2.Size = new System.Drawing.Size(696, 37);
            this.backgroundInfo2.TabIndex = 21;
            this.backgroundInfo2.Text = "                                                                                 " +
    "                ";
            // 
            // clientsInfoTable
            // 
            this.clientsInfoTable.AllowUserToAddRows = false;
            this.clientsInfoTable.AllowUserToDeleteRows = false;
            this.clientsInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Document,
            this.Phone,
            this.Address,
            this.AccountNumber,
            this.Branch,
            this.Balance,
            this.IsActive});
            this.clientsInfoTable.Location = new System.Drawing.Point(32, 248);
            this.clientsInfoTable.Name = "clientsInfoTable";
            this.clientsInfoTable.ReadOnly = true;
            this.clientsInfoTable.RowTemplate.Height = 25;
            this.clientsInfoTable.Size = new System.Drawing.Size(696, 120);
            this.clientsInfoTable.TabIndex = 23;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nome";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "CPF";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Endereço";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "Número da Conta";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Agência";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Saldo";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Situação";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(AdaCredit.UI.Domain.Client);
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "Document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Document";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            // 
            // ConsultDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.clientsInfoTable);
            this.Controls.Add(this.textInfo2);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.backgroundInfo2);
            this.Controls.Add(this.byAccountButton);
            this.Controls.Add(this.byDocumentButton);
            this.Controls.Add(this.byNameButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.consultButton);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.MinimizeBox = false;
            ((System.ComponentModel.ISupportInitialize)(this.clientsInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label messageInput;
        private Label label8;
        private TextBox textInput;
        private Button consultButton;
        private Label label11;
        private Button goBackButton;
        private Button byNameButton;
        private Button byDocumentButton;
        private Button byAccountButton;
        private TextBox textInfo2;
        private Label info2;
        private Label backgroundInfo2;
        private DataGridView clientsInfoTable;
        private BindingSource clientBindingSource;
        private DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Document;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn Branch;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn IsActive;
    }
}