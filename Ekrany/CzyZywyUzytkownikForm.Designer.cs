
namespace POSK3.Ekrany
{
    partial class CzyZywyUzytkownikForm
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
            this.AktywnyButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PozostalyCzasLabel = new System.Windows.Forms.Label();
            this.ZywyUzytkownikTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AktywnyButton
            // 
            this.AktywnyButton.Location = new System.Drawing.Point(322, 312);
            this.AktywnyButton.Margin = new System.Windows.Forms.Padding(4);
            this.AktywnyButton.Name = "AktywnyButton";
            this.AktywnyButton.Size = new System.Drawing.Size(216, 104);
            this.AktywnyButton.TabIndex = 0;
            this.AktywnyButton.Text = "Jestem!";
            this.AktywnyButton.UseVisualStyleBackColor = true;
            this.AktywnyButton.Click += new System.EventHandler(this.AktywnyButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(176, 64);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(512, 25);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Wciśnij przycisk aby nie nastąpiło wylogowanie z systemu";
            // 
            // PozostalyCzasLabel
            // 
            this.PozostalyCzasLabel.AutoSize = true;
            this.PozostalyCzasLabel.Location = new System.Drawing.Point(67, 162);
            this.PozostalyCzasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PozostalyCzasLabel.Name = "PozostalyCzasLabel";
            this.PozostalyCzasLabel.Size = new System.Drawing.Size(17, 25);
            this.PozostalyCzasLabel.TabIndex = 2;
            this.PozostalyCzasLabel.Text = " ";
            // 
            // ZywyUzytkownikTimer
            // 
            this.ZywyUzytkownikTimer.Enabled = true;
            this.ZywyUzytkownikTimer.Interval = 1000;
            this.ZywyUzytkownikTimer.Tick += new System.EventHandler(this.ZywyUzytkownikTimer_Tick);
            // 
            // CzyZywyUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 464);
            this.Controls.Add(this.PozostalyCzasLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AktywnyButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CzyZywyUzytkownikForm";
            this.Text = "CzyZywyUzytkownikForm";
            this.Load += new System.EventHandler(this.CzyZywyUzytkownikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AktywnyButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label PozostalyCzasLabel;
        private System.Windows.Forms.Timer ZywyUzytkownikTimer;
    }
}