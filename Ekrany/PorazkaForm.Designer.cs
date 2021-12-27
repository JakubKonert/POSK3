
namespace POSK3.Ekrany
{
    partial class PorazkaForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.OdliczanieWylogowaniaLabel = new System.Windows.Forms.Label();
            this.LicznikTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(33, 53);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(755, 17);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Twoja niestaraność spowodowała zniszczenie linii produkcyjnej. Następuje wylogowa" +
    "nie z systemu i zwolnienie z pracy.";
            // 
            // OdliczanieWylogowaniaLabel
            // 
            this.OdliczanieWylogowaniaLabel.AutoSize = true;
            this.OdliczanieWylogowaniaLabel.Location = new System.Drawing.Point(251, 105);
            this.OdliczanieWylogowaniaLabel.Name = "OdliczanieWylogowaniaLabel";
            this.OdliczanieWylogowaniaLabel.Size = new System.Drawing.Size(46, 17);
            this.OdliczanieWylogowaniaLabel.TabIndex = 1;
            this.OdliczanieWylogowaniaLabel.Text = "label2";
            // 
            // LicznikTimer
            // 
            this.LicznikTimer.Enabled = true;
            this.LicznikTimer.Interval = 1000;
            this.LicznikTimer.Tick += new System.EventHandler(this.LicznikTimer_Tick);
            // 
            // PorazkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 155);
            this.Controls.Add(this.OdliczanieWylogowaniaLabel);
            this.Controls.Add(this.InfoLabel);
            this.Name = "PorazkaForm";
            this.Text = "PorazkaForm";
            this.Load += new System.EventHandler(this.PorazkaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label OdliczanieWylogowaniaLabel;
        private System.Windows.Forms.Timer LicznikTimer;
    }
}