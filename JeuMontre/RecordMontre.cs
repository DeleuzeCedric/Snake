/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 23/02/2019
 * Heure: 12:40
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Snake
{
	/// <summary>
	/// Description of RecordMontre.
	/// </summary>
	public class RecordMontre
	{
		
		public int hauteur, largeur, temps, vitesse, resultat;
		
		public RecordMontre(int hauteur, int largeur, int temps, int vitesse, int resultat)
		{
			this.hauteur = hauteur;
			this.largeur = largeur;
			this.temps = temps;
			this.vitesse = vitesse;
			this.resultat = resultat;
		}
	}
}
