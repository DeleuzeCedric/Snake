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
	/// Description of FenJeuNiv.
	/// </summary>
	public partial class FenJeuNiv : FenJeu
	{
		private int tailleDepartSnake = 1;
		
		public FenJeuNiv()
		{
			filsConfig = folderConfig + @"\confNiv.snk";
			filsSave = folderSave + @"\RecordNiv.sv";
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			MenuNiv option = new MenuNiv(this);
			option.ShowDialog();
		}
		
		protected override void defSupp()
		{
			maxBonus = 1;
			
			for (int i = 1; i < tailleDepartSnake; i++)
				partiesSnake.Add(new CorpsSnake(-1, -1));
			
			fin = false;
		}
		
		protected override void litConfig()
		{
			using (StreamReader strmReader = new StreamReader(filsConfig)) {
				String ligne = strmReader.ReadLine();
				String[] tabConfig;
				
				if (ligne != null) {
					tabConfig = ligne.Split(';');
					
					hauteurJeu = int.Parse(tabConfig[0]);
					largeurJeu = int.Parse(tabConfig[1]);
					tailleDepartSnake = int.Parse(tabConfig[2]);
					timerJeu.Interval = (int)(1000 - (int.Parse(tabConfig[3]) * 100));
					
					if (hauteurJeu > 20)
						hauteurJeu = 20;
					else if (hauteurJeu < 3)
						hauteurJeu = 3;
					
					if (largeurJeu > 20)
						largeurJeu = 20;
					else if (largeurJeu < 3)
						largeurJeu = 3;
					
					if (timerJeu.Interval > 1000)
						timerJeu.Interval = 1000;
					else if (timerJeu.Interval < 100)
						timerJeu.Interval = 100;
					
					if (tailleDepartSnake > (int)((float)1 / 3 * (hauteurJeu * largeurJeu)))
						tailleDepartSnake = (int)((float)1 / 3 * (hauteurJeu * largeurJeu));
					else if (tailleDepartSnake < 1)
						tailleDepartSnake = 1;
				}
			}
			
		}
		
		protected override void determinePos(BouleSnake bs)
		{
			if (!fin || partiesSnake.Count < hauteurJeu * largeurJeu) {
				
				base.determinePos(bs);
				
			}
		}
		
		protected override void dessineSnake()
		{
			if (!fin) {
				base.dessineSnake();
				dessineCorps();
			}
		}
		
		protected override void verifToucheClavier(char toucheClavier)
		{
			
			if (toucheClavier == 'm') {
				
				showMenuNiv();
				
			} else if (toucheClavier == 'p') {
				
				showStats();
				
			} else {
				
				base.verifToucheClavier(toucheClavier);
			}
			
		}
		
		protected override void enregistre()
		{
			timerJeu.Stop();
			
			if (fin) {
				
				bool gagner = partiesSnake.Count == largeurJeu*hauteurJeu;
				
				grJeu.Clear(panelDessin.BackColor);
				labelEtat.Visible = true;
				
				if (panelDessin.Width < 350) {
					
					if (gagner)
						labelEtat.Text = "W\nI\nN\nN\nE\nR";
					else
						labelEtat.Text = "L\nO\nO\nS\nE\nR";
					
				} else {
					
					if (gagner)
						labelEtat.Text = "W I N N E R";
					else
						labelEtat.Text = "L O O S E R";
					
				}
			}
			
			initFile();
			String[] tabSave;
			List <RecordNiv> listeRecordNiv = new List<RecordNiv>();
			int[] tabPosRecordNivs;
			RecordNiv[] tabRecordNivEcriture;
			int posRecordNivActu;
			
			using (StreamReader strmReader = new StreamReader(filsSave)) {
				
				String ligne = strmReader.ReadLine();
				
				while (ligne != null) {
					
					tabSave = ligne.Split(';');
					listeRecordNiv.Add(new RecordNiv(int.Parse(tabSave[0]), int.Parse(tabSave[1]), int.Parse(tabSave[2]), int.Parse(tabSave[3]), int.Parse(tabSave[4])));
					ligne = strmReader.ReadLine();
					
				}
				
				listeRecordNiv.Add(new RecordNiv(hauteurJeu, largeurJeu, tailleDepartSnake, (1000 - timerJeu.Interval) / 100, partiesSnake.Count));
				
				tabPosRecordNivs = new int[listeRecordNiv.Count];
				tabRecordNivEcriture = new RecordNiv[listeRecordNiv.Count];
				
				foreach (RecordNiv recActu in listeRecordNiv) {
					
					posRecordNivActu = 0;
					
					foreach (RecordNiv recCompare in listeRecordNiv) {
						
						if (!recActu.Equals(recCompare)) {
							
							if (recActu.hauteur > recCompare.hauteur)
								posRecordNivActu++;
							else if (recActu.hauteur == recCompare.hauteur) {
								
								if (recActu.largeur > recCompare.largeur)
									posRecordNivActu++;
								else if (recActu.largeur == recCompare.largeur) {
									
									if (recActu.tailleSnake > recCompare.tailleSnake)
										posRecordNivActu++;
									else if (recActu.tailleSnake == recCompare.tailleSnake) {
										
										if (recActu.vitesse > recCompare.vitesse)
											posRecordNivActu++;
										else if (recActu.vitesse == recCompare.vitesse) {
											
											if (recActu.resultat == recCompare.resultat) {
												if (listeRecordNiv.IndexOf(recActu) > listeRecordNiv.IndexOf(recCompare))
													posRecordNivActu = -1;
											} else if (recActu.resultat < recCompare.resultat)
												posRecordNivActu = -1;
											
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
					if (recActu.hauteur > 20 || recActu.hauteur < 3
					    || recActu.largeur > 20 || recActu.largeur < 3
					    || recActu.resultat > recActu.hauteur * recActu.largeur
					    || recActu.resultat < recActu.tailleSnake
					    || recActu.tailleSnake > (int)((float)1 / 3 * (recActu.hauteur * recActu.largeur))
					    || recActu.tailleSnake < 1)
						posRecordNivActu = -1;
					
					if (posRecordNivActu > -1)
						tabRecordNivEcriture[posRecordNivActu] = recActu;
					
				}
				
			}
			
			using (StreamWriter strmWriter = new StreamWriter(filsSave)) {
				
				foreach (RecordNiv rec in tabRecordNivEcriture) {
					
					if (rec != null)
						strmWriter.WriteLine(rec.hauteur + ";" + rec.largeur + ";" + rec.tailleSnake
						                     + ";" + rec.vitesse + ";" + rec.resultat);
					
				}
				
			}
			
		}
		
		void BtnMenuClick(object sender, EventArgs e)
		{
			showMenuNiv();
		}
		
		void BtnStatsClick(object sender, EventArgs e)
		{
			showStats();
		}
		
		private void showMenuNiv()
		{
			
			if (!fin)
				enregistre();
			
			MenuNiv option = new MenuNiv(this);
			option.ShowDialog();
			miseAZero();
			
		}
		
		private void showStats()
		{
			if (!fin)
				enregistre();
			
			StatistiqueNiv stat = new StatistiqueNiv(this);
			stat.ShowDialog();
			miseAZero();
		}
		
	}
}
