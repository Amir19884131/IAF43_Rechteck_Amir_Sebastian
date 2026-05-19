namespace Rechteckprojekt
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
            btnZoomOut = new Button();
            btnZoomIn = new Button();
            btnDrehen = new Button();
            tbxBreite = new TextBox();
            tbxHoehe = new TextBox();
            tbxUmfang = new TextBox();
            tbxDiagonale = new TextBox();
            tbxFlaeche = new TextBox();
            lblBreite = new Label();
            lblHoehe = new Label();
            lblUmfang = new Label();
            lblDiagonale = new Label();
            lblFlaeche = new Label();
            btnRechteck = new Button();
            pnlLinie = new Panel();
            SuspendLayout();
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(192, 415);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(111, 55);
            btnZoomOut.TabIndex = 0;
            btnZoomOut.Text = "-";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(66, 415);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(109, 55);
            btnZoomIn.TabIndex = 1;
            btnZoomIn.Text = "+";
            btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(66, 487);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(237, 68);
            btnDrehen.TabIndex = 2;
            btnDrehen.Text = "Drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(168, 64);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 3;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(168, 107);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 4;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(168, 236);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(135, 27);
            tbxUmfang.TabIndex = 5;
            // 
            // tbxDiagonale
            // 
            tbxDiagonale.Location = new Point(168, 285);
            tbxDiagonale.Name = "tbxDiagonale";
            tbxDiagonale.ReadOnly = true;
            tbxDiagonale.Size = new Size(135, 27);
            tbxDiagonale.TabIndex = 6;
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(168, 334);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.ReadOnly = true;
            tbxFlaeche.Size = new Size(135, 27);
            tbxFlaeche.TabIndex = 7;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(66, 71);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(55, 20);
            lblBreite.TabIndex = 8;
            lblBreite.Text = "Breite :";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(66, 114);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(52, 20);
            lblHoehe.TabIndex = 9;
            lblHoehe.Text = "Höhe :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(66, 243);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(69, 20);
            lblUmfang.TabIndex = 10;
            lblUmfang.Text = "Umfang :";
            // 
            // lblDiagonale
            // 
            lblDiagonale.AutoSize = true;
            lblDiagonale.Location = new Point(66, 292);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(85, 20);
            lblDiagonale.TabIndex = 11;
            lblDiagonale.Text = "Diagonale :";
            // 
            // lblFlaeche
            // 
            lblFlaeche.AutoSize = true;
            lblFlaeche.Location = new Point(66, 341);
            lblFlaeche.Name = "lblFlaeche";
            lblFlaeche.Size = new Size(58, 20);
            lblFlaeche.TabIndex = 12;
            lblFlaeche.Text = "Fläche :";
            // 
            // btnRechteck
            // 
            btnRechteck.Enabled = false;
            btnRechteck.Location = new Point(429, 101);
            btnRechteck.Name = "btnRechteck";
            btnRechteck.Size = new Size(459, 369);
            btnRechteck.TabIndex = 13;
            btnRechteck.Text = "Ich bin Rechteck (kein button)";
            btnRechteck.UseVisualStyleBackColor = true;
            // 
            // pnlLinie
            // 
            pnlLinie.BackColor = SystemColors.ActiveCaptionText;
            pnlLinie.Location = new Point(377, -1);
            pnlLinie.Name = "pnlLinie";
            pnlLinie.Size = new Size(4, 608);
            pnlLinie.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlLinie);
            Controls.Add(btnRechteck);
            Controls.Add(lblFlaeche);
            Controls.Add(lblDiagonale);
            Controls.Add(lblUmfang);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(tbxFlaeche);
            Controls.Add(tbxDiagonale);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(btnDrehen);
            Controls.Add(btnZoomIn);
            Controls.Add(btnZoomOut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZoomOut;
        private Button btnZoomIn;
        private Button btnDrehen;
        private TextBox tbxBreite;
        private TextBox tbxHoehe;
        private TextBox tbxUmfang;
        private TextBox tbxDiagonale;
        private TextBox tbxFlaeche;
        private Label lblBreite;
        private Label lblHoehe;
        private Label lblUmfang;
        private Label lblDiagonale;
        private Label lblFlaeche;
        private Button btnRechteck;
        private Panel pnlLinie;
    }
}
