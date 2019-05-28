/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 04/05/2019
 * Heure: 13:38
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;

namespace Snake
{
	/// <summary>
	/// Description of BonusSnake.
	/// </summary>
	public class BonusSnake : BouleSnake
	{
		public BonusSnake(int posX, int posY) : base (posX, posY)
		{
		}
		
		public BonusSnake()
		{
		}
		
		protected override void definieImg()
		{
			try {
				imgDessin = Image.FromFile(Environment.CurrentDirectory + @"\..\..\images\pomme.png");
			} catch (Exception) {
				imgDessin = null;
			}
			
			brushDessin = new SolidBrush(Color.Red);
		}
		
	}
}
