/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 05/05/2019
 * Heure: 17:44
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;

namespace Snake
{
	/// <summary>
	/// Description of PiegeSnake.
	/// </summary>
	public class PiegeSnake : BouleSnake
	{		
		public PiegeSnake(int posX, int posY) : base (posX, posY)
		{
		}
			
		public PiegeSnake()
		{
		}
		
		protected override void definieImg()
		{
			try {
				imgDessin = Image.FromFile(Environment.CurrentDirectory + @"\..\..\images\piege.png");
			} catch (Exception) {
				imgDessin = null;
			}
			
			brushDessin = new SolidBrush(Color.Green);
		}
		
		public override void dessineFigure(Graphics gr, int largeurCase, int hauteurCase)
		{
			
			gr.FillRectangle(brushDessin, posX * largeurCase, posY * hauteurCase,
				largeurCase, hauteurCase);
			
		}
	}
}
