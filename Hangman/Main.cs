using System;
using System.Collections;
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
	public partial class Main : Form
	{
		int versuche, fehler;
		string wort;
		ArrayList eingegebene = new ArrayList();
		public Main()
		{
			InitializeComponent();
			initNewGame(null);
		}

		private void Letter_Click(object sender, EventArgs e)
		{
			versuche++;
			Button auslöser = (Button)sender;
			eingaben('@', char.Parse(auslöser.Text));
			auslöser.Enabled = false;
			if (wort.Contains(auslöser.Text) || wort.Contains(auslöser.Text.ToLower()))
			{
				//Richtige Eingabe
				lblZuErraten.Text = String.Empty;
				char[] buchstaben = wort.ToCharArray();
				foreach (char buchstabe in buchstaben)
				{
					if (eingaben(buchstabe, '@'))
						lblZuErraten.Text += buchstabe;
					else
						lblZuErraten.Text += '*';
				}
				if (!lblZuErraten.Text.Contains("*"))
				{
					//Alles erraten
					MessageBox.Show("Herzlichen Glückwunsch.\nSie haben das Wort in " + versuche + " Versuchen herrausgefunden.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
					foreach (Button btn in this.gpbInput.Controls)
						btn.Enabled = false;
				}

				return;
			}
			else
			{
				//Falsche Eingabe
				fehler++;
				switch (fehler)
				{
					case 1: pcbGrafic.Image = Properties.Resources.hangman1;
						break;
					case 2: pcbGrafic.Image = Properties.Resources.hangman2;
						break;
					case 3: pcbGrafic.Image = Properties.Resources.hangman3;
						break;
					case 4: pcbGrafic.Image = Properties.Resources.hangman4;
						break;
					case 5: pcbGrafic.Image = Properties.Resources.hangman5;
						break;
					case 6: pcbGrafic.Image = Properties.Resources.hangman6;
						break;
					case 7: pcbGrafic.Image = Properties.Resources.hangman7;
						break;
					case 8: pcbGrafic.Image = Properties.Resources.hangman8;
						break;
					case 9: pcbGrafic.Image = Properties.Resources.hangman9;
						break;
					case 10:
						pcbGrafic.Image = Properties.Resources.hangman10;
						MessageBox.Show("Sie haben leider verloren.\nDas Wort war: " + wort, "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
						foreach (Button btn in this.gpbInput.Controls)
							btn.Enabled = false;
						break;
					default:
						break;
				}
			}
		}

		private bool eingaben(char eingabe, char neueEingabe)
		{
			if (neueEingabe != '@')
				eingegebene.Add(neueEingabe);

			eingabe = char.Parse(eingabe.ToString().ToUpper());
			if (eingabe != '@')
				foreach (char zeichen in eingegebene)
				{
					if (eingabe == zeichen)
						return true;
				}
			return false;

		}

		public void initNewGame(string eigenesWort)
		{
			foreach (Button btn in this.gpbInput.Controls)
				btn.Enabled = true;
			lblZuErraten.Text = String.Empty;
			eingegebene.Clear();
			versuche = 0;
			fehler = 0;
			pcbGrafic.Image = Properties.Resources.hangman0;
			
			if (eigenesWort == null)
			{
				string[] randomWords = { "Haus", "Baum", "Wald", "Computer", "Handy", "Maus", "Gras", "Tasche", "Schuhe", "Jacke", "Uhr", "Musik", "Haare", "Auto", "Bus", "Flugzeug", "Fahrrad", "Schule", "Telefon", "Internet", "Zug", "Stift", "Brief", "Papier", "Luft", "Himmel", "Stern", "Erde", "Schere", "Geld", "Hallo", "Buch" };
				Random zufall = new Random(DateTime.Now.Ticks.GetHashCode());
				wort = randomWords[zufall.Next(0, randomWords.Length)];
				foreach (var item in wort) lblZuErraten.Text += '*';
				return;
			}
			else
			{
				wort = eigenesWort;
				foreach (var item in wort) lblZuErraten.Text += '*';
			}
		}

		private void zufälligesWortToolStripMenuItem_Click(object sender, EventArgs e)
		{
			initNewGame(null);
		}

		private void eigenesWortToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form custromWord = new CustromWord();
			custromWord.ShowDialog();
		}

	}
}
