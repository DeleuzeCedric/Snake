/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 25/02/2019
 * Heure: 22:00
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
	/// Description of StatistiqueMontre.
	/// </summary>
	public partial class StatistiqueMontre : Form
	{
		private string folderSnake;
		private string filsSave;
		private FenJeuMontre parent;
		
		public StatistiqueMontre(FenJeuMontre parent)
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
			this.filsSave = parent.getFilsSave();
			
			lireRecordMontres();
			
		}
		
		private void lireRecordMontres(){
			
			if (parent.verifExistFile(filsSave)) {
					
				using (StreamReader strmReader = new StreamReader(filsSave)) {
					String ligne = strmReader.ReadLine();
					String[] tabSave;
					
					while (ligne != null) {
						
						tabSave = ligne.Split(';');
						dgvRecord.Rows.Add(tabSave);						
						ligne = strmReader.ReadLine();
						
					}
				}
			}
			
		}
		
		void BtnRazClick(object sender, EventArgs e)
		{
			File.Delete(filsSave);
			using(File.Create(filsSave)){}
			
			dgvRecord.Rows.Clear();
			dgvRecord.Refresh();
			
			lireRecordMontres();
		}
	
		void FenDepartKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Escape)
				this.Close();
		}	
	}
}
