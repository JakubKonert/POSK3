
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
            this.InfoLabel.Location = new System.Drawing.Point(50, 83);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(1045, 25);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Twoja niestaraność spowodowała zniszczenie linii produkcyjnej. Następuje wylogowa" +
    "nie z systemu i zwolnienie z pracy.";
            // 
            // OdliczanieWylogowaniaLabel
            // 
            this.OdliczanieWylogowaniaLabel.AutoSize = true;
            this.OdliczanieWylogowaniaLabel.Location = new System.Drawing.Point(170, 162);
            this.OdliczanieWylogowaniaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OdliczanieWylogowaniaLabel.Name = "OdliczanieWylogowaniaLabel";
            this.OdliczanieWylogowaniaLabel.Size = new System.Drawing.Size(17, 25);
            this.OdliczanieWylogowaniaLabel.TabIndex = 1;
            this.OdliczanieWylogowaniaLabel.Text = " ";
            // 
            // LicznikTimer
            // 
            this.LicznikTimer.Enabled = true;
            this.LicznikTimer.Interval = 1000;
            this.LicznikTimer.Tick += new System.EventHandler(this.LicznikTimer_Tick);
            // 
            // PorazkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 242);
            this.Controls.Add(this.OdliczanieWylogowaniaLabel);
            this.Controls.Add(this.InfoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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