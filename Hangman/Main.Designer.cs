namespace Hangman
{
  partial class Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.gpbInput = new System.Windows.Forms.GroupBox();
			this.btnZ = new System.Windows.Forms.Button();
			this.btnA = new System.Windows.Forms.Button();
			this.btnX = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnY = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnW = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.Button();
			this.btnV = new System.Windows.Forms.Button();
			this.btnE = new System.Windows.Forms.Button();
			this.btnU = new System.Windows.Forms.Button();
			this.btnF = new System.Windows.Forms.Button();
			this.btnT = new System.Windows.Forms.Button();
			this.btnG = new System.Windows.Forms.Button();
			this.btnS = new System.Windows.Forms.Button();
			this.btnH = new System.Windows.Forms.Button();
			this.btnR = new System.Windows.Forms.Button();
			this.btnI = new System.Windows.Forms.Button();
			this.btnQ = new System.Windows.Forms.Button();
			this.btnJ = new System.Windows.Forms.Button();
			this.btnP = new System.Windows.Forms.Button();
			this.btnK = new System.Windows.Forms.Button();
			this.btnO = new System.Windows.Forms.Button();
			this.btnL = new System.Windows.Forms.Button();
			this.btnN = new System.Windows.Forms.Button();
			this.btnM = new System.Windows.Forms.Button();
			this.lblZuErraten = new System.Windows.Forms.Label();
			this.gpbZuErraten = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zufälligesWortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eigenesWortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pcbGrafic = new System.Windows.Forms.PictureBox();
			this.gpbInput.SuspendLayout();
			this.gpbZuErraten.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbGrafic)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbInput
			// 
			this.gpbInput.Controls.Add(this.btnZ);
			this.gpbInput.Controls.Add(this.btnA);
			this.gpbInput.Controls.Add(this.btnX);
			this.gpbInput.Controls.Add(this.btnB);
			this.gpbInput.Controls.Add(this.btnY);
			this.gpbInput.Controls.Add(this.btnC);
			this.gpbInput.Controls.Add(this.btnW);
			this.gpbInput.Controls.Add(this.btnD);
			this.gpbInput.Controls.Add(this.btnV);
			this.gpbInput.Controls.Add(this.btnE);
			this.gpbInput.Controls.Add(this.btnU);
			this.gpbInput.Controls.Add(this.btnF);
			this.gpbInput.Controls.Add(this.btnT);
			this.gpbInput.Controls.Add(this.btnG);
			this.gpbInput.Controls.Add(this.btnS);
			this.gpbInput.Controls.Add(this.btnH);
			this.gpbInput.Controls.Add(this.btnR);
			this.gpbInput.Controls.Add(this.btnI);
			this.gpbInput.Controls.Add(this.btnQ);
			this.gpbInput.Controls.Add(this.btnJ);
			this.gpbInput.Controls.Add(this.btnP);
			this.gpbInput.Controls.Add(this.btnK);
			this.gpbInput.Controls.Add(this.btnO);
			this.gpbInput.Controls.Add(this.btnL);
			this.gpbInput.Controls.Add(this.btnN);
			this.gpbInput.Controls.Add(this.btnM);
			this.gpbInput.Location = new System.Drawing.Point(12, 369);
			this.gpbInput.Name = "gpbInput";
			this.gpbInput.Size = new System.Drawing.Size(408, 87);
			this.gpbInput.TabIndex = 27;
			this.gpbInput.TabStop = false;
			this.gpbInput.Text = "Eingabe";
			// 
			// btnZ
			// 
			this.btnZ.Location = new System.Drawing.Point(378, 50);
			this.btnZ.Name = "btnZ";
			this.btnZ.Size = new System.Drawing.Size(25, 25);
			this.btnZ.TabIndex = 25;
			this.btnZ.Text = "Z";
			this.btnZ.UseVisualStyleBackColor = true;
			this.btnZ.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnA
			// 
			this.btnA.Location = new System.Drawing.Point(6, 19);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(25, 25);
			this.btnA.TabIndex = 0;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnX
			// 
			this.btnX.Location = new System.Drawing.Point(316, 50);
			this.btnX.Name = "btnX";
			this.btnX.Size = new System.Drawing.Size(25, 25);
			this.btnX.TabIndex = 24;
			this.btnX.Text = "X";
			this.btnX.UseVisualStyleBackColor = true;
			this.btnX.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(37, 19);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(25, 25);
			this.btnB.TabIndex = 1;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnY
			// 
			this.btnY.Location = new System.Drawing.Point(347, 50);
			this.btnY.Name = "btnY";
			this.btnY.Size = new System.Drawing.Size(25, 25);
			this.btnY.TabIndex = 23;
			this.btnY.Text = "Y";
			this.btnY.UseVisualStyleBackColor = true;
			this.btnY.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(68, 19);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(25, 25);
			this.btnC.TabIndex = 2;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnW
			// 
			this.btnW.Location = new System.Drawing.Point(285, 50);
			this.btnW.Name = "btnW";
			this.btnW.Size = new System.Drawing.Size(25, 25);
			this.btnW.TabIndex = 22;
			this.btnW.Text = "W";
			this.btnW.UseVisualStyleBackColor = true;
			this.btnW.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnD
			// 
			this.btnD.Location = new System.Drawing.Point(99, 19);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(25, 25);
			this.btnD.TabIndex = 3;
			this.btnD.Text = "D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnV
			// 
			this.btnV.Location = new System.Drawing.Point(254, 50);
			this.btnV.Name = "btnV";
			this.btnV.Size = new System.Drawing.Size(25, 25);
			this.btnV.TabIndex = 21;
			this.btnV.Text = "V";
			this.btnV.UseVisualStyleBackColor = true;
			this.btnV.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnE
			// 
			this.btnE.Location = new System.Drawing.Point(130, 19);
			this.btnE.Name = "btnE";
			this.btnE.Size = new System.Drawing.Size(25, 25);
			this.btnE.TabIndex = 4;
			this.btnE.Text = "E";
			this.btnE.UseVisualStyleBackColor = true;
			this.btnE.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnU
			// 
			this.btnU.Location = new System.Drawing.Point(223, 50);
			this.btnU.Name = "btnU";
			this.btnU.Size = new System.Drawing.Size(25, 25);
			this.btnU.TabIndex = 20;
			this.btnU.Text = "U";
			this.btnU.UseVisualStyleBackColor = true;
			this.btnU.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnF
			// 
			this.btnF.Location = new System.Drawing.Point(161, 19);
			this.btnF.Name = "btnF";
			this.btnF.Size = new System.Drawing.Size(25, 25);
			this.btnF.TabIndex = 5;
			this.btnF.Text = "F";
			this.btnF.UseVisualStyleBackColor = true;
			this.btnF.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnT
			// 
			this.btnT.Location = new System.Drawing.Point(192, 50);
			this.btnT.Name = "btnT";
			this.btnT.Size = new System.Drawing.Size(25, 25);
			this.btnT.TabIndex = 19;
			this.btnT.Text = "T";
			this.btnT.UseVisualStyleBackColor = true;
			this.btnT.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnG
			// 
			this.btnG.Location = new System.Drawing.Point(192, 19);
			this.btnG.Name = "btnG";
			this.btnG.Size = new System.Drawing.Size(25, 25);
			this.btnG.TabIndex = 6;
			this.btnG.Text = "G";
			this.btnG.UseVisualStyleBackColor = true;
			this.btnG.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnS
			// 
			this.btnS.Location = new System.Drawing.Point(161, 50);
			this.btnS.Name = "btnS";
			this.btnS.Size = new System.Drawing.Size(25, 25);
			this.btnS.TabIndex = 18;
			this.btnS.Text = "S";
			this.btnS.UseVisualStyleBackColor = true;
			this.btnS.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnH
			// 
			this.btnH.Location = new System.Drawing.Point(223, 19);
			this.btnH.Name = "btnH";
			this.btnH.Size = new System.Drawing.Size(25, 25);
			this.btnH.TabIndex = 7;
			this.btnH.Text = "H";
			this.btnH.UseVisualStyleBackColor = true;
			this.btnH.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnR
			// 
			this.btnR.Location = new System.Drawing.Point(130, 50);
			this.btnR.Name = "btnR";
			this.btnR.Size = new System.Drawing.Size(25, 25);
			this.btnR.TabIndex = 17;
			this.btnR.Text = "R";
			this.btnR.UseVisualStyleBackColor = true;
			this.btnR.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnI
			// 
			this.btnI.Location = new System.Drawing.Point(254, 19);
			this.btnI.Name = "btnI";
			this.btnI.Size = new System.Drawing.Size(25, 25);
			this.btnI.TabIndex = 8;
			this.btnI.Text = "I";
			this.btnI.UseVisualStyleBackColor = true;
			this.btnI.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnQ
			// 
			this.btnQ.Location = new System.Drawing.Point(99, 50);
			this.btnQ.Name = "btnQ";
			this.btnQ.Size = new System.Drawing.Size(25, 25);
			this.btnQ.TabIndex = 16;
			this.btnQ.Text = "Q";
			this.btnQ.UseVisualStyleBackColor = true;
			this.btnQ.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnJ
			// 
			this.btnJ.Location = new System.Drawing.Point(285, 19);
			this.btnJ.Name = "btnJ";
			this.btnJ.Size = new System.Drawing.Size(25, 25);
			this.btnJ.TabIndex = 9;
			this.btnJ.Text = "J";
			this.btnJ.UseVisualStyleBackColor = true;
			this.btnJ.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnP
			// 
			this.btnP.Location = new System.Drawing.Point(68, 50);
			this.btnP.Name = "btnP";
			this.btnP.Size = new System.Drawing.Size(25, 25);
			this.btnP.TabIndex = 15;
			this.btnP.Text = "P";
			this.btnP.UseVisualStyleBackColor = true;
			this.btnP.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnK
			// 
			this.btnK.Location = new System.Drawing.Point(316, 19);
			this.btnK.Name = "btnK";
			this.btnK.Size = new System.Drawing.Size(25, 25);
			this.btnK.TabIndex = 10;
			this.btnK.Text = "K";
			this.btnK.UseVisualStyleBackColor = true;
			this.btnK.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnO
			// 
			this.btnO.Location = new System.Drawing.Point(37, 50);
			this.btnO.Name = "btnO";
			this.btnO.Size = new System.Drawing.Size(25, 25);
			this.btnO.TabIndex = 14;
			this.btnO.Text = "O";
			this.btnO.UseVisualStyleBackColor = true;
			this.btnO.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnL
			// 
			this.btnL.Location = new System.Drawing.Point(347, 19);
			this.btnL.Name = "btnL";
			this.btnL.Size = new System.Drawing.Size(25, 25);
			this.btnL.TabIndex = 11;
			this.btnL.Text = "L";
			this.btnL.UseVisualStyleBackColor = true;
			this.btnL.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnN
			// 
			this.btnN.Location = new System.Drawing.Point(6, 50);
			this.btnN.Name = "btnN";
			this.btnN.Size = new System.Drawing.Size(25, 25);
			this.btnN.TabIndex = 13;
			this.btnN.Text = "N";
			this.btnN.UseVisualStyleBackColor = true;
			this.btnN.Click += new System.EventHandler(this.Letter_Click);
			// 
			// btnM
			// 
			this.btnM.Location = new System.Drawing.Point(378, 19);
			this.btnM.Name = "btnM";
			this.btnM.Size = new System.Drawing.Size(25, 25);
			this.btnM.TabIndex = 12;
			this.btnM.Text = "M";
			this.btnM.UseVisualStyleBackColor = true;
			this.btnM.Click += new System.EventHandler(this.Letter_Click);
			// 
			// lblZuErraten
			// 
			this.lblZuErraten.AutoSize = true;
			this.lblZuErraten.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZuErraten.Location = new System.Drawing.Point(6, 16);
			this.lblZuErraten.Name = "lblZuErraten";
			this.lblZuErraten.Size = new System.Drawing.Size(174, 33);
			this.lblZuErraten.TabIndex = 26;
			this.lblZuErraten.Text = "lblZuErraten";
			// 
			// gpbZuErraten
			// 
			this.gpbZuErraten.Controls.Add(this.lblZuErraten);
			this.gpbZuErraten.Location = new System.Drawing.Point(12, 295);
			this.gpbZuErraten.Name = "gpbZuErraten";
			this.gpbZuErraten.Size = new System.Drawing.Size(408, 55);
			this.gpbZuErraten.TabIndex = 28;
			this.gpbZuErraten.TabStop = false;
			this.gpbZuErraten.Text = "Zu erratendes Wort";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(432, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// neuesSpielToolStripMenuItem
			// 
			this.neuesSpielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zufälligesWortToolStripMenuItem,
            this.eigenesWortToolStripMenuItem});
			this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
			this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
			// 
			// zufälligesWortToolStripMenuItem
			// 
			this.zufälligesWortToolStripMenuItem.Name = "zufälligesWortToolStripMenuItem";
			this.zufälligesWortToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.zufälligesWortToolStripMenuItem.Text = "Zufälliges Wort";
			this.zufälligesWortToolStripMenuItem.Click += new System.EventHandler(this.zufälligesWortToolStripMenuItem_Click);
			// 
			// eigenesWortToolStripMenuItem
			// 
			this.eigenesWortToolStripMenuItem.Name = "eigenesWortToolStripMenuItem";
			this.eigenesWortToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.eigenesWortToolStripMenuItem.Text = "Eigenes Wort";
			this.eigenesWortToolStripMenuItem.Click += new System.EventHandler(this.eigenesWortToolStripMenuItem_Click);
			// 
			// pcbGrafic
			// 
			this.pcbGrafic.Image = global::Hangman.Properties.Resources.hangman0;
			this.pcbGrafic.ImageLocation = "";
			this.pcbGrafic.Location = new System.Drawing.Point(0, 27);
			this.pcbGrafic.Name = "pcbGrafic";
			this.pcbGrafic.Size = new System.Drawing.Size(432, 262);
			this.pcbGrafic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbGrafic.TabIndex = 30;
			this.pcbGrafic.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 468);
			this.Controls.Add(this.pcbGrafic);
			this.Controls.Add(this.gpbZuErraten);
			this.Controls.Add(this.gpbInput);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Hangman";
			this.gpbInput.ResumeLayout(false);
			this.gpbZuErraten.ResumeLayout(false);
			this.gpbZuErraten.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbGrafic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gpbInput;
    private System.Windows.Forms.Button btnZ;
    private System.Windows.Forms.Button btnA;
    private System.Windows.Forms.Button btnX;
    private System.Windows.Forms.Button btnB;
    private System.Windows.Forms.Button btnY;
    private System.Windows.Forms.Button btnC;
    private System.Windows.Forms.Button btnW;
    private System.Windows.Forms.Button btnD;
    private System.Windows.Forms.Button btnV;
    private System.Windows.Forms.Button btnE;
    private System.Windows.Forms.Button btnU;
    private System.Windows.Forms.Button btnF;
    private System.Windows.Forms.Button btnT;
    private System.Windows.Forms.Button btnG;
    private System.Windows.Forms.Button btnS;
    private System.Windows.Forms.Button btnH;
    private System.Windows.Forms.Button btnR;
    private System.Windows.Forms.Button btnI;
    private System.Windows.Forms.Button btnQ;
    private System.Windows.Forms.Button btnJ;
    private System.Windows.Forms.Button btnP;
    private System.Windows.Forms.Button btnK;
    private System.Windows.Forms.Button btnO;
    private System.Windows.Forms.Button btnL;
    private System.Windows.Forms.Button btnN;
    private System.Windows.Forms.Button btnM;
    private System.Windows.Forms.Label lblZuErraten;
    private System.Windows.Forms.GroupBox gpbZuErraten;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zufälligesWortToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eigenesWortToolStripMenuItem;
		private System.Windows.Forms.PictureBox pcbGrafic;
	}
}

