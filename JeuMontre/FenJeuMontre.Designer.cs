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
	partial class FenJeuMontre
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnStats;
		private System.Windows.Forms.Timer timerChrono;
		private System.Windows.Forms.Label labelChrono;
		
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
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnStats = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.timerChrono = new System.Windows.Forms.Timer(this.components);
			this.labelChrono = new System.Windows.Forms.Label();
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
			// panelDessin
			// 
			this.panelDessin.Location = new System.Drawing.Point(95, 0);
			this.panelDessin.Size = new System.Drawing.Size(510, 510);
			// 
			// labelEtat
			// 
			this.labelEtat.Size = new System.Drawing.Size(510, 510);
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
			this.panelAffichage.Controls.Add(this.labelChrono);
			this.panelAffichage.Location = new System.Drawing.Point(724, 0);
			this.panelAffichage.Size = new System.Drawing.Size(200, 511);
			this.panelAffichage.Controls.SetChildIndex(this.labelChrono, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelLevel, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelTaille, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelVitesse, 0);
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
			// timerChrono
			// 
			this.timerChrono.Interval = 1000;
			this.timerChrono.Tick += new System.EventHandler(this.TimerChronoTick);
			// 
			// labelChrono
			// 
			this.labelChrono.BackColor = System.Drawing.Color.Black;
			this.labelChrono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelChrono.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.labelChrono.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChrono.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelChrono.Location = new System.Drawing.Point(25, 189);
			this.labelChrono.Name = "labelChrono";
			this.labelChrono.Size = new System.Drawing.Size(150, 42);
			this.labelChrono.TabIndex = 1;
			this.labelChrono.Text = "00:00";
			this.labelChrono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FenJeuMontre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 561);
			this.Name = "FenJeuMontre";
			this.Text = "FenJeuMontre";
			this.panelPrincipale.ResumeLayout(false);
			this.panelBtn.ResumeLayout(false);
			this.panelDessin.ResumeLayout(false);
			this.panelAffichage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
