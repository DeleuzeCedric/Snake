/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 03/03/2019
 * Heure: 17:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Snake
{
	/// <summary>
	/// Description of FenJeuSurvie.
	/// </summary>
	public partial class FenJeuSurvie : FenJeu
	{
		private List<PiegeSnake> listePiege;
		private int maxPiege = 1, prochainNiv;
		
		public FenJeuSurvie()
		{
			filsConfig = folderConfig + @"\confSurvie.snk";
			filsSave = folderSave + @"\RecordSurvie.sv";
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		protected override void miseAZero()
		{
			largeurJeu = 20;
			hauteurJeu = 20;
			
			initFile();
			
			partiesSnake = new List<BouleSnake>();
			
			ts = new TeteSnake(largeurJeu / 2, hauteurJeu / 2, derniereDirection);
			partiesSnake.Add(ts);
			
			labelEtat.Visible = false;
			labelEtat.Text = "";
			
			fin = false;
			
			labelTaille.Text = "Taille : 1";
			
			razNiveau();
			
		}
		
		protected void razNiveau()
		{
			listePiege = new List<PiegeSnake>();
			
			initSnake();
			
			initPomme();

			initBoolean();
			
			maxBonus = Math.Min(Math.Max(largeurJeu * hauteurJeu / 10, 1), 20);
			maxPiege = Math.Max(largeurJeu * hauteurJeu / 10, 1);
						
			timerJeu.Stop();
			timerJeu.Interval = Math.Max(1000 - (Math.Min(largeurJeu, hauteurJeu) * 100 / 2), 50);
			
			BouleSnake bs;
			
			for (int i = 1; i < partiesSnake.Count; i++) {
				
				bs = partiesSnake[i];
				
				bs.posX = -1;
				bs.posY = -1;
				
			}
			
			definiDimCase();
			
			initPosBonus();
			
			prochainNiv = largeurJeu * hauteurJeu / 2;
			
			initAffichage();
			
			initPosPiege();
			
			dessinePommes();
			
			dessinePieges();
			
			dessineSnake();
		}
		
		protected override void initAffichage()
		{
			base.initAffichage();
			lblPomme.Text = "Pomme : " + maxBonus;
			lblPiege.Text = "Piège : " + maxPiege;
			labelProchNiv.Text = "Prochain Niveau : " + (prochainNiv - partiesSnake.Count);
		}
		
		protected override void initBoolean()
		{
			fin = false;
			ajoutBoule = false;
			premierDeplacement = true;
			peutEffDernPartie = false;
		}
		
		protected override void initSnake()
		{
			derniereDirection = 5;
			
			ts.posX = largeurJeu / 2;
			ts.posY = hauteurJeu / 2;
			ts.direction = derniereDirection;
			
			lastPosXTete = ts.posX;
			lastPosYTete = ts.posY;
			lastPosXQueue = -1;
			lastPosYQueue = -1;
		}
		
		protected override void determinePos(BouleSnake bs)
		{
			if (!fin) {
				
				base.determinePos(bs);
				
			}
		}
		
		protected override bool verifPos(BouleSnake bs)
		{
			bool posCorrecte = base.verifPos(bs) && verifPosPiege(bs);
			
			return posCorrecte;
			
		}
		
		protected bool verifPosPiege(BouleSnake bs)
		{
			
			foreach (PiegeSnake ps in listePiege) {
				
				if (bs.posX == ps.posX && bs.posY == ps.posY)
					return false;
			}
			
			return true;
		}
		
		protected void initPosPiege()
		{
			
			PiegeSnake ps;
			
			for (int i = 0; i < maxPiege; i++) {
				
				ps = new PiegeSnake();
				
				determinePos(ps);
				
				listePiege.Add(ps);
			}
			
		}
		
		protected override void dessineSnake()
		{
			
			if (!fin) {
								
				base.dessineSnake();
				dessineCorps();
				
			}
			
		}
		
		protected void dessinePieges()
		{
			foreach (PiegeSnake ps in listePiege)
				ps.dessine(grJeu, largeurCase, hauteurCase);
				
		}
		
		protected override void ajouterBonus()
		{
			
			labelProchNiv.Text = "Prochain Niveau : " + (prochainNiv - partiesSnake.Count);
			
			if (partiesSnake.Count >= prochainNiv) {
				
				largeurJeu++;
				hauteurJeu++;
				razNiveau();
				
			} else {
				
				base.ajouterBonus();
				
			}
			
		}
		
		protected override void verifFin()
		{
			verifPositionTete();
		}
		
		protected override void verifPositionTete()
		{
			
			base.verifPositionTete();
			
			int j = 0;
			
			while (j < maxPiege && !fin) {
				fin = (ts.posY == listePiege[j].posY
				&& ts.posX == listePiege[j].posX);
				j++;
			}
			
		}
		
		protected override void deplacePosTete()
		{
			base.deplacePosTete();
			
			if (ts.posX < 0)
				ts.posX = largeurJeu - 1;
			else if (ts.posX >= largeurJeu)
				ts.posX = 0;
			
			if (ts.posY < 0)
				ts.posY = hauteurJeu - 1;
			else if (ts.posY >= hauteurJeu)
				ts.posY = 0;
						
		}
		
		protected override void enregistre()
		{
			timerJeu.Stop();
			
			if (fin) {
				
				grJeu.Clear(panelDessin.BackColor);
				labelEtat.Visible = true;
				
				if (panelDessin.Width < 350) {
					
					labelEtat.Text = "S\nc\no\nr\ne\n:" + partiesSnake.Count;
					
				} else {
					
					labelEtat.Text = "Score :" + partiesSnake.Count;
				}
			}
			
		}
		
		protected override void paint()
		{
			dessinePieges();
			base.paint();
		}
	}
}
