
namespace POSK3.Ekrany
{
    partial class LogowanieForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.HasłoTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.HasloLabel = new System.Windows.Forms.Label();
            this.DaneLabel = new System.Windows.Forms.Label();
            this.ZalogujButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(322, 126);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "Login";
            // 
            // HasłoTextBox
            // 
            this.HasłoTextBox.Location = new System.Drawing.Point(322, 215);
            this.HasłoTextBox.Name = "HasłoTextBox";
            this.HasłoTextBox.Size = new System.Drawing.Size(100, 22);
            this.HasłoTextBox.TabIndex = 1;
            this.HasłoTextBox.Text = "Hasło";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(216, 131);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(43, 17);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.Location = new System.Drawing.Point(216, 220);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(44, 17);
            this.HasloLabel.TabIndex = 3;
            this.HasloLabel.Text = "Hasło";
            // 
            // DaneLabel
            // 
            this.DaneLabel.AutoSize = true;
            this.DaneLabel.Location = new System.Drawing.Point(216, 27);
            this.DaneLabel.Name = "DaneLabel";
            this.DaneLabel.Size = new System.Drawing.Size(295, 17);
            this.DaneLabel.TabIndex = 4;
            this.DaneLabel.Text = "Wprowadź poprawne dane aby się zalogować";
            // 
            // ZalogujButtom
            // 
            this.ZalogujButtom.Location = new System.Drawing.Point(322, 340);
            this.ZalogujButtom.Name = "ZalogujButtom";
            this.ZalogujButtom.Size = new System.Drawing.Size(75, 23);
            this.ZalogujButtom.TabIndex = 5;
            this.ZalogujButtom.Text = "Zaloguj";
            this.ZalogujButtom.UseVisualStyleBackColor = true;
            this.ZalogujButtom.Click += new System.EventHandler(this.ZalogujButtom_Click);
            // 
            // LogowanieForm
            // 
            this.AcceptButton = this.ZalogujButtom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ZalogujButtom);
            this.Controls.Add(this.DaneLabel);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HasłoTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "LogowanieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogowanieForm";
            this.Load += new System.EventHandler(this.LogowanieForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogowanieForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox HasłoTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.Label DaneLabel;
        private System.Windows.Forms.Button ZalogujButtom;
    }
}