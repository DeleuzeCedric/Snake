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
	/// Description of RecordNiv.
	/// </summary>
	public class RecordNiv
	{
		
		public int hauteur, largeur, tailleSnake, vitesse, resultat;
		
		public RecordNiv(int hauteur, int largeur, int tailleSnake, int vitesse, int resultat)
		{
			this.hauteur = hauteur;
			this.largeur = largeur;
			this.tailleSnake = tailleSnake;
			this.vitesse = vitesse;
			this.resultat = resultat;
		}
	}
}
