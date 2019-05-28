/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 23/02/2019
 * Heure: 10:30
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Snake
{
	/// <summary>
	/// Description of MenuNiv.
	/// </summary>
	public partial class MenuNiv : Form
	{
		private string folderSnake;
		private string folderConfig;
		private string filsConfig;
		private FenJeuNiv parent;
		
		public MenuNiv(FenJeuNiv parent)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			this.parent = parent;
			this.folderSnake = parent.getFolderSnake();
			this.folderConfig = parent.getFolderConfig();
			this.filsConfig = parent.getFilsConfig();
			
			if (parent.verifExistFile(filsConfig)) {
					
				using (StreamReader strmReader = new StreamReader(filsConfig)) {
					String ligne = strmReader.ReadLine();
					String[] tabConfig;
					
					if (ligne != null) {
						tabConfig = ligne.Split(';');
					
						saisieHauteJeu.Text = tabConfig[0];
						saisieLargJeu.Text = tabConfig[1];
						saisieTailleSnake.Text = tabConfig[2];
						saisieTailleSnake.Maximum = (int)((float)1 / 3 * (int.Parse(tabConfig[0]) * int.Parse(tabConfig[1])));
						saisieVit.Text = tabConfig[3];
						
					}
				}
			}
		}
		
		private void ecrireOption()
		{
			
			parent.initFile();
				
			using (StreamWriter strmWriter = new StreamWriter(filsConfig)) {
				
				strmWriter.WriteLine(saisieHauteJeu.Text + ";" + saisieLargJeu.Text + ";" + saisieTailleSnake.Text + ";" + saisieVit.Text);
				
			}
			
		}
		
		void BtnValiderClick(object sender, EventArgs e)
		{
			ecrireOption();
			this.Close();
		}
		
		void BtnAnnulerClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SaisieDimValueChanged(object sender, EventArgs e)
		{
			saisieTailleSnake.Maximum = (int)((float)1 / 3 * (int.Parse(saisieHauteJeu.Text) * int.Parse(saisieLargJeu.Text)));
		}
		void ButtonRazClick(object sender, EventArgs e)
		{
			saisieHauteJeu.Text = "5";
			saisieLargJeu.Text = "5";
			saisieTailleSnake.Text = "1";
			saisieTailleSnake.Maximum = (int)((float)1 / 3 * (int.Parse(saisieHauteJeu.Text) * int.Parse(saisieLargJeu.Text)));
			saisieVit.Text = "5";
						
			ecrireOption();
		}
		
	}
}
