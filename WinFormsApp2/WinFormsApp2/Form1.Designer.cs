namespace WinFormsApp2
{
    partial class Form1
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
            ekranLabel = new Label();
            rakam1Button = new Button();
            rakam2Button = new Button();
            rakam3Button = new Button();
            rakam6Button = new Button();
            rakam5Button = new Button();
            rakam4Button = new Button();
            esittirButton = new Button();
            rakam0Button = new Button();
            temizleButton = new Button();
            rakam9Button = new Button();
            rakam8Button = new Button();
            rakam7Button = new Button();
            carpiButton = new Button();
            boluButton = new Button();
            eksiButton = new Button();
            artiButton = new Button();
            SuspendLayout();
            // 
            // ekranLabel
            // 
            ekranLabel.BackColor = Color.White;
            ekranLabel.BorderStyle = BorderStyle.FixedSingle;
            ekranLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ekranLabel.Location = new Point(29, 33);
            ekranLabel.Margin = new Padding(4, 0, 4, 0);
            ekranLabel.Name = "ekranLabel";
            ekranLabel.Size = new Size(327, 60);
            ekranLabel.TabIndex = 0;
            ekranLabel.Text = "0";
            ekranLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rakam1Button
            // 
            rakam1Button.BackColor = Color.Orange;
            rakam1Button.Location = new Point(29, 118);
            rakam1Button.Name = "rakam1Button";
            rakam1Button.Size = new Size(75, 75);
            rakam1Button.TabIndex = 1;
            rakam1Button.Text = "1";
            rakam1Button.UseVisualStyleBackColor = false;
            rakam1Button.Click += rakam1Button_Click;
            // 
            // rakam2Button
            // 
            rakam2Button.BackColor = Color.Orange;
            rakam2Button.Location = new Point(110, 118);
            rakam2Button.Name = "rakam2Button";
            rakam2Button.Size = new Size(75, 75);
            rakam2Button.TabIndex = 2;
            rakam2Button.Text = "2";
            rakam2Button.UseVisualStyleBackColor = false;
            rakam2Button.Click += rakam2Button_Click;
            // 
            // rakam3Button
            // 
            rakam3Button.BackColor = Color.Orange;
            rakam3Button.Location = new Point(191, 118);
            rakam3Button.Name = "rakam3Button";
            rakam3Button.Size = new Size(75, 75);
            rakam3Button.TabIndex = 3;
            rakam3Button.Text = "3";
            rakam3Button.UseVisualStyleBackColor = false;
            rakam3Button.Click += rakam3Button_Click;
            // 
            // rakam6Button
            // 
            rakam6Button.BackColor = Color.Orange;
            rakam6Button.Location = new Point(191, 199);
            rakam6Button.Name = "rakam6Button";
            rakam6Button.Size = new Size(75, 75);
            rakam6Button.TabIndex = 6;
            rakam6Button.Text = "6";
            rakam6Button.UseVisualStyleBackColor = false;
            rakam6Button.Click += rakam6Button_Click;
            // 
            // rakam5Button
            // 
            rakam5Button.BackColor = Color.Orange;
            rakam5Button.Location = new Point(110, 199);
            rakam5Button.Name = "rakam5Button";
            rakam5Button.Size = new Size(75, 75);
            rakam5Button.TabIndex = 5;
            rakam5Button.Text = "5";
            rakam5Button.UseVisualStyleBackColor = false;
            rakam5Button.Click += rakam5Button_Click;
            // 
            // rakam4Button
            // 
            rakam4Button.BackColor = Color.Orange;
            rakam4Button.Location = new Point(29, 199);
            rakam4Button.Name = "rakam4Button";
            rakam4Button.Size = new Size(75, 75);
            rakam4Button.TabIndex = 4;
            rakam4Button.Text = "4";
            rakam4Button.UseVisualStyleBackColor = false;
            rakam4Button.Click += rakam4Button_Click;
            // 
            // esittirButton
            // 
            esittirButton.BackColor = Color.FromArgb(255, 192, 192);
            esittirButton.Location = new Point(191, 361);
            esittirButton.Name = "esittirButton";
            esittirButton.Size = new Size(75, 75);
            esittirButton.TabIndex = 9;
            esittirButton.Text = "=";
            esittirButton.UseVisualStyleBackColor = false;
            esittirButton.Click += esittirButton_Click;
            // 
            // rakam0Button
            // 
            rakam0Button.BackColor = Color.Orange;
            rakam0Button.Location = new Point(110, 361);
            rakam0Button.Name = "rakam0Button";
            rakam0Button.Size = new Size(75, 75);
            rakam0Button.TabIndex = 8;
            rakam0Button.Text = "0";
            rakam0Button.UseVisualStyleBackColor = false;
            rakam0Button.Click += rakam0Button_Click;
            // 
            // temizleButton
            // 
            temizleButton.BackColor = Color.OrangeRed;
            temizleButton.Location = new Point(29, 361);
            temizleButton.Name = "temizleButton";
            temizleButton.Size = new Size(75, 75);
            temizleButton.TabIndex = 7;
            temizleButton.Text = "C";
            temizleButton.UseVisualStyleBackColor = false;
            temizleButton.Click += temizleButton_Click;
            // 
            // rakam9Button
            // 
            rakam9Button.BackColor = Color.Orange;
            rakam9Button.Location = new Point(191, 280);
            rakam9Button.Name = "rakam9Button";
            rakam9Button.Size = new Size(75, 75);
            rakam9Button.TabIndex = 12;
            rakam9Button.Text = "9";
            rakam9Button.UseVisualStyleBackColor = false;
            rakam9Button.Click += rakam9Button_Click;
            // 
            // rakam8Button
            // 
            rakam8Button.BackColor = Color.Orange;
            rakam8Button.Location = new Point(110, 280);
            rakam8Button.Name = "rakam8Button";
            rakam8Button.Size = new Size(75, 75);
            rakam8Button.TabIndex = 11;
            rakam8Button.Text = "8";
            rakam8Button.UseVisualStyleBackColor = false;
            rakam8Button.Click += rakam8Button_Click;
            // 
            // rakam7Button
            // 
            rakam7Button.BackColor = Color.Orange;
            rakam7Button.Location = new Point(29, 280);
            rakam7Button.Name = "rakam7Button";
            rakam7Button.Size = new Size(75, 75);
            rakam7Button.TabIndex = 10;
            rakam7Button.Text = "7";
            rakam7Button.UseVisualStyleBackColor = false;
            rakam7Button.Click += rakam7Button_Click;
            // 
            // carpiButton
            // 
            carpiButton.BackColor = Color.Chartreuse;
            carpiButton.Location = new Point(281, 280);
            carpiButton.Name = "carpiButton";
            carpiButton.Size = new Size(75, 75);
            carpiButton.TabIndex = 16;
            carpiButton.Text = "X";
            carpiButton.UseVisualStyleBackColor = false;
            carpiButton.Click += carpiButton_Click;
            // 
            // boluButton
            // 
            boluButton.BackColor = Color.Chartreuse;
            boluButton.Location = new Point(281, 361);
            boluButton.Name = "boluButton";
            boluButton.Size = new Size(75, 75);
            boluButton.TabIndex = 15;
            boluButton.Text = "/";
            boluButton.UseVisualStyleBackColor = false;
            boluButton.Click += boluButton_Click;
            // 
            // eksiButton
            // 
            eksiButton.BackColor = Color.Chartreuse;
            eksiButton.Location = new Point(281, 199);
            eksiButton.Name = "eksiButton";
            eksiButton.Size = new Size(75, 75);
            eksiButton.TabIndex = 14;
            eksiButton.Text = "-";
            eksiButton.UseVisualStyleBackColor = false;
            eksiButton.Click += eksiButton_Click;
            // 
            // artiButton
            // 
            artiButton.BackColor = Color.Chartreuse;
            artiButton.Location = new Point(281, 118);
            artiButton.Name = "artiButton";
            artiButton.Size = new Size(75, 75);
            artiButton.TabIndex = 13;
            artiButton.Text = "+";
            artiButton.UseVisualStyleBackColor = false;
            artiButton.Click += artiButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 456);
            Controls.Add(carpiButton);
            Controls.Add(boluButton);
            Controls.Add(eksiButton);
            Controls.Add(artiButton);
            Controls.Add(rakam9Button);
            Controls.Add(rakam8Button);
            Controls.Add(rakam7Button);
            Controls.Add(esittirButton);
            Controls.Add(rakam0Button);
            Controls.Add(temizleButton);
            Controls.Add(rakam6Button);
            Controls.Add(rakam5Button);
            Controls.Add(rakam4Button);
            Controls.Add(rakam3Button);
            Controls.Add(rakam2Button);
            Controls.Add(rakam1Button);
            Controls.Add(ekranLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hesap makinesi";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label ekranLabel;
        private Button rakam1Button;
        private Button rakam2Button;
        private Button rakam3Button;
        private Button rakam6Button;
        private Button rakam5Button;
        private Button rakam4Button;
        private Button esittirButton;
        private Button rakam0Button;
        private Button temizleButton;
        private Button rakam9Button;
        private Button rakam8Button;
        private Button rakam7Button;
        private Button carpiButton;
        private Button boluButton;
        private Button eksiButton;
        private Button artiButton;
    }
}