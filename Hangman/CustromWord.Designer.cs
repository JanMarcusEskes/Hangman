namespace Hangman
{
	partial class CustromWord
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnReady = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Eigenes Wort:";
			// 
			// btnReady
			// 
			this.btnReady.Location = new System.Drawing.Point(295, 10);
			this.btnReady.Name = "btnReady";
			this.btnReady.Size = new System.Drawing.Size(75, 23);
			this.btnReady.TabIndex = 2;
			this.btnReady.Text = "Bestätigen";
			this.btnReady.UseVisualStyleBackColor = true;
			this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(92, 12);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(197, 20);
			this.txtInput.TabIndex = 1;
			this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			// 
			// CustromWord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 43);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.btnReady);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CustromWord";
			this.Text = "CustromWord";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReady;
		private System.Windows.Forms.TextBox txtInput;
	}
}