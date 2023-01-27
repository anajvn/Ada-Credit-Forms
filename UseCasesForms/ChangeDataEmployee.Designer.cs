namespace TesteForm.UseCasesForms
{
    partial class ChangeDataEmployee
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.addNewClientButton = new System.Windows.Forms.Button();
            this.changesCB = new System.Windows.Forms.ComboBox();
            this.documentInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.infoInput = new System.Windows.Forms.TextBox();
            this.changeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeInfoBG = new System.Windows.Forms.Label();
            this.info2TB = new System.Windows.Forms.TextBox();
            this.info2Lb = new System.Windows.Forms.Label();
            this.info2BG = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.Location = new System.Drawing.Point(600, 376);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(120, 64);
            this.goBackButton.TabIndex = 34;
            this.goBackButton.Text = "Fechar";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(48, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "label11";
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewClientButton.Location = new System.Drawing.Point(472, 376);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.Size = new System.Drawing.Size(120, 64);
            this.addNewClientButton.TabIndex = 32;
            this.addNewClientButton.Text = "Alterar";
            this.addNewClientButton.UseVisualStyleBackColor = true;
            this.addNewClientButton.Click += new System.EventHandler(this.addNewClientButton_Click);
            // 
            // changesCB
            // 
            this.changesCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changesCB.FormattingEnabled = true;
            this.changesCB.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Usuário",
            "Senha"});
            this.changesCB.Location = new System.Drawing.Point(32, 136);
            this.changesCB.Name = "changesCB";
            this.changesCB.Size = new System.Drawing.Size(136, 29);
            this.changesCB.TabIndex = 31;
            this.changesCB.Text = "Escolha um item";
            // 
            // documentInput
            // 
            this.documentInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentInput.Location = new System.Drawing.Point(88, 88);
            this.documentInput.Name = "documentInput";
            this.documentInput.Size = new System.Drawing.Size(632, 23);
            this.documentInput.TabIndex = 30;
            this.documentInput.Text = "Somente Números";
            this.documentInput.Enter += new System.EventHandler(this.documentInput_Enter);
            this.documentInput.Leave += new System.EventHandler(this.documentInput_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(696, 37);
            this.label8.TabIndex = 29;
            this.label8.Text = "                                                                                 " +
    "                ";
            // 
            // infoInput
            // 
            this.infoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoInput.Location = new System.Drawing.Point(320, 144);
            this.infoInput.Name = "infoInput";
            this.infoInput.Size = new System.Drawing.Size(400, 23);
            this.infoInput.TabIndex = 27;
            // 
            // changeInfo
            // 
            this.changeInfo.AutoSize = true;
            this.changeInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeInfo.Location = new System.Drawing.Point(184, 144);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(135, 21);
            this.changeInfo.TabIndex = 25;
            this.changeInfo.Text = "Nova informação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Alterar Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________________________________________________";
            // 
            // changeInfoBG
            // 
            this.changeInfoBG.AutoSize = true;
            this.changeInfoBG.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeInfoBG.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeInfoBG.Location = new System.Drawing.Point(176, 136);
            this.changeInfoBG.Name = "changeInfoBG";
            this.changeInfoBG.Size = new System.Drawing.Size(549, 37);
            this.changeInfoBG.TabIndex = 26;
            this.changeInfoBG.Text = "                                                                            ";
            // 
            // info2TB
            // 
            this.info2TB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info2TB.Location = new System.Drawing.Point(320, 192);
            this.info2TB.Name = "info2TB";
            this.info2TB.PasswordChar = '*';
            this.info2TB.Size = new System.Drawing.Size(400, 23);
            this.info2TB.TabIndex = 37;
            // 
            // info2Lb
            // 
            this.info2Lb.AutoSize = true;
            this.info2Lb.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.info2Lb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info2Lb.Location = new System.Drawing.Point(184, 192);
            this.info2Lb.Name = "info2Lb";
            this.info2Lb.Size = new System.Drawing.Size(115, 21);
            this.info2Lb.TabIndex = 35;
            this.info2Lb.Text = "Repita a senha";
            // 
            // info2BG
            // 
            this.info2BG.AutoSize = true;
            this.info2BG.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.info2BG.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info2BG.Location = new System.Drawing.Point(176, 184);
            this.info2BG.Name = "info2BG";
            this.info2BG.Size = new System.Drawing.Size(549, 37);
            this.info2BG.TabIndex = 36;
            this.info2BG.Text = "                                                                            ";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(32, 184);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(136, 23);
            this.selectButton.TabIndex = 38;
            this.selectButton.Text = "Selecionar";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // ChangeDataEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.info2TB);
            this.Controls.Add(this.info2Lb);
            this.Controls.Add(this.info2BG);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addNewClientButton);
            this.Controls.Add(this.changesCB);
            this.Controls.Add(this.documentInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.infoInput);
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeInfoBG);
            this.Name = "ChangeDataEmployee";
            this.Text = "ChangeDataEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button goBackButton;
        private Label label11;
        private Button addNewClientButton;
        private ComboBox changesCB;
        private TextBox documentInput;
        private Label label4;
        private Label label8;
        private TextBox infoInput;
        private Label changeInfo;
        private Label label1;
        private Label label2;
        private Label changeInfoBG;
        private TextBox info2TB;
        private Label info2Lb;
        private Label info2BG;
        private Button selectButton;
    }
}