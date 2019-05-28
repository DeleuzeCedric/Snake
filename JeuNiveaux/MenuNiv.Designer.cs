/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 23/02/2019
 * Heure: 10:30
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Snake
{
	partial class MenuNiv
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblHauteurJeu;
		private System.Windows.Forms.Label lblLargeurJeu;
		private System.Windows.Forms.Label lblTailleSnake;
		private System.Windows.Forms.Label lblVitesseSnake;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.NumericUpDown saisieHauteJeu;
		private System.Windows.Forms.NumericUpDown saisieLargJeu;
		private System.Windows.Forms.NumericUpDown saisieTailleSnake;
		private System.Windows.Forms.NumericUpDown saisieVit;
		private System.Windows.Forms.Button btnRaz;
		
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
			this.lblHauteurJeu = new System.Windows.Forms.Label();
			this.lblLargeurJeu = new System.Windows.Forms.Label();
			this.lblTailleSnake = new System.Windows.Forms.Label();
			this.lblVitesseSnake = new System.Windows.Forms.Label();
			this.btnValider = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.saisieHauteJeu = new System.Windows.Forms.NumericUpDown();
			this.saisieLargJeu = new System.Windows.Forms.NumericUpDown();
			this.saisieTailleSnake = new System.Windows.Forms.NumericUpDown();
			this.saisieVit = new System.Windows.Forms.NumericUpDown();
			this.btnRaz = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.saisieHauteJeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieLargJeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieTailleSnake)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieVit)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHauteurJeu
			// 
			this.lblHauteurJeu.Location = new System.Drawing.Point(12, 9);
			this.lblHauteurJeu.Name = "lblHauteurJeu";
			this.lblHauteurJeu.Size = new System.Drawing.Size(113, 23);
			this.lblHauteurJeu.TabIndex = 0;
			this.lblHauteurJeu.Text = "Hauteur du jeu";
			this.lblHauteurJeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLargeurJeu
			// 
			this.lblLargeurJeu.Location = new System.Drawing.Point(12, 32);
			this.lblLargeurJeu.Name = "lblLargeurJeu";
			this.lblLargeurJeu.Size = new System.Drawing.Size(113, 23);
			this.lblLargeurJeu.TabIndex = 1;
			this.lblLargeurJeu.Text = "Largeur du jeu";
			this.lblLargeurJeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTailleSnake
			// 
			this.lblTailleSnake.Location = new System.Drawing.Point(12, 55);
			this.lblTailleSnake.Name = "lblTailleSnake";
			this.lblTailleSnake.Size = new System.Drawing.Size(113, 20);
			this.lblTailleSnake.TabIndex = 2;
			this.lblTailleSnake.Text = "Taille snake au départ";
			this.lblTailleSnake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVitesseSnake
			// 
			this.lblVitesseSnake.Location = new System.Drawing.Point(12, 75);
			this.lblVitesseSnake.Name = "lblVitesseSnake";
			this.lblVitesseSnake.Size = new System.Drawing.Size(113, 23);
			this.lblVitesseSnake.TabIndex = 3;
			this.lblVitesseSnake.Text = "Vitesse";
			this.lblVitesseSnake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(12, 107);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(90, 25);
			this.btnValider.TabIndex = 4;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.BtnValiderClick);
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(123, 107);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(90, 25);
			this.btnAnnuler.TabIndex = 5;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// saisieHauteJeu
			// 
			this.saisieHauteJeu.Location = new System.Drawing.Point(170, 12);
			this.saisieHauteJeu.Maximum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.saisieHauteJeu.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.saisieHauteJeu.Name = "saisieHauteJeu";
			this.saisieHauteJeu.Size = new System.Drawing.Size(39, 20);
			this.saisieHauteJeu.TabIndex = 0;
			this.saisieHauteJeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.saisieHauteJeu.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.saisieHauteJeu.ValueChanged += new System.EventHandler(this.SaisieDimValueChanged);
			// 
			// saisieLargJeu
			// 
			this.saisieLargJeu.Location = new System.Drawing.Point(170, 35);
			this.saisieLargJeu.Maximum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.saisieLargJeu.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.saisieLargJeu.Name = "saisieLargJeu";
			this.saisieLargJeu.Size = new System.Drawing.Size(39, 20);
			this.saisieLargJeu.TabIndex = 1;
			this.saisieLargJeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.saisieLargJeu.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.saisieLargJeu.ValueChanged += new System.EventHandler(this.SaisieDimValueChanged);
			// 
			// saisieTailleSnake
			// 
			this.saisieTailleSnake.Location = new System.Drawing.Point(170, 57);
			this.saisieTailleSnake.Maximum = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.saisieTailleSnake.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.saisieTailleSnake.Name = "saisieTailleSnake";
			this.saisieTailleSnake.Size = new System.Drawing.Size(39, 20);
			this.saisieTailleSnake.TabIndex = 2;
			this.saisieTailleSnake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.saisieTailleSnake.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// saisieVit
			// 
			this.saisieVit.Location = new System.Drawing.Point(170, 78);
			this.saisieVit.Maximum = new decimal(new int[] {
			9,
			0,
			0,
			0});
			this.saisieVit.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.saisieVit.Name = "saisieVit";
			this.saisieVit.Size = new System.Drawing.Size(39, 20);
			this.saisieVit.TabIndex = 3;
			this.saisieVit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.saisieVit.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			// 
			// btnRaz
			// 
			this.btnRaz.Location = new System.Drawing.Point(12, 138);
			this.btnRaz.Name = "btnRaz";
			this.btnRaz.Size = new System.Drawing.Size(201, 23);
			this.btnRaz.TabIndex = 6;
			this.btnRaz.Text = "Réinitialiser";
			this.btnRaz.UseVisualStyleBackColor = true;
			this.btnRaz.Click += new System.EventHandler(this.ButtonRazClick);
			// 
			// MenuNiv
			// 
			this.AcceptButton = this.btnValider;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAnnuler;
			this.ClientSize = new System.Drawing.Size(221, 170);
			this.Controls.Add(this.btnRaz);
			this.Controls.Add(this.saisieVit);
			this.Controls.Add(this.saisieTailleSnake);
			this.Controls.Add(this.saisieLargJeu);
			this.Controls.Add(this.saisieHauteJeu);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.lblVitesseSnake);
			this.Controls.Add(this.lblTailleSnake);
			this.Controls.Add(this.lblLargeurJeu);
			this.Controls.Add(this.lblHauteurJeu);
			this.MaximizeBox = false;
			this.Name = "MenuNiv";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.saisieHauteJeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieLargJeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieTailleSnake)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.saisieVit)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
