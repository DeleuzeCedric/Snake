/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 27/02/2019
 * Heure: 11:02
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Snake
{
	partial class FenDepart
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnNiv;
		private System.Windows.Forms.Button btnContreMontre;
		private System.Windows.Forms.Button btnSurvie;
		private System.Windows.Forms.Label lblBvn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenDepart));
			this.btnNiv = new System.Windows.Forms.Button();
			this.btnContreMontre = new System.Windows.Forms.Button();
			this.btnSurvie = new System.Windows.Forms.Button();
			this.lblBvn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNiv
			// 
			this.btnNiv.Location = new System.Drawing.Point(12, 300);
			this.btnNiv.Name = "btnNiv";
			this.btnNiv.Size = new System.Drawing.Size(100, 45);
			this.btnNiv.TabIndex = 0;
			this.btnNiv.Text = "Niveaux (1)";
			this.btnNiv.UseVisualStyleBackColor = true;
			this.btnNiv.Click += new System.EventHandler(this.BtnNivClick);
			// 
			// btnContreMontre
			// 
			this.btnContreMontre.Location = new System.Drawing.Point(128, 300);
			this.btnContreMontre.Name = "btnContreMontre";
			this.btnContreMontre.Size = new System.Drawing.Size(126, 45);
			this.btnContreMontre.TabIndex = 1;
			this.btnContreMontre.Text = "Contre la montre (2)";
			this.btnContreMontre.UseVisualStyleBackColor = true;
			this.btnContreMontre.Click += new System.EventHandler(this.BtnContreMontreClick);
			// 
			// btnSurvie
			// 
			this.btnSurvie.Location = new System.Drawing.Point(272, 300);
			this.btnSurvie.Name = "btnSurvie";
			this.btnSurvie.Size = new System.Drawing.Size(100, 45);
			this.btnSurvie.TabIndex = 2;
			this.btnSurvie.Text = "Survie (3)";
			this.btnSurvie.UseVisualStyleBackColor = true;
			this.btnSurvie.Click += new System.EventHandler(this.BtnSurvieClick);
			// 
			// lblBvn
			// 
			this.lblBvn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblBvn.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblBvn.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
				| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBvn.ForeColor = System.Drawing.Color.MediumBlue;
			this.lblBvn.Location = new System.Drawing.Point(0, 0);
			this.lblBvn.Name = "lblBvn";
			this.lblBvn.Size = new System.Drawing.Size(384, 219);
			this.lblBvn.TabIndex = 3;
			this.lblBvn.Text = "Bienvenue au jeu du Snake";
			this.lblBvn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FenDepart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.lblBvn);
			this.Controls.Add(this.btnSurvie);
			this.Controls.Add(this.btnContreMontre);
			this.Controls.Add(this.btnNiv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FenDepart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FenDepart";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FenDepartKeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FenDepartKeyPress);
			this.ResumeLayout(false);

		}
	}
}
