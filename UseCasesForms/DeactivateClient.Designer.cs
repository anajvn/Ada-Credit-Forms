namespace TesteForm.UseCasesForms
{
    partial class DeactivateClient
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
            this.DeactivateButton = new System.Windows.Forms.Button();
            this.documentInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.goBackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.Location = new System.Drawing.Point(600, 376);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(120, 64);
            this.goBackButton.TabIndex = 24;
            this.goBackButton.Text = "Fechar";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(32, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "label11";
            // 
            // DeactivateButton
            // 
            this.DeactivateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeactivateButton.Location = new System.Drawing.Point(472, 376);
            this.DeactivateButton.Name = "DeactivateButton";
            this.DeactivateButton.Size = new System.Drawing.Size(120, 64);
            this.DeactivateButton.TabIndex = 22;
            this.DeactivateButton.Text = "Atualizar";
            this.DeactivateButton.UseVisualStyleBackColor = true;
            this.DeactivateButton.Click += new System.EventHandler(this.DeactivateButton_Click);
            // 
            // documentInput
            // 
            this.documentInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.documentInput.Location = new System.Drawing.Point(88, 96);
            this.documentInput.Name = "documentInput";
            this.documentInput.Size = new System.Drawing.Size(632, 23);
            this.documentInput.TabIndex = 21;
            this.documentInput.Text = "Somente Números";
            this.documentInput.Enter += new System.EventHandler(this.documentInput_Enter);
            this.documentInput.Leave += new System.EventHandler(this.documentInput_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Desativar/Ativar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(696, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "                                                                                 " +
    "                ";
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLb.Location = new System.Drawing.Point(32, 192);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(54, 21);
            this.resultLb.TabIndex = 25;
            this.resultLb.Text = "label3";
            // 
            // DeactivateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeactivateButton);
            this.Controls.Add(this.documentInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "DeactivateClient";
            this.Text = "DeactivateClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button goBackButton;
        private Label label11;
        private Button DeactivateButton;
        private TextBox documentInput;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label resultLb;
    }
}