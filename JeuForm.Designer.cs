namespace JeuCavalier
{
    partial class JeuForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.score = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(820, 49);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(116, 36);
            this.score.TabIndex = 0;
            this.score.Text = "label1";
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Lucida Handwriting", 9.25F);
            this.Restart.Location = new System.Drawing.Point(842, 201);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(118, 47);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Recommencer";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Lucida Handwriting", 9.25F);
            this.Quit.Location = new System.Drawing.Point(842, 345);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(118, 50);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quitter";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // JeuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.score);
            this.Name = "JeuForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JeuForm_FormClosing);
            this.Load += new System.EventHandler(this.JeuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Quit;
    }
}

