/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 03/03/2019
 * Heure: 17:17
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
	/// Description of FenJeu.
	/// </summary>
	public partial class FenJeu : Form
	{
		protected int lastPosXTete, lastPosYTete, posXNouvellePomme, posYNouvellePomme, lastPosXQueue, lastPosYQueue;
		protected int hauteurJeu, largeurJeu, hauteurCase, largeurCase, derniereDirection, maxBonus, indexBonus;
		protected List<BonusSnake> listeBonus;
		protected List<BouleSnake> partiesSnake = new List<BouleSnake>();
		protected TeteSnake ts;
		protected Graphics grJeu;
		protected Brush bEfface;
		protected Random rnd = new Random();
		protected bool premierDeplacement = true, revenirDebut = false, ajoutBoule, fin;
		protected bool peutEffDernPartie;
		protected string folderSnake, folderConfig, folderSave, filsConfig = "", filsSave = "";
		protected string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		
		protected FenJeu()
		{
			folderSnake = path + @"\Snake";
			folderConfig = folderSnake + @"\Config";
			folderSave = folderSnake + @"\Save";
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			bEfface = new SolidBrush(panelDessin.BackColor);
			
		}
		
		protected virtual void miseAZero()
		{ 
			initFile();

			if (verifExistFile(filsConfig)) {

				litConfig();
			}

			definiDimCase();
			
			initSnake();
			
			initPomme();
			
			timerJeu.Stop();
					
			initBoolean();
			
			defSupp();
			
			initAffichage();
			
			initPosBonus();
			
			dessinePommes();
			
			dessineSnake();
			
		}
		
		protected virtual void initAffichage()
		{
			labelEtat.Visible = false;
			labelEtat.Text = "";
			labelLevel.Text = "Level : " + largeurJeu + " * " + hauteurJeu;
			labelVitesse.Text = "Vitesse : " + (1000 - timerJeu.Interval) / 100;
			labelTaille.Text = "Taille : " + partiesSnake.Count;
			grJeu.Clear(panelDessin.BackColor);
		}
		
		protected virtual void initBoolean()
		{
			fin = false;
			ajoutBoule = false;
			premierDeplacement = true;
			peutEffDernPartie = false;
		}
		
		protected virtual void initPomme()
		{
			listeBonus = new List<BonusSnake>();
			indexBonus = 0;
			posXNouvellePomme = -1;
			posYNouvellePomme = -1;
		}
		
		protected virtual void initSnake()
		{
			
			derniereDirection = 5;
			partiesSnake = new List<BouleSnake>();
			
			ts = new TeteSnake(largeurJeu / 2, hauteurJeu / 2, derniereDirection);
			partiesSnake.Add(ts);
			
			lastPosXTete = ts.posX;
			lastPosYTete = ts.posY;
			lastPosXQueue = -1;
			lastPosYQueue = -1;
			
		}
		
		protected virtual void defSupp()
		{
			maxBonus = 1;
		}
		
		protected virtual void litConfig()
		{
			hauteurJeu = 5;
			largeurJeu = 5;
			timerJeu.Interval = 500;
		}
		
		protected void definiDimCase()
		{
			
			int decremente = 0;
			
			do {
				
				hauteurCase = (panelPrincipale.Height - panelBtn.Height) / hauteurJeu;
				largeurCase = (panelPrincipale.Width - panelAffichage.Width) / largeurJeu;
				
				int dim = (int)Math.Min(largeurCase, hauteurCase) - decremente;
				panelDessin.Size = new Size(dim * largeurJeu, dim * hauteurJeu);
				hauteurCase = dim;
				largeurCase = dim;
				
				panelDessin.Location = new Point(
					((panelPrincipale.Width - panelAffichage.Width) / 2) - (panelDessin.Width / 2),
					((panelPrincipale.Height - panelBtn.Height) / 2) - (panelDessin.Height / 2));
				
				decremente += 10;
				
			} while(panelDessin.Height > (panelPrincipale.Height - panelBtn.Height) || panelDessin.Width > panelPrincipale.Width);
			
			
			grJeu = panelDessin.CreateGraphics();
			
		}

		protected virtual void initPosBonus()
		{
			BonusSnake bonus;
			listeBonus = new List<BonusSnake>(maxBonus);
			
			for (int i = 0; i < maxBonus; i++) {
				
				bonus = new BonusSnake();
				
				if ((largeurJeu * hauteurJeu) - partiesSnake.Count >= i) {
					
					determinePos(bonus);
					
				} else {
					
					bonus.posX = -1;
					bonus.posY = -1;
					
				}
				
				listeBonus.Add(bonus);
				
			}
			
		}
		
		protected virtual void determinePos(BouleSnake bs)
		{
			bool posCorrecte = true;
			
			do {
				
				bs.posX = tirageRandLargeur();
				bs.posY = tirageRandHauteur();
				posCorrecte = verifPos(bs);
				
			} while(!posCorrecte);
			
		}
		
		protected virtual bool verifPos(BouleSnake bs)
		{
			
			bool posCorrecte = verifPosPomme(bs);
			
			posCorrecte = posCorrecte && verifPosPartie(bs);
			
			return posCorrecte;
			
		}
		
		protected bool verifPosPartie(BouleSnake bs)
		{
			
			foreach (BouleSnake boule in partiesSnake) {
				
				if (boule.posX == bs.posX && boule.posY == bs.posY)
					return false;
				
			}
			
			return true;
		}
		
		protected bool verifPosPomme(BouleSnake bs)
		{
			
			foreach (BonusSnake bonus in listeBonus) {
				
				if (bs.posX == bonus.posX && bs.posY == bonus.posY
				    && bs != bonus)
					return false;
				
			}
			
			return true;
		}
		
		protected int tirageRandLargeur()
		{
			return (int)rnd.Next(0, largeurJeu);
		}
		
		protected int tirageRandHauteur()
		{
			return(int)rnd.Next(0, hauteurJeu);
		}
		
		protected virtual void dessineSnake()
		{
			int dimCase = (int)Math.Min(largeurCase, hauteurCase);
		}
		
		protected void dessinePommes()
		{
			foreach (BonusSnake bonus in listeBonus)
				bonus.dessine(grJeu, largeurCase, hauteurCase);
		}
		
		protected void dessineNouvPomme()
		{
			if (indexBonus >= 0 && indexBonus < listeBonus.Count)
				listeBonus[indexBonus].dessine(grJeu, largeurCase, hauteurCase);
		}
		
		protected void dessineTete()
		{
			ts.dessine(grJeu, largeurCase, hauteurCase);
			
			if (lastPosXTete != ts.posX || lastPosYTete != ts.posY) {
				grJeu.FillRectangle(bEfface, lastPosXTete * largeurCase, lastPosYTete * hauteurCase,
					largeurCase, hauteurCase);
			}
		}
		
		protected void dessineCorps()
		{
			BouleSnake bs;
			
			if (peutEffDernPartie) {
				
				grJeu.FillRectangle(bEfface, lastPosXQueue * largeurCase, lastPosYQueue * hauteurCase,
					largeurCase, hauteurCase);
				peutEffDernPartie = false;
				
			}
			
			dessineTete();
			
			if (partiesSnake.Count > 1) {
								
				for (int j = 1; j < partiesSnake.Count; j++) {
					partiesSnake[j].dessine(grJeu, largeurCase, hauteurCase);
				}
			}
			
		}
		
		protected void deplaceSnake()
		{
			
			if (!fin) {
				
				deplaceTete();
				
				if (ajoutBoule)
					ajouteCorps();
				else
					peutEffDernPartie = true;
				
				verifFin();
				
				if (!fin) {
					
					deplaceCorps();
					
					if (ajoutBoule)
						ajouterBonus();
					
				} else {
					
					enregistre();
					
					switch (ts.direction) {
						case 0:
							ts.posX++;
							break;
						case 1:
							ts.posX--;
							break;
							
						case 2:
							ts.posY++;
							break;
							
						case 3:
							ts.posY--;
							break;
					}
				}
				
			} else
				enregistre();
			
			dessineSnake();
			
		}
		
		protected virtual void ajouteCorps()
		{
			BouleSnake lastBS = partiesSnake[partiesSnake.Count - 1];
			int nouvPosX = lastBS.posX, nouvPosY = lastBS.posY;
			partiesSnake.Add(new CorpsSnake(nouvPosX, nouvPosY));
			labelTaille.Text = "Taille : " + partiesSnake.Count;
		}
		
		protected virtual void deplaceCorps()
		{
			
			BouleSnake bs, bsBefore;
			
			for (int i = partiesSnake.Count - 1; i >= 1; i--) {
				
				bs = partiesSnake[i];
				
				if (i == partiesSnake.Count - 1) {
					
					lastPosYQueue = bs.posY;
					lastPosXQueue = bs.posX;
					
				}
				
				if (i == 1) {
					
					bs.posX = lastPosXTete;
					bs.posY = lastPosYTete;
					
				}
				
				if (i > 1) {
					
					bsBefore = partiesSnake[i - 1];
					
					bs.posX = bsBefore.posX;
					bs.posY = bsBefore.posY;
					
				}
				
			}
			
			bs = partiesSnake[0];
			
		}
		
		protected virtual void ajouterBonus()
		{
			ajoutBoule = false;
			if (indexBonus >= 0 && indexBonus < listeBonus.Count) {
				BonusSnake bonus = listeBonus[indexBonus];
				determinePos(bonus);
				posXNouvellePomme = bonus.posX;
				posYNouvellePomme = bonus.posY;
				dessineNouvPomme();
			}
		}
		
		protected virtual void deplaceTete()
		{
			deplacePosTete();
			
			verifTeteSurPomme();
		}
		
		protected virtual void appliqueDirectionRenard()
		{
			
			if (!(
			        (derniereDirection == 0 && ts.direction == 1) ||
			        (derniereDirection == 1 && ts.direction == 0) ||
			        (derniereDirection == 2 && ts.direction == 3) ||
			        (derniereDirection == 3 && ts.direction == 2)
			    ) || partiesSnake.Count <= 2)
				ts.direction = derniereDirection;
			
		}
		
		protected virtual void deplacePosTete()
		{
			
			lastPosXTete = ts.posX;
			lastPosYTete = ts.posY;
			
			appliqueDirectionRenard();
			
			switch (ts.direction) {
				case 0:
					ts.posX--;
					break;
				case 1:
					ts.posX++;
					break;
					
				case 2:
					ts.posY--;
					break;
					
				case 3:
					ts.posY++;
					break;
			}
			
		}
		
		protected void verifTeteSurPomme()
		{
			
			indexBonus = 0;
			
			while (indexBonus < listeBonus.Count && !ajoutBoule) {
				
				ajoutBoule = (ts.posX == listeBonus[indexBonus].posX && ts.posY == listeBonus[indexBonus].posY);
				indexBonus++;
				
			}
			
			indexBonus--;
		}
		
		protected virtual void verifFin()
		{
			
			fin = (partiesSnake.Count == largeurJeu * hauteurJeu) || (ts.posY < 0 || ts.posY >= hauteurJeu
			|| ts.posX < 0 || ts.posX >= largeurJeu);
			
			if (!fin)
				verifPositionTete();
			
		}
		
		protected virtual void verifPositionTete()
		{
			
			int j = 1;
			
			while (j < partiesSnake.Count && !fin) {
				fin = (j != 1 && ts.posY == partiesSnake[j - 1].posY
				&& ts.posX == partiesSnake[j - 1].posX);
				j++;
			}

		}
		
		protected virtual void enregistre()
		{
			
		}
		
		protected void BtnRevenirDebutClick(object sender, EventArgs e)
		{
			revenirDebut = true;
			this.Close();
		}
		
		public bool verifExistDirectory(string path)
		{
			
			if (!Directory.Exists(path)) {
				
				Directory.CreateDirectory(path);
				return false;
				
			}
			
			return true;
			
		}
		
		public bool verifExistFile(string path)
		{
			
			if (!File.Exists(path) && !path.Replace(" ", "").Equals("")) {
				using (File.Create(path)) {
				}
				return false;
			}
			return true;
		}
		
		public void initFile()
		{
			
			if (!folderSnake.Replace(" ", "").Equals("")) {
				if (!Directory.Exists(folderSnake))
					Directory.CreateDirectory(folderSnake);
			}
			
			if (!folderConfig.Replace(" ", "").Equals("")) {
				if (!Directory.Exists(folderConfig))
					Directory.CreateDirectory(folderConfig);
			}
			
			if (!folderSave.Replace(" ", "").Equals("")) {
				if (!Directory.Exists(folderSave))
					Directory.CreateDirectory(folderSave);
			}
			
			if (!filsConfig.Replace(" ", "").Equals("")) {
				if (!File.Exists(filsConfig))
					using (File.Create(filsConfig)) {
					}
			}
			
			if (!filsSave.Replace(" ", "").Equals("")) {
				if (!File.Exists(filsSave))
					using (File.Create(filsSave)) {
					}
			}
		}
		
		public bool getRevenirDebut()
		{
			return revenirDebut;
		}
		
		public string getFolderSnake()
		{
			
			return folderSnake;
			
		}
		
		public string getFolderConfig()
		{
			
			return folderConfig;
			
		}
		
		public string getFolderSave()
		{
			
			return folderSave;
			
		}
		
		public string getFilsConfig()
		{
			
			return filsConfig;
			
		}
		
		public string getFilsSave()
		{
			return filsSave;
		}
		
		void TimerJeuTick(object sender, EventArgs e)
		{
			deplaceSnake();
		}
		
		void BtnRejouerClick(object sender, EventArgs e)
		{
			miseAZero();
		}
		
		void PanelPaint(object sender, PaintEventArgs e)
		{
			paint();
		}
		
		protected virtual void paint()
		{
			dessinePommes();
			dessineSnake();
		}
		
		void FenJeuLoad(object sender, EventArgs e)
		{
			miseAZero();
		}
		
		void FenJeuResizeEnd(object sender, EventArgs e)
		{
			grJeu.Clear(panelDessin.BackColor);
			definiDimCase();
			dessinePommes();
			dessineSnake();
		}
		
		void KeyPressDirection(object sender, KeyPressEventArgs e)
		{
			verifToucheClavier(e.KeyChar);	
		}
		
		protected virtual void verifToucheClavier(char toucheClavier)
		{
			
			if (toucheClavier == 'r') {
				
				miseAZero();
				
			} else if (!fin) {
			
				derniereDirection = ts.direction;
			
				switch (toucheClavier) {
					case 'q':
						derniereDirection = 0;
						break;
					case 'd':
						derniereDirection = 1;
						break;
					case 'z':
						derniereDirection = 2;
						break;
					case 's':
						derniereDirection = 3;
						break;
				}
			
				if (premierDeplacement && derniereDirection >= 0 && derniereDirection <= 3) {
					actionPremierDeplacement();
				}
			}			
		}
		
		protected virtual void actionPremierDeplacement()
		{
			premierDeplacement = false;
			timerJeu.Start();
			deplaceSnake();
		}
		
	}
}
