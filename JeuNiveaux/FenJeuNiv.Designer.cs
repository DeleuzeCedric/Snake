/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 03/03/2019
 * Heure: 17:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Snake
{
	partial class FenJeuNiv
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnStats;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		private void InitializeComponent(){
			this.btnStats = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.panelPrincipale.SuspendLayout();
			this.panelBtn.SuspendLayout();
			this.panelDessin.SuspendLayout();
			this.panelAffichage.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPrincipale
			// 
			this.panelPrincipale.Size = new System.Drawing.Size(924, 561);
			// 
			// panelBtn
			// 
			this.panelBtn.Controls.Add(this.btnMenu);
			this.panelBtn.Controls.Add(this.btnStats);
			this.panelBtn.Location = new System.Drawing.Point(0, 511);
			this.panelBtn.Size = new System.Drawing.Size(924, 50);
			this.panelBtn.Controls.SetChildIndex(this.btnStats, 0);
			this.panelBtn.Controls.SetChildIndex(this.btnMenu, 0);
			this.panelBtn.Controls.SetChildIndex(this.labelTouche, 0);
			this.panelBtn.Controls.SetChildIndex(this.btnRejouer, 0);
			this.panelBtn.Controls.SetChildIndex(this.btnRevenirDebut, 0);
			// 
			// btnRevenirDebut
			// 
			this.btnRevenirDebut.Click += new System.EventHandler(this.BtnRevenirDebutClick);
			// 
			// panelDessin
			// 
			this.panelDessin.Location = new System.Drawing.Point(87, 0);
			this.panelDessin.Size = new System.Drawing.Size(510, 443);
			// 
			// labelEtat
			// 
			this.labelEtat.Size = new System.Drawing.Size(510, 443);
			// 
			// labelLevel
			// 
			this.labelLevel.Text = "Level : 5 * 5";
			// 
			// labelVitesse
			// 
			this.labelVitesse.Text = "Vitesse : 5";
			// 
			// panelAffichage
			// 
			this.panelAffichage.Location = new System.Drawing.Point(724, 0);
			this.panelAffichage.Size = new System.Drawing.Size(200, 511);
			// 
			// btnStats
			// 
			this.btnStats.Location = new System.Drawing.Point(729, 12);
			this.btnStats.Name = "btnStats";
			this.btnStats.Size = new System.Drawing.Size(91, 28);
			this.btnStats.TabIndex = 3;
			this.btnStats.Text = "Statistiques (P)";
			this.btnStats.UseVisualStyleBackColor = true;
			this.btnStats.Click += new System.EventHandler(this.BtnStatsClick);
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(826, 12);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(91, 28);
			this.btnMenu.TabIndex = 4;
			this.btnMenu.Text = "Menu (M)";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.BtnMenuClick);
			// 
			// FenJeuNiv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 561);
			this.Name = "FenJeuNiv";
			this.Text = "FenJeuNiv";
			this.panelPrincipale.ResumeLayout(false);
			this.panelBtn.ResumeLayout(false);
			this.panelDessin.ResumeLayout(false);
			this.panelAffichage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
