/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 27/02/2019
 * Heure: 11:02
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
	/// <summary>
	/// Description of FenDepart.
	/// </summary>
	public partial class FenDepart : Form
	{
		int typeJeu = -1;
		
		public FenDepart()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void ouvreFenJeu(int type){
			
			typeJeu = type;
			this.Close();
			
		}
		
		void BtnNivClick(object sender, EventArgs e)
		{
			ouvreFenJeu(0);
		}
		
		void BtnContreMontreClick(object sender, EventArgs e)
		{
			ouvreFenJeu(1);
		}
		
		void BtnSurvieClick(object sender, EventArgs e)
		{
			ouvreFenJeu(2);
		}
		
		public int getTypeJeu()
		{
			return typeJeu;
		}
		
		void FenDepartKeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar) {
				case '1':
				case '&' :
			ouvreFenJeu(0);
					break;
				case '2':
				case 'é' :
			ouvreFenJeu(1);
					break;
				case '3':
				case '"' :
			ouvreFenJeu(2);
					break;
			}
		}
		
		void FenDepartKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Escape)
				this.Close();
		}
	}
}
