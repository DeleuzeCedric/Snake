/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 03/03/2019
 * Heure: 17:17
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Snake
{
	partial class FenJeu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		protected System.Windows.Forms.Panel panelPrincipale;
		protected System.Windows.Forms.Panel panelBtn;
		protected System.Windows.Forms.Label labelTouche;
		protected System.Windows.Forms.Button btnRejouer;
		protected System.Windows.Forms.Button btnRevenirDebut;
		protected System.Windows.Forms.Panel panelDessin;
		protected System.Windows.Forms.Label labelEtat;
		protected System.Windows.Forms.Timer timerJeu;
		protected System.Windows.Forms.Label labelTaille;
		protected System.Windows.Forms.Label labelLevel;
		protected System.Windows.Forms.Label labelVitesse;
		protected System.Windows.Forms.Panel panelAffichage;
		
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
		/// not be able to load this methode
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenJeu));
			this.panelPrincipale = new System.Windows.Forms.Panel();
			this.panelAffichage = new System.Windows.Forms.Panel();
			this.labelVitesse = new System.Windows.Forms.Label();
			this.labelTaille = new System.Windows.Forms.Label();
			this.labelLevel = new System.Windows.Forms.Label();
			this.panelDessin = new System.Windows.Forms.Panel();
			this.labelEtat = new System.Windows.Forms.Label();
			this.panelBtn = new System.Windows.Forms.Panel();
			this.btnRevenirDebut = new System.Windows.Forms.Button();
			this.btnRejouer = new System.Windows.Forms.Button();
			this.labelTouche = new System.Windows.Forms.Label();
			this.timerJeu = new System.Windows.Forms.Timer(this.components);
			this.panelPrincipale.SuspendLayout();
			this.panelAffichage.SuspendLayout();
			this.panelDessin.SuspendLayout();
			this.panelBtn.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPrincipale
			// 
			this.panelPrincipale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPrincipale.BackgroundImage")));
			this.panelPrincipale.Controls.Add(this.panelAffichage);
			this.panelPrincipale.Controls.Add(this.panelDessin);
			this.panelPrincipale.Controls.Add(this.panelBtn);
			this.panelPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPrincipale.Location = new System.Drawing.Point(0, 0);
			this.panelPrincipale.Name = "panelPrincipale";
			this.panelPrincipale.Size = new System.Drawing.Size(884, 598);
			this.panelPrincipale.TabIndex = 0;
			// 
			// panelAffichage
			// 
			this.panelAffichage.BackColor = System.Drawing.Color.Transparent;
			this.panelAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAffichage.Controls.Add(this.labelVitesse);
			this.panelAffichage.Controls.Add(this.labelTaille);
			this.panelAffichage.Controls.Add(this.labelLevel);
			this.panelAffichage.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelAffichage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelAffichage.Location = new System.Drawing.Point(684, 0);
			this.panelAffichage.Name = "panelAffichage";
			this.panelAffichage.Size = new System.Drawing.Size(200, 548);
			this.panelAffichage.TabIndex = 2;
			// 
			// labelVitesse
			// 
			this.labelVitesse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelVitesse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelVitesse.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVitesse.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelVitesse.Location = new System.Drawing.Point(25, 130);
			this.labelVitesse.Name = "labelVitesse";
			this.labelVitesse.Size = new System.Drawing.Size(150, 42);
			this.labelVitesse.TabIndex = 8;
			this.labelVitesse.Text = "Vitesse : 1";
			this.labelVitesse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTaille
			// 
			this.labelTaille.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelTaille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTaille.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTaille.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelTaille.Location = new System.Drawing.Point(25, 70);
			this.labelTaille.Name = "labelTaille";
			this.labelTaille.Size = new System.Drawing.Size(150, 42);
			this.labelTaille.TabIndex = 7;
			this.labelTaille.Text = "Taille : 1";
			this.labelTaille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelLevel
			// 
			this.labelLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLevel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLevel.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelLevel.Location = new System.Drawing.Point(25, 10);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(150, 42);
			this.labelLevel.TabIndex = 6;
			this.labelLevel.Text = "Level : 3 * 3";
			this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelDessin
			// 
			this.panelDessin.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelDessin.Controls.Add(this.labelEtat);
			this.panelDessin.Location = new System.Drawing.Point(225, 49);
			this.panelDessin.Name = "panelDessin";
			this.panelDessin.Size = new System.Drawing.Size(288, 259);
			this.panelDessin.TabIndex = 1;
			this.panelDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint);
			// 
			// labelEtat
			// 
			this.labelEtat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelEtat.Font = new System.Drawing.Font("Algerian", 50.25F);
			this.labelEtat.ForeColor = System.Drawing.Color.Red;
			this.labelEtat.Location = new System.Drawing.Point(0, 0);
			this.labelEtat.Name = "labelEtat";
			this.labelEtat.Size = new System.Drawing.Size(288, 259);
			this.labelEtat.TabIndex = 0;
			this.labelEtat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEtat.Visible = false;
			// 
			// panelBtn
			// 
			this.panelBtn.BackColor = System.Drawing.Color.Transparent;
			this.panelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBtn.Controls.Add(this.btnRevenirDebut);
			this.panelBtn.Controls.Add(this.btnRejouer);
			this.panelBtn.Controls.Add(this.labelTouche);
			this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBtn.Location = new System.Drawing.Point(0, 548);
			this.panelBtn.Name = "panelBtn";
			this.panelBtn.Size = new System.Drawing.Size(884, 50);
			this.panelBtn.TabIndex = 0;
			// 
			// btnRevenirDebut
			// 
			this.btnRevenirDebut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnRevenirDebut.Location = new System.Drawing.Point(476, 12);
			this.btnRevenirDebut.Name = "btnRevenirDebut";
			this.btnRevenirDebut.Size = new System.Drawing.Size(150, 28);
			this.btnRevenirDebut.TabIndex = 4;
			this.btnRevenirDebut.Text = "Revenir au menu principale";
			this.btnRevenirDebut.UseVisualStyleBackColor = true;
			this.btnRevenirDebut.Click += new System.EventHandler(this.BtnRevenirDebutClick);
			// 
			// btnRejouer
			// 
			this.btnRejouer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.btnRejouer.Location = new System.Drawing.Point(632, 12);
			this.btnRejouer.Name = "btnRejouer";
			this.btnRejouer.Size = new System.Drawing.Size(91, 28);
			this.btnRejouer.TabIndex = 5;
			this.btnRejouer.Text = "Rejouer (R)";
			this.btnRejouer.UseVisualStyleBackColor = true;
			this.btnRejouer.Click += new System.EventHandler(this.BtnRejouerClick);
			// 
			// labelTouche
			// 
			this.labelTouche.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold);
			this.labelTouche.ForeColor = System.Drawing.Color.Navy;
			this.labelTouche.Location = new System.Drawing.Point(7, 0);
			this.labelTouche.Name = "labelTouche";
			this.labelTouche.Size = new System.Drawing.Size(450, 49);
			this.labelTouche.TabIndex = 3;
			this.labelTouche.Text = "Touches :  ↑ z / ↓ s / → d  / ← q";
			this.labelTouche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timerJeu
			// 
			this.timerJeu.Interval = 500;
			this.timerJeu.Tick += new System.EventHandler(this.TimerJeuTick);
			// 
			// FenJeu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnRevenirDebut;
			this.ClientSize = new System.Drawing.Size(884, 598);
			this.Controls.Add(this.panelPrincipale);
			this.KeyPreview = true;
			this.Name = "FenJeu";
			this.Load += new System.EventHandler(this.FenJeuLoad);
			this.ResizeEnd += new System.EventHandler(this.FenJeuResizeEnd);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDirection);
			this.panelPrincipale.ResumeLayout(false);
			this.panelAffichage.ResumeLayout(false);
			this.panelDessin.ResumeLayout(false);
			this.panelBtn.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
