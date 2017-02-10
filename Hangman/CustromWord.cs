using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
	public partial class CustromWord : Form
	{
		public CustromWord()
		{
			InitializeComponent();
		}

		private void btnReady_Click(object sender, EventArgs e)
		{
			bool gültig = true;
			char[] eingabe = txtInput.Text.ToUpper().ToCharArray();
			if (eingabe.Length < 1) MessageBox.Show("Es wurden kein Wort eingegeben!\nBitte geben Sie ein Wort ein", "Falsches Zeichen", MessageBoxButtons.OK, MessageBoxIcon.Error);
			foreach (char buchstabe in eingabe)
				if (buchstabe < 'A' || buchstabe > 'Z')
					gültig = false;

			if (gültig)
			{
				Program.main.initNewGame(txtInput.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Es wurde ein nicht gültiges Zeichen eingegeben!\nBitte geben Sie ein anderes Wort ein", "Falsches Zeichen", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtInput.Text = String.Empty;
			}

		}

		private void txtInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnReady_Click(txtInput, null);
		}
	}
}
