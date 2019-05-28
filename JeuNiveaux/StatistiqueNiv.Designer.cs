/*
 * Crée par SharpDevelop.
 * Utilisateur: utilisateur
 * Date: 25/02/2019
 * Heure: 22:00
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Snake
{
	partial class StatistiqueNiv
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvRecord;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHauteur;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLarg;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaille;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRes;
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
			this.dgvRecord = new System.Windows.Forms.DataGridView();
			this.colHauteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLarg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaille = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnRaz = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRecord
			// 
			this.dgvRecord.AllowUserToAddRows = false;
			this.dgvRecord.AllowUserToDeleteRows = false;
			this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colHauteur,
			this.colLarg,
			this.colTaille,
			this.colVit,
			this.colRes});
			this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRecord.Location = new System.Drawing.Point(0, 0);
			this.dgvRecord.Name = "dgvRecord";
			this.dgvRecord.ReadOnly = true;
			this.dgvRecord.Size = new System.Drawing.Size(672, 269);
			this.dgvRecord.TabIndex = 0;
			this.dgvRecord.TabStop = false;
			// 
			// colHauteur
			// 
			this.colHauteur.HeaderText = "Hauteur";
			this.colHauteur.Name = "colHauteur";
			this.colHauteur.ReadOnly = true;
			// 
			// colLarg
			// 
			this.colLarg.HeaderText = "Largeur";
			this.colLarg.Name = "colLarg";
			this.colLarg.ReadOnly = true;
			// 
			// colTaille
			// 
			this.colTaille.HeaderText = "Taille Snake";
			this.colTaille.Name = "colTaille";
			this.colTaille.ReadOnly = true;
			// 
			// colVit
			// 
			this.colVit.HeaderText = "Vitesse";
			this.colVit.Name = "colVit";
			this.colVit.ReadOnly = true;
			// 
			// colRes
			// 
			this.colRes.HeaderText = "Résultat";
			this.colRes.Name = "colRes";
			this.colRes.ReadOnly = true;
			// 
			// btnRaz
			// 
			this.btnRaz.Location = new System.Drawing.Point(550, 233);
			this.btnRaz.Name = "btnRaz";
			this.btnRaz.Size = new System.Drawing.Size(96, 24);
			this.btnRaz.TabIndex = 0;
			this.btnRaz.Text = "Réinitialiser";
			this.btnRaz.UseVisualStyleBackColor = true;
			this.btnRaz.Click += new System.EventHandler(this.BtnRazClick);
			// 
			// StatistiqueNiv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 269);
			this.Controls.Add(this.btnRaz);
			this.Controls.Add(this.dgvRecord);
			this.KeyPreview = true;
			this.Name = "StatistiqueNiv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Statistique";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FenDepartKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
