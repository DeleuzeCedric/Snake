/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 22/02/2019
 * Heure: 20:18
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;

namespace Snake
{
	/// <summary>
	/// Description of BouleSnake.
	/// </summary>
	public abstract class BouleSnake
	{
		public int posX, posY;
		protected Image imgDessin;
		protected Brush brushDessin;
		
		protected BouleSnake(int posX, int posY)
		{
			this.posX = posX;
			this.posY = posY;
			definieImg();
		}
		
		protected BouleSnake()
		{
			this.posX = -1;
			this.posY = -1;
			definieImg();
		}
		
		protected abstract void definieImg();
		
		public virtual void dessine(Graphics gr, int largeurCase, int hauteurCase)
		{
			
			if (imgDessin != null) {
				
				dessineImg(gr,largeurCase,hauteurCase);
				
			} else {
				
				dessineFigure(gr,largeurCase,hauteurCase);
				
			}
			
		}
		
		public virtual void dessineImg(Graphics gr, int largeurCase, int hauteurCase)
		{
			
			gr.DrawImage(imgDessin, posX * largeurCase, posY * hauteurCase,
				largeurCase, hauteurCase);
			
		}
		
		public virtual void dessineFigure(Graphics gr, int largeurCase, int hauteurCase)
		{
			
			gr.FillEllipse(brushDessin, posX * largeurCase, posY * hauteurCase,
				largeurCase, hauteurCase);
			
		}
		
	}
}
