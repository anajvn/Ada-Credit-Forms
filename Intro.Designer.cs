namespace TesteForm
{
    partial class Intro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Image = new System.Windows.Forms.Label();
            this.slogan = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.Image.Location = new System.Drawing.Point(282, 146);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(503, 139);
            this.Image.TabIndex = 0;
            this.Image.Text = "Ada Credit";
            this.Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.slogan.Location = new System.Drawing.Point(298, 269);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(459, 30);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "APRENDENDO JUNTOS A SER CADA VEZ MAIS!";
            // 
            // StartButton
            // 
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(87)))), ((int)(((byte)(116)))));
            this.StartButton.Location = new System.Drawing.Point(469, 433);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "ENTRAR";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1058, 521);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.slogan);
            this.Controls.Add(this.Image);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ada Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Image;
        private Label slogan;
        private Button StartButton;
    }
}