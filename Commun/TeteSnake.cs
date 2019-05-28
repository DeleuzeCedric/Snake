/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 23/02/2019
 * Heure: 10:06
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;

namespace Snake
{
	/// <summary>
	/// Description of TeteSnake.
	/// </summary>
	public class TeteSnake : BouleSnake
	{
		public int direction;
		
		public TeteSnake(int posX, int posY, int direction)
			: base(posX, posY)
		{
			this.direction = direction;
		}
		
		public TeteSnake()
		{
			this.direction = 5;
		}
		
		protected override void definieImg()
		{
			try {
				imgDessin = Image.FromFile(Environment.CurrentDirectory + @"\..\..\images\renard.png");
			} catch (Exception) {
				imgDessin = null;
			}
			
			brushDessin = new SolidBrush(Color.Navy);
		}
		
		public override void dessine(Graphics gr, int largeurCase, int hauteurCase)
		{
			int rotate = 0;
			
			switch (direction) {
				case 0:
					imgDessin.RotateFlip(RotateFlipType.Rotate270FlipY);
					rotate = 90;
					break;
				case 1:
					imgDessin.RotateFlip(RotateFlipType.Rotate90FlipY);
					rotate = 270;
					break;
				case 2:
					imgDessin.RotateFlip(RotateFlipType.Rotate180FlipY);
					rotate = 180;
					break;
			}
				
			base.dessine(gr, largeurCase, hauteurCase);
			
			switch (rotate) {
				case 270:
					imgDessin.RotateFlip(RotateFlipType.Rotate90FlipY);
					break;
				case 90:
					imgDessin.RotateFlip(RotateFlipType.Rotate270FlipY);
					break;
				case 180:
					imgDessin.RotateFlip(RotateFlipType.Rotate180FlipY);
					break;
			}
				
		}
	}
}
