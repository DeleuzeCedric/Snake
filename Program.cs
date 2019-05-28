/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 03/03/2019
 * Heure: 17:11
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;

namespace Snake
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			lanceFenDepart();
			
		}
		
		static void lanceFenDepart()
		{
			
			FenDepart fen = new FenDepart();
			
			Application.Run(fen);
			
			lanceFenJeu(fen.getTypeJeu());
			
		}
		
		static void lanceFenJeu(int typeJeu)
		{
			
			FenJeu fen = null;
			
			switch (typeJeu) {
				case 0: 
					fen = new FenJeuNiv();
					break;
				case 1:
					fen = new FenJeuMontre();
					break;
				case 2:
					fen = new FenJeuSurvie();
					break;
			} 
			
			if (fen != null) {
				Application.Run(fen);
				if (fen != null && fen.getRevenirDebut()) {
					lanceFenDepart();
				}
			}
			
			Environment.Exit(0);
			
		}
		
	}
		
}
