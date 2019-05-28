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
	partial class FenJeuSurvie
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		protected System.Windows.Forms.Label lblPiege;
		protected System.Windows.Forms.Label lblPomme;
		protected System.Windows.Forms.Label labelProchNiv;
		
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
		private void InitializeComponent(){
			this.lblPiege = new System.Windows.Forms.Label();
			this.lblPomme = new System.Windows.Forms.Label();
			this.labelProchNiv = new System.Windows.Forms.Label();
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
			this.panelBtn.Location = new System.Drawing.Point(0, 511);
			this.panelBtn.Size = new System.Drawing.Size(924, 50);
			// 
			// panelDessin
			// 
			this.panelDessin.Location = new System.Drawing.Point(70, 2);
			this.panelDessin.Size = new System.Drawing.Size(545, 443);
			// 
			// labelEtat
			// 
			this.labelEtat.Size = new System.Drawing.Size(545, 443);
			// 
			// labelTaille
			// 
			this.labelTaille.Location = new System.Drawing.Point(26, 330);
			// 
			// labelLevel
			// 
			this.labelLevel.Location = new System.Drawing.Point(26, 92);
			this.labelLevel.Text = "Level : 5 * 5";
			// 
			// labelVitesse
			// 
			this.labelVitesse.Location = new System.Drawing.Point(26, 153);
			this.labelVitesse.Text = "Vitesse : 5";
			// 
			// panelAffichage
			// 
			this.panelAffichage.Controls.Add(this.labelProchNiv);
			this.panelAffichage.Controls.Add(this.lblPiege);
			this.panelAffichage.Controls.Add(this.lblPomme);
			this.panelAffichage.Location = new System.Drawing.Point(724, 0);
			this.panelAffichage.Size = new System.Drawing.Size(200, 511);
			this.panelAffichage.Controls.SetChildIndex(this.labelLevel, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelTaille, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelVitesse, 0);
			this.panelAffichage.Controls.SetChildIndex(this.lblPomme, 0);
			this.panelAffichage.Controls.SetChildIndex(this.lblPiege, 0);
			this.panelAffichage.Controls.SetChildIndex(this.labelProchNiv, 0);
			// 
			// lblPiege
			// 
			this.lblPiege.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPiege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPiege.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPiege.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblPiege.Location = new System.Drawing.Point(26, 272);
			this.lblPiege.Name = "lblPiege";
			this.lblPiege.Size = new System.Drawing.Size(150, 42);
			this.lblPiege.TabIndex = 10;
			this.lblPiege.Text = "Piege : 1";
			this.lblPiege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPomme
			// 
			this.lblPomme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPomme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPomme.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPomme.ForeColor = System.Drawing.Color.LawnGreen;
			this.lblPomme.Location = new System.Drawing.Point(26, 212);
			this.lblPomme.Name = "lblPomme";
			this.lblPomme.Size = new System.Drawing.Size(150, 42);
			this.lblPomme.TabIndex = 9;
			this.lblPomme.Text = "Pomme : 1";
			this.lblPomme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelProchNiv
			// 
			this.labelProchNiv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelProchNiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelProchNiv.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProchNiv.ForeColor = System.Drawing.Color.LawnGreen;
			this.labelProchNiv.Location = new System.Drawing.Point(0, 19);
			this.labelProchNiv.Name = "labelProchNiv";
			this.labelProchNiv.Size = new System.Drawing.Size(200, 55);
			this.labelProchNiv.TabIndex = 12;
			this.labelProchNiv.Text = "Prochain Niveau : 999";
			this.labelProchNiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FenJeuSurvie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 561);
			this.Name = "FenJeuSurvie";
			this.Text = "FenJeuSurvie";
			this.panelPrincipale.ResumeLayout(false);
			this.panelBtn.ResumeLayout(false);
			this.panelDessin.ResumeLayout(false);
			this.panelAffichage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
