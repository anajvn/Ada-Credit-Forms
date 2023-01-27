namespace TesteForm.UseCasesForms
{
    partial class ChangeDataClient
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
            this.infoInput = new System.Windows.Forms.TextBox();
            this.changeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.documentInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.changesCB = new System.Windows.Forms.ComboBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.addNewClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoInput
            // 
            this.infoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoInput.Location = new System.Drawing.Point(320, 144);
            this.infoInput.Name = "infoInput";
            this.infoInput.Size = new System.Drawing.Size(400, 23);
            this.infoInput.TabIndex = 15;
            // 
            // changeInfo
            // 
            this.changeInfo.AutoSize = true;
            this.changeInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.changeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeInfo.Location = new System.Drawing.Point(184, 144);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(135, 21);
            this.changeInfo.TabIndex = 13;
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
            this.label1.TabIndex = 11;
            this.label1.Text = "Alterar Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(176, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(549, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "                                                                            ";
            // 
            // documentInput
            // 
            this.documentInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentInput.Location = new System.Drawing.Point(88, 88);
            this.documentInput.Name = "documentInput";
            this.documentInput.Size = new System.Drawing.Size(632, 23);
            this.documentInput.TabIndex = 18;
            this.documentInput.Text = "Somente números";
            this.documentInput.Enter += new System.EventHandler(this.documentInput_Enter_1);
            this.documentInput.Leave += new System.EventHandler(this.documentInput_Leave_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 16;
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
            this.label8.TabIndex = 17;
            this.label8.Text = "                                                                                 " +
    "                ";
            // 
            // changesCB
            // 
            this.changesCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changesCB.FormattingEnabled = true;
            this.changesCB.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Telefone",
            "Endereço"});
            this.changesCB.Location = new System.Drawing.Point(32, 136);
            this.changesCB.Name = "changesCB";
            this.changesCB.Size = new System.Drawing.Size(136, 29);
            this.changesCB.TabIndex = 19;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.Location = new System.Drawing.Point(600, 376);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(120, 64);
            this.goBackButton.TabIndex = 22;
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
            this.label11.TabIndex = 21;
            this.label11.Text = "label11";
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewClientButton.Location = new System.Drawing.Point(472, 376);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.Size = new System.Drawing.Size(120, 64);
            this.addNewClientButton.TabIndex = 20;
            this.addNewClientButton.Text = "Alterar";
            this.addNewClientButton.UseVisualStyleBackColor = true;
            this.addNewClientButton.Click += new System.EventHandler(this.addNewClientButton_Click);
            // 
            // ChangeDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 482);
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
            this.Controls.Add(this.label7);
            this.Name = "ChangeDataClient";
            this.Text = "ChangeDataClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox infoInput;
        private Label changeInfo;
        private Label label1;
        private Label label2;
        private Label label7;
        private TextBox documentInput;
        private Label label4;
        private Label label8;
        private ComboBox changesCB;
        private Button goBackButton;
        private Label label11;
        private Button addNewClientButton;
    }
}