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

        private void InitializeComponent()
        {
            btnZoomOut = new Button();
            btnZoomIn = new Button();
            btnDrehen = new Button();
            tbxBreite = new TextBox();
            tbxHoehe = new TextBox();
            tbxUmfang = new TextBox();
            tbxDiagonaleCM = new TextBox();
            tbxFlaeche = new TextBox();
            lblBreite = new Label();
            lblHoehe = new Label();
            lblUmfang = new Label();
            lblDiagonale = new Label();
            lblFlaeche = new Label();
            btnRechteck = new Button();
            pnlLinie = new Panel();
            lblBreiteCM = new Label();
            lblHoeheCM = new Label();
            lblUmfangCM = new Label();
            lblDiagonaleCM = new Label();
            lblFleacheCM = new Label();
            tbxDiagonaleZOLL = new TextBox();
            lblDiagonaleZOLL = new Label();
            cbxFarben = new ComboBox();
            lblExtra = new Label();
            lblFarben = new Label();
            tbxTextinhalt = new TextBox();
            lblTextinhalt = new Label();
            tbxRand = new TextBox();
            lblRandCM = new Label();
            lblRand = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            lbxRechtecke = new ListBox();
            lblRechtecke = new Label();
            menuStrip1 = new MenuStrip();
            mnuMenu = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuSaveUnder = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(168, 340);
            btnZoomOut.Margin = new Padding(3, 2, 3, 2);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(97, 41);
            btnZoomOut.TabIndex = 0;
            btnZoomOut.Text = "-";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(58, 340);
            btnZoomIn.Margin = new Padding(3, 2, 3, 2);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(95, 41);
            btnZoomIn.TabIndex = 1;
            btnZoomIn.Text = "+";
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(58, 394);
            btnDrehen.Margin = new Padding(3, 2, 3, 2);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(207, 51);
            btnDrehen.TabIndex = 2;
            btnDrehen.Text = "Drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(147, 48);
            tbxBreite.Margin = new Padding(3, 2, 3, 2);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(88, 23);
            tbxBreite.TabIndex = 3;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(147, 93);
            tbxHoehe.Margin = new Padding(3, 2, 3, 2);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(88, 23);
            tbxHoehe.TabIndex = 4;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(147, 177);
            tbxUmfang.Margin = new Padding(3, 2, 3, 2);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.ReadOnly = true;
            tbxUmfang.Size = new Size(88, 23);
            tbxUmfang.TabIndex = 5;
            // 
            // tbxDiagonaleCM
            // 
            tbxDiagonaleCM.Location = new Point(147, 221);
            tbxDiagonaleCM.Margin = new Padding(3, 2, 3, 2);
            tbxDiagonaleCM.Name = "tbxDiagonaleCM";
            tbxDiagonaleCM.ReadOnly = true;
            tbxDiagonaleCM.Size = new Size(88, 23);
            tbxDiagonaleCM.TabIndex = 6;
            // 
            // tbxFlaeche
            // 
            tbxFlaeche.Location = new Point(147, 301);
            tbxFlaeche.Margin = new Padding(3, 2, 3, 2);
            tbxFlaeche.Name = "tbxFlaeche";
            tbxFlaeche.ReadOnly = true;
            tbxFlaeche.Size = new Size(88, 23);
            tbxFlaeche.TabIndex = 7;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(58, 56);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(43, 15);
            lblBreite.TabIndex = 8;
            lblBreite.Text = "Breite :";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(58, 101);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(42, 15);
            lblHoehe.TabIndex = 9;
            lblHoehe.Text = "Höhe :";
            // 
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(58, 185);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(56, 15);
            lblUmfang.TabIndex = 10;
            lblUmfang.Text = "Umfang :";
            // 
            // lblDiagonale
            // 
            lblDiagonale.AutoSize = true;
            lblDiagonale.Location = new Point(58, 229);
            lblDiagonale.Name = "lblDiagonale";
            lblDiagonale.Size = new Size(66, 15);
            lblDiagonale.TabIndex = 11;
            lblDiagonale.Text = "Diagonale :";
            // 
            // lblFlaeche
            // 
            lblFlaeche.AutoSize = true;
            lblFlaeche.Location = new Point(58, 309);
            lblFlaeche.Name = "lblFlaeche";
            lblFlaeche.Size = new Size(47, 15);
            lblFlaeche.TabIndex = 12;
            lblFlaeche.Text = "Fläche :";
            // 
            // btnRechteck
            // 
            btnRechteck.Enabled = false;
            btnRechteck.Location = new Point(806, 340);
            btnRechteck.Margin = new Padding(3, 2, 3, 2);
            btnRechteck.Name = "btnRechteck";
            btnRechteck.Size = new Size(508, 276);
            btnRechteck.TabIndex = 13;
            btnRechteck.Text = "Hier kann Ihr Text stehen";
            btnRechteck.UseVisualStyleBackColor = true;
            // 
            // pnlLinie
            // 
            pnlLinie.BackColor = SystemColors.ActiveCaptionText;
            pnlLinie.Location = new Point(330, -1);
            pnlLinie.Margin = new Padding(3, 2, 3, 2);
            pnlLinie.Name = "pnlLinie";
            pnlLinie.Size = new Size(4, 1000);
            pnlLinie.TabIndex = 14;
            // 
            // lblBreiteCM
            // 
            lblBreiteCM.AutoSize = true;
            lblBreiteCM.Location = new Point(241, 56);
            lblBreiteCM.Name = "lblBreiteCM";
            lblBreiteCM.Size = new Size(24, 15);
            lblBreiteCM.TabIndex = 15;
            lblBreiteCM.Text = "cm";
            // 
            // lblHoeheCM
            // 
            lblHoeheCM.AutoSize = true;
            lblHoeheCM.Location = new Point(241, 101);
            lblHoeheCM.Name = "lblHoeheCM";
            lblHoeheCM.Size = new Size(24, 15);
            lblHoeheCM.TabIndex = 16;
            lblHoeheCM.Text = "cm";
            // 
            // lblUmfangCM
            // 
            lblUmfangCM.AutoSize = true;
            lblUmfangCM.Location = new Point(241, 185);
            lblUmfangCM.Name = "lblUmfangCM";
            lblUmfangCM.Size = new Size(24, 15);
            lblUmfangCM.TabIndex = 17;
            lblUmfangCM.Text = "cm";
            // 
            // lblDiagonaleCM
            // 
            lblDiagonaleCM.AutoSize = true;
            lblDiagonaleCM.Location = new Point(241, 229);
            lblDiagonaleCM.Name = "lblDiagonaleCM";
            lblDiagonaleCM.Size = new Size(24, 15);
            lblDiagonaleCM.TabIndex = 18;
            lblDiagonaleCM.Text = "cm";
            // 
            // lblFleacheCM
            // 
            lblFleacheCM.AutoSize = true;
            lblFleacheCM.Location = new Point(241, 309);
            lblFleacheCM.Name = "lblFleacheCM";
            lblFleacheCM.Size = new Size(24, 15);
            lblFleacheCM.TabIndex = 19;
            lblFleacheCM.Text = "cm";
            // 
            // tbxDiagonaleZOLL
            // 
            tbxDiagonaleZOLL.Location = new Point(147, 261);
            tbxDiagonaleZOLL.Name = "tbxDiagonaleZOLL";
            tbxDiagonaleZOLL.ReadOnly = true;
            tbxDiagonaleZOLL.Size = new Size(88, 23);
            tbxDiagonaleZOLL.TabIndex = 20;
            // 
            // lblDiagonaleZOLL
            // 
            lblDiagonaleZOLL.AutoSize = true;
            lblDiagonaleZOLL.Location = new Point(241, 269);
            lblDiagonaleZOLL.Name = "lblDiagonaleZOLL";
            lblDiagonaleZOLL.Size = new Size(25, 15);
            lblDiagonaleZOLL.TabIndex = 21;
            lblDiagonaleZOLL.Text = "zoll";
            // 
            // cbxFarben
            // 
            cbxFarben.FormattingEnabled = true;
            cbxFarben.Items.AddRange(new object[] { "Weiß", "Gelb", "Rot", "Blau", "Orange", "Lila", "Schwarz", "Grau", "Grün" });
            cbxFarben.Location = new Point(127, 558);
            cbxFarben.Name = "cbxFarben";
            cbxFarben.Size = new Size(138, 23);
            cbxFarben.TabIndex = 22;
            cbxFarben.SelectedIndexChanged += cbxFarben_SelectedIndexChanged;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(58, 525);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(37, 15);
            lblExtra.TabIndex = 23;
            lblExtra.Text = "Extras";
            // 
            // lblFarben
            // 
            lblFarben.AutoSize = true;
            lblFarben.Location = new Point(58, 566);
            lblFarben.Name = "lblFarben";
            lblFarben.Size = new Size(49, 15);
            lblFarben.TabIndex = 24;
            lblFarben.Text = "Farben :";
            // 
            // tbxTextinhalt
            // 
            tbxTextinhalt.Location = new Point(127, 601);
            tbxTextinhalt.Multiline = true;
            tbxTextinhalt.Name = "tbxTextinhalt";
            tbxTextinhalt.Size = new Size(139, 80);
            tbxTextinhalt.TabIndex = 25;
            tbxTextinhalt.TextChanged += tbxTextinhalt_TextChanged;
            // 
            // lblTextinhalt
            // 
            lblTextinhalt.AutoSize = true;
            lblTextinhalt.Location = new Point(58, 601);
            lblTextinhalt.Name = "lblTextinhalt";
            lblTextinhalt.Size = new Size(34, 15);
            lblTextinhalt.TabIndex = 26;
            lblTextinhalt.Text = "Text :";
            // 
            // tbxRand
            // 
            tbxRand.Location = new Point(127, 701);
            tbxRand.Name = "tbxRand";
            tbxRand.Size = new Size(108, 23);
            tbxRand.TabIndex = 27;
            tbxRand.TextChanged += tbxRand_TextChanged;
            // 
            // lblRandCM
            // 
            lblRandCM.AutoSize = true;
            lblRandCM.Location = new Point(241, 709);
            lblRandCM.Name = "lblRandCM";
            lblRandCM.Size = new Size(24, 15);
            lblRandCM.TabIndex = 28;
            lblRandCM.Text = "cm";
            // 
            // lblRand
            // 
            lblRand.AutoSize = true;
            lblRand.Location = new Point(58, 709);
            lblRand.Name = "lblRand";
            lblRand.Size = new Size(40, 15);
            lblRand.TabIndex = 29;
            lblRand.Text = "Rand :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(127, 831);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 49);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(194, 831);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(72, 49);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "-";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // lbxRechtecke
            // 
            lbxRechtecke.FormattingEnabled = true;
            lbxRechtecke.ItemHeight = 15;
            lbxRechtecke.Location = new Point(128, 731);
            lbxRechtecke.Name = "lbxRechtecke";
            lbxRechtecke.Size = new Size(138, 94);
            lbxRechtecke.TabIndex = 32;
            // 
            // lblRechtecke
            // 
            lblRechtecke.AutoSize = true;
            lblRechtecke.Location = new Point(58, 731);
            lblRechtecke.Name = "lblRechtecke";
            lblRechtecke.Size = new Size(64, 15);
            lblRechtecke.TabIndex = 33;
            lblRechtecke.Text = "Rechtecke:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1774, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            mnuMenu.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, mnuSave, mnuSaveUnder });
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Size = new Size(50, 20);
            mnuMenu.Text = "Menü";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(180, 22);
            mnuOpen.Text = "Öffnen";
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.Size = new Size(180, 22);
            mnuSave.Text = "Speichern";
            // 
            // mnuSaveUnder
            // 
            mnuSaveUnder.Name = "mnuSaveUnder";
            mnuSaveUnder.Size = new Size(180, 22);
            mnuSaveUnder.Text = "Speichern unter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 892);
            Controls.Add(lblRechtecke);
            Controls.Add(lbxRechtecke);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblRand);
            Controls.Add(lblRandCM);
            Controls.Add(tbxRand);
            Controls.Add(lblTextinhalt);
            Controls.Add(tbxTextinhalt);
            Controls.Add(lblFarben);
            Controls.Add(lblExtra);
            Controls.Add(cbxFarben);
            Controls.Add(lblDiagonaleZOLL);
            Controls.Add(tbxDiagonaleZOLL);
            Controls.Add(lblFleacheCM);
            Controls.Add(lblDiagonaleCM);
            Controls.Add(lblUmfangCM);
            Controls.Add(lblHoeheCM);
            Controls.Add(lblBreiteCM);
            Controls.Add(pnlLinie);
            Controls.Add(btnRechteck);
            Controls.Add(lblFlaeche);
            Controls.Add(lblDiagonale);
            Controls.Add(lblUmfang);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(tbxFlaeche);
            Controls.Add(tbxDiagonaleCM);
            Controls.Add(tbxUmfang);
            Controls.Add(tbxHoehe);
            Controls.Add(tbxBreite);
            Controls.Add(btnDrehen);
            Controls.Add(btnZoomIn);
            Controls.Add(btnZoomOut);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        private Button btnZoomOut;
        private Button btnZoomIn;
        private Button btnDrehen;
        private TextBox tbxBreite;
        private TextBox tbxHoehe;
        private TextBox tbxUmfang;
        private TextBox tbxDiagonaleCM;
        private TextBox tbxFlaeche;
        private Label lblBreite;
        private Label lblHoehe;
        private Label lblUmfang;
        private Label lblDiagonale;
        private Label lblFlaeche;
        private Button btnRechteck;
        private Panel pnlLinie;
        private Label lblBreiteCM;
        private Label lblHoeheCM;
        private Label lblUmfangCM;
        private Label lblDiagonaleCM;
        private Label lblFleacheCM;
        private TextBox tbxDiagonaleZOLL;
        private Label lblDiagonaleZOLL;
        private ComboBox cbxFarben;
        private Label lblExtra;
        private Label lblFarben;
        private TextBox tbxTextinhalt;
        private Label lblTextinhalt;
        private TextBox tbxRand;
        private Label lblRandCM;
        private Label lblRand;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lbxRechtecke;
        private Label lblRechtecke;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuMenu;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuSaveUnder;
    }
}
