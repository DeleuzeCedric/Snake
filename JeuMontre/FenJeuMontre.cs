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
	/// Description of FenJeuMontre.
	/// </summary>
	public partial class FenJeuMontre : FenJeu
	{
		private int temps = 60;
		private int min = 1, sec = 0, compteur = 6000;
		
		public FenJeuMontre()
		{
			filsConfig = folderConfig + @"\confMontre.snk";
			filsSave = folderSave + @"\RecordMontre.sv";
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			MenuMontre option = new MenuMontre(this);
			option.ShowDialog();
			
		}
		
		protected override void defSupp()
		{
			maxBonus = Math.Max((largeurJeu * hauteurJeu) / 25, 1);
			initChrono();
			timerChrono.Stop();
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
					temps = int.Parse(tabConfig[2]);
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
					
					if (temps > 600)
						temps = 600;
					else if (temps < 30)
						temps = 30;
				}
			}
		}
		
		protected void initChrono()
		{
			
			compteur = temps;
			calculChrono();
			
		}
		
		protected override void appliqueDirectionRenard()
		{
			ts.direction = derniereDirection;	
		}
		
		protected void afficherChrono()
		{
			labelChrono.Text = "";
			
			if (min < 10)
				labelChrono.Text += "0";
			
			labelChrono.Text += min + ":";
			
			if (sec < 10)
				labelChrono.Text += "0";
			
			labelChrono.Text += sec.ToString();
			
		}
		
		protected void calculChrono()
		{
			
			min = compteur / 60;
			sec = compteur % 60;
			
			afficherChrono();
			
		}
		
		protected override void determinePos(BouleSnake bs)
		{
			if (compteur > 0) {
				
				base.determinePos(bs);
				
			}
		}
		
		protected override void dessineSnake()
		{
			base.dessineSnake();
			dessineTete();
		}
		
		protected override void deplaceCorps()
		{
		}
		
		protected override void verifFin()
		{
			
			fin = compteur <= 0;
			
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
		
		protected override void verifToucheClavier(char toucheClavier)
		{
			
			if (toucheClavier == 'm') {
				
				showMenuMontre();
				
			} else if (toucheClavier == 'p') {
				
				showStats();
				
			} else {
				
				base.verifToucheClavier(toucheClavier);
				
			}
			
		}
		
		protected override void actionPremierDeplacement()
		{
			timerChrono.Start();
			base.actionPremierDeplacement();
		}
		
		protected override void enregistre()
		{
			timerJeu.Stop();
			timerChrono.Stop();
			
			labelEtat.Visible = true;
			
			if (panelDessin.Width < 350)
				labelEtat.Text = "S\nc\no\nr\ne\n:\n" + partiesSnake.Count;
			else
				labelEtat.Text = "Score : " + partiesSnake.Count;
			
			initFile();
			String[] tabSave;
			List <RecordMontre> listeRecordMontre = new List<RecordMontre>();
			int[] tabPosRecordMontres;
			RecordMontre[] tabRecordMontreEcriture;
			int posRecordMontreActu;
			
			using (StreamReader strmReader = new StreamReader(filsSave)) {
				
				String ligne = strmReader.ReadLine();
				
				while (ligne != null) {
					
					tabSave = ligne.Split(';');
					listeRecordMontre.Add(new RecordMontre(int.Parse(tabSave[0]), int.Parse(tabSave[1]), int.Parse(tabSave[2]), int.Parse(tabSave[3]), int.Parse(tabSave[4])));
					ligne = strmReader.ReadLine();
					
				}
				
				listeRecordMontre.Add(new RecordMontre(hauteurJeu, largeurJeu, temps, (1000 - timerJeu.Interval) / 100, partiesSnake.Count));
				
				tabPosRecordMontres = new int[listeRecordMontre.Count];
				tabRecordMontreEcriture = new RecordMontre[listeRecordMontre.Count];
				
				foreach (RecordMontre recActu in listeRecordMontre) {
					
					posRecordMontreActu = 0;
					
					foreach (RecordMontre recCompare in listeRecordMontre) {
						
						if (!recActu.Equals(recCompare)) {
							
							if (recActu.hauteur > recCompare.hauteur)
								posRecordMontreActu++;
							else if (recActu.hauteur == recCompare.hauteur) {
								
								if (recActu.largeur > recCompare.largeur)
									posRecordMontreActu++;
								else if (recActu.largeur == recCompare.largeur) {
									
									if (recActu.temps > recCompare.temps)
										posRecordMontreActu++;
									else if (recActu.temps == recCompare.temps) {
										
										if (recActu.vitesse > recCompare.vitesse)
											posRecordMontreActu++;
										else if (recActu.vitesse == recCompare.vitesse) {
											
											if (recActu.resultat == recCompare.resultat) {
												if (listeRecordMontre.IndexOf(recActu) > listeRecordMontre.IndexOf(recCompare))
													posRecordMontreActu = -1;
											} else if (recActu.resultat < recCompare.resultat)
												posRecordMontreActu = -1;
											
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
					if (recActu.hauteur > 20 || recActu.hauteur < 3
					    || recActu.largeur > 20 || recActu.largeur < 3
					    || recActu.resultat < 1
					    || recActu.temps > 600
					    || recActu.temps < 30)
						posRecordMontreActu = -1;
					
					if (posRecordMontreActu > -1)
						tabRecordMontreEcriture[posRecordMontreActu] = recActu;
					
				}
				
			}
			
			using (StreamWriter strmWriter = new StreamWriter(filsSave)) {
				
				foreach (RecordMontre rec in tabRecordMontreEcriture) {
					
					if (rec != null)
						strmWriter.WriteLine(rec.hauteur + ";" + rec.largeur + ";" + rec.temps
						+ ";" + rec.vitesse + ";" + rec.resultat);
					
				}
				
			}
			
		}
		
		void BtnMenuClick(object sender, EventArgs e)
		{
			showMenuMontre();
		}
		
		void BtnStatsClick(object sender, EventArgs e)
		{
			showStats();
		}
		
		private void showMenuMontre()
		{
			
			if (!fin)
				enregistre();
			
			MenuMontre option = new MenuMontre(this);
			option.ShowDialog();
			miseAZero();
			
		}
		
		private void showStats()
		{
			if (!fin)
				enregistre();
			
			StatistiqueMontre stat = new StatistiqueMontre(this);
			stat.ShowDialog();
			miseAZero();
		}
		
		void TimerChronoTick(object sender, EventArgs e)
		{
			compteur--;
			calculChrono();
		}
		
	}
}
