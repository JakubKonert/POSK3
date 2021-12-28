
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
            this.LoginTextBox.Location = new System.Drawing.Point(483, 197);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(148, 30);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "Login";
            // 
            // HasłoTextBox
            // 
            this.HasłoTextBox.Location = new System.Drawing.Point(483, 336);
            this.HasłoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HasłoTextBox.Name = "HasłoTextBox";
            this.HasłoTextBox.Size = new System.Drawing.Size(148, 30);
            this.HasłoTextBox.TabIndex = 1;
            this.HasłoTextBox.Text = "Hasło";
            this.HasłoTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(324, 202);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(60, 25);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.Location = new System.Drawing.Point(324, 341);
            this.HasloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(62, 25);
            this.HasloLabel.TabIndex = 3;
            this.HasloLabel.Text = "Hasło";
            // 
            // DaneLabel
            // 
            this.DaneLabel.AutoSize = true;
            this.DaneLabel.Location = new System.Drawing.Point(324, 42);
            this.DaneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DaneLabel.Name = "DaneLabel";
            this.DaneLabel.Size = new System.Drawing.Size(411, 25);
            this.DaneLabel.TabIndex = 4;
            this.DaneLabel.Text = "Wprowadź poprawne dane aby się zalogować";
            // 
            // ZalogujButtom
            // 
            this.ZalogujButtom.Location = new System.Drawing.Point(483, 515);
            this.ZalogujButtom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ZalogujButtom.Name = "ZalogujButtom";
            this.ZalogujButtom.Size = new System.Drawing.Size(112, 36);
            this.ZalogujButtom.TabIndex = 5;
            this.ZalogujButtom.Text = "Zaloguj";
            this.ZalogujButtom.UseVisualStyleBackColor = true;
            this.ZalogujButtom.Click += new System.EventHandler(this.ZalogujButtom_Click);
            // 
            // LogowanieForm
            // 
            this.AcceptButton = this.ZalogujButtom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.ZalogujButtom);
            this.Controls.Add(this.DaneLabel);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HasłoTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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