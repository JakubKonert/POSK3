
namespace POSK3.Ekrany
{
    partial class LiniaProdukcyjnaForm
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
            this.WyjscieButton = new System.Windows.Forms.Button();
            this.TempProcLabel = new System.Windows.Forms.Label();
            this.TempProcInfoLabel = new System.Windows.Forms.Label();
            this.WykProcLabel = new System.Windows.Forms.Label();
            this.WykProcInfoLabel = new System.Windows.Forms.Label();
            this.PredWentlabel = new System.Windows.Forms.Label();
            this.PredWentInfoLabel = new System.Windows.Forms.Label();
            this.TempProcButton = new System.Windows.Forms.Button();
            this.WykProcButton = new System.Windows.Forms.Button();
            this.PredWentButton = new System.Windows.Forms.Button();
            this.PrzerwaButton = new System.Windows.Forms.Button();
            this.LosoweZdarzenieTimer = new System.Windows.Forms.Timer(this.components);
            this.JakDlugoTempTimer = new System.Windows.Forms.Timer(this.components);
            this.JakDlugoWykTimer = new System.Windows.Forms.Timer(this.components);
            this.JakDlugoPredTimer = new System.Windows.Forms.Timer(this.components);
            this.LosoweOstrzezenieTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WyjscieButton
            // 
            this.WyjscieButton.Location = new System.Drawing.Point(436, 620);
            this.WyjscieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WyjscieButton.Name = "WyjscieButton";
            this.WyjscieButton.Size = new System.Drawing.Size(122, 50);
            this.WyjscieButton.TabIndex = 0;
            this.WyjscieButton.Text = "Wyloguj";
            this.WyjscieButton.UseVisualStyleBackColor = true;
            this.WyjscieButton.Click += new System.EventHandler(this.WyjscieButton_Click);
            // 
            // TempProcLabel
            // 
            this.TempProcLabel.AutoSize = true;
            this.TempProcLabel.Location = new System.Drawing.Point(381, 14);
            this.TempProcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TempProcLabel.Name = "TempProcLabel";
            this.TempProcLabel.Size = new System.Drawing.Size(216, 25);
            this.TempProcLabel.TabIndex = 1;
            this.TempProcLabel.Text = "Temperatura procesora\r\n";
            // 
            // TempProcInfoLabel
            // 
            this.TempProcInfoLabel.AutoSize = true;
            this.TempProcInfoLabel.Location = new System.Drawing.Point(402, 64);
            this.TempProcInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TempProcInfoLabel.Name = "TempProcInfoLabel";
            this.TempProcInfoLabel.Size = new System.Drawing.Size(64, 25);
            this.TempProcInfoLabel.TabIndex = 2;
            this.TempProcInfoLabel.Text = "label2";
            // 
            // WykProcLabel
            // 
            this.WykProcLabel.AutoSize = true;
            this.WykProcLabel.Location = new System.Drawing.Point(381, 184);
            this.WykProcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WykProcLabel.Name = "WykProcLabel";
            this.WykProcLabel.Size = new System.Drawing.Size(233, 25);
            this.WykProcLabel.TabIndex = 3;
            this.WykProcLabel.Text = "Wykorzystanie procesora";
            // 
            // WykProcInfoLabel
            // 
            this.WykProcInfoLabel.AutoSize = true;
            this.WykProcInfoLabel.Location = new System.Drawing.Point(402, 231);
            this.WykProcInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WykProcInfoLabel.Name = "WykProcInfoLabel";
            this.WykProcInfoLabel.Size = new System.Drawing.Size(64, 25);
            this.WykProcInfoLabel.TabIndex = 4;
            this.WykProcInfoLabel.Text = "label4";
            // 
            // PredWentlabel
            // 
            this.PredWentlabel.AutoSize = true;
            this.PredWentlabel.Location = new System.Drawing.Point(385, 369);
            this.PredWentlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PredWentlabel.Name = "PredWentlabel";
            this.PredWentlabel.Size = new System.Drawing.Size(212, 25);
            this.PredWentlabel.TabIndex = 5;
            this.PredWentlabel.Text = "Prędkość wentylatorów";
            // 
            // PredWentInfoLabel
            // 
            this.PredWentInfoLabel.AutoSize = true;
            this.PredWentInfoLabel.Location = new System.Drawing.Point(402, 432);
            this.PredWentInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PredWentInfoLabel.Name = "PredWentInfoLabel";
            this.PredWentInfoLabel.Size = new System.Drawing.Size(64, 25);
            this.PredWentInfoLabel.TabIndex = 6;
            this.PredWentInfoLabel.Text = "label6";
            // 
            // TempProcButton
            // 
            this.TempProcButton.Location = new System.Drawing.Point(348, 107);
            this.TempProcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TempProcButton.Name = "TempProcButton";
            this.TempProcButton.Size = new System.Drawing.Size(290, 36);
            this.TempProcButton.TabIndex = 7;
            this.TempProcButton.Text = "Zwiększ moc wentylatorów";
            this.TempProcButton.UseVisualStyleBackColor = true;
            this.TempProcButton.Click += new System.EventHandler(this.TempProcButton_Click);
            // 
            // WykProcButton
            // 
            this.WykProcButton.Location = new System.Drawing.Point(357, 279);
            this.WykProcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WykProcButton.Name = "WykProcButton";
            this.WykProcButton.Size = new System.Drawing.Size(294, 36);
            this.WykProcButton.TabIndex = 8;
            this.WykProcButton.Text = "Wyłącz nieużywane programy";
            this.WykProcButton.UseVisualStyleBackColor = true;
            this.WykProcButton.Click += new System.EventHandler(this.WykProcButton_Click);
            // 
            // PredWentButton
            // 
            this.PredWentButton.Location = new System.Drawing.Point(357, 488);
            this.PredWentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PredWentButton.Name = "PredWentButton";
            this.PredWentButton.Size = new System.Drawing.Size(273, 36);
            this.PredWentButton.TabIndex = 9;
            this.PredWentButton.Text = "Zmniejsz moc wentylatorów";
            this.PredWentButton.UseVisualStyleBackColor = true;
            this.PredWentButton.Click += new System.EventHandler(this.PredWentButton_Click);
            // 
            // PrzerwaButton
            // 
            this.PrzerwaButton.Location = new System.Drawing.Point(782, 600);
            this.PrzerwaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrzerwaButton.Name = "PrzerwaButton";
            this.PrzerwaButton.Size = new System.Drawing.Size(192, 70);
            this.PrzerwaButton.TabIndex = 10;
            this.PrzerwaButton.Text = "Przerwa na kawę";
            this.PrzerwaButton.UseVisualStyleBackColor = true;
            this.PrzerwaButton.Click += new System.EventHandler(this.PrzerwaButton_Click);
            // 
            // LosoweZdarzenieTimer
            // 
            this.LosoweZdarzenieTimer.Enabled = true;
            this.LosoweZdarzenieTimer.Interval = 1000;
            this.LosoweZdarzenieTimer.Tick += new System.EventHandler(this.LosoweZdarzenieTimer_Tick);
            // 
            // JakDlugoTempTimer
            // 
            this.JakDlugoTempTimer.Interval = 1000;
            this.JakDlugoTempTimer.Tick += new System.EventHandler(this.JakDlugoTempTimer_Tick);
            // 
            // JakDlugoWykTimer
            // 
            this.JakDlugoWykTimer.Interval = 1000;
            this.JakDlugoWykTimer.Tick += new System.EventHandler(this.JakDlugoWykTimer_Tick);
            // 
            // JakDlugoPredTimer
            // 
            this.JakDlugoPredTimer.Interval = 1000;
            this.JakDlugoPredTimer.Tick += new System.EventHandler(this.JakDlugoPredTimer_Tick);
            // 
            // LosoweOstrzezenieTimer
            // 
            this.LosoweOstrzezenieTimer.Enabled = true;
            this.LosoweOstrzezenieTimer.Interval = 1000;
            this.LosoweOstrzezenieTimer.Tick += new System.EventHandler(this.LosoweOstrzezenieTimer_Tick);
            // 
            // LiniaProdukcyjnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 703);
            this.Controls.Add(this.PrzerwaButton);
            this.Controls.Add(this.PredWentButton);
            this.Controls.Add(this.WykProcButton);
            this.Controls.Add(this.TempProcButton);
            this.Controls.Add(this.PredWentInfoLabel);
            this.Controls.Add(this.PredWentlabel);
            this.Controls.Add(this.WykProcInfoLabel);
            this.Controls.Add(this.WykProcLabel);
            this.Controls.Add(this.TempProcInfoLabel);
            this.Controls.Add(this.TempProcLabel);
            this.Controls.Add(this.WyjscieButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LiniaProdukcyjnaForm";
            this.Text = "LiniaProdukcyjnaForm";
            this.Load += new System.EventHandler(this.LiniaProdukcyjnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WyjscieButton;
        private System.Windows.Forms.Label TempProcLabel;
        private System.Windows.Forms.Label TempProcInfoLabel;
        private System.Windows.Forms.Label WykProcLabel;
        private System.Windows.Forms.Label WykProcInfoLabel;
        private System.Windows.Forms.Label PredWentlabel;
        private System.Windows.Forms.Label PredWentInfoLabel;
        private System.Windows.Forms.Button TempProcButton;
        private System.Windows.Forms.Button WykProcButton;
        private System.Windows.Forms.Button PredWentButton;
        private System.Windows.Forms.Button PrzerwaButton;
        private System.Windows.Forms.Timer LosoweZdarzenieTimer;
        private System.Windows.Forms.Timer JakDlugoTempTimer;
        private System.Windows.Forms.Timer JakDlugoWykTimer;
        private System.Windows.Forms.Timer JakDlugoPredTimer;
        private System.Windows.Forms.Timer LosoweOstrzezenieTimer;
    }
}