/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 09/05/2019
 * Heure: 08:41
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;

namespace Snake
{
	/// <summary>
	/// Description of CorpsSnake.
	/// </summary>
	public class CorpsSnake : BouleSnake
	{
		public CorpsSnake(int posX, int posY) : base (posX, posY)
		{
		}
		
		public CorpsSnake()
		{
		}
		
		protected override void definieImg()
		{
			try {
				imgDessin = Image.FromFile(Environment.CurrentDirectory + @"\..\..\images\trognon.png");
			} catch (Exception) {
				imgDessin = null;
			}
			
			brushDessin = new SolidBrush(Color.DarkRed);
		}
		
		public override void dessineImg(Graphics gr, int largeurCase, int hauteurCase)
		{
			
			gr.DrawImage(imgDessin,
				(int)((posX * largeurCase) + (0.1 * largeurCase)),
				(int)((posY * hauteurCase) + (0.1 * hauteurCase)),
				(int)(largeurCase * 0.8),
				(int)(hauteurCase * 0.8));
			
		}
		
		public override void dessineFigure(Graphics gr, int largeurCase, int hauteurCase)
		{
			gr.FillEllipse(brushDessin,
				(int)((posX * largeurCase) + (0.1 * largeurCase)),
				(int)((posY * hauteurCase) + (0.1 * hauteurCase)),
				(int)(largeurCase * 0.9),
				(int)(hauteurCase * 0.9));
			
		}
	}
}
