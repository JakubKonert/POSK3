
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
            this.AktywnyButton.Location = new System.Drawing.Point(330, 354);
            this.AktywnyButton.Name = "AktywnyButton";
            this.AktywnyButton.Size = new System.Drawing.Size(75, 23);
            this.AktywnyButton.TabIndex = 0;
            this.AktywnyButton.Text = "Jestem!";
            this.AktywnyButton.UseVisualStyleBackColor = true;
            this.AktywnyButton.Click += new System.EventHandler(this.AktywnyButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(242, 71);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(368, 17);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Wciśnij przycisk aby nie nastąpiło wylogowanie z systemu";
            // 
            // PozostalyCzasLabel
            // 
            this.PozostalyCzasLabel.AutoSize = true;
            this.PozostalyCzasLabel.Location = new System.Drawing.Point(166, 217);
            this.PozostalyCzasLabel.Name = "PozostalyCzasLabel";
            this.PozostalyCzasLabel.Size = new System.Drawing.Size(46, 17);
            this.PozostalyCzasLabel.TabIndex = 2;
            this.PozostalyCzasLabel.Text = "label2";
            // 
            // ZywyUzytkownikTimer
            // 
            this.ZywyUzytkownikTimer.Enabled = true;
            this.ZywyUzytkownikTimer.Interval = 1000;
            this.ZywyUzytkownikTimer.Tick += new System.EventHandler(this.ZywyUzytkownikTimer_Tick);
            // 
            // CzyZywyUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PozostalyCzasLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AktywnyButton);
            this.Name = "CzyZywyUzytkownikForm";
            this.Text = "CzyZywyUzytkownikForm";
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