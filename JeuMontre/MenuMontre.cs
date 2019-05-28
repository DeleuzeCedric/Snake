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
	/// Description of MenuMontre.
	/// </summary>
	public partial class MenuMontre : Form
	{
		private string folderSnake;
		private string folderConfig;
		private string filsConfig;
		private FenJeuMontre parent;
		
		public MenuMontre(FenJeuMontre parent)
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
						saisieTempsJeu.Text = tabConfig[2];
						saisieVit.Text = tabConfig[3];
						
					}
				}
			}
		}
		
		private void ecrireOption()
		{
			
			parent.initFile();
				
			using (StreamWriter strmWriter = new StreamWriter(filsConfig)) {
				
				strmWriter.WriteLine(saisieHauteJeu.Text + ";" + saisieLargJeu.Text + ";" + saisieTempsJeu.Text + ";" + saisieVit.Text);
				
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
		
		void ButtonRazClick(object sender, EventArgs e)
		{
			saisieHauteJeu.Text = "5";
			saisieLargJeu.Text = "5";
			saisieTempsJeu.Text = "60";
			saisieVit.Text = "5";
						
			ecrireOption();
		}
		
	}
}
