namespace ToutEmbal
{
    partial class Prod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prod));
            this.Menunav = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproduction = new System.Windows.Forms.ToolStripMenuItem();
            this.demarre = new System.Windows.Forms.ToolStripMenuItem();
            this.DemA = new System.Windows.Forms.ToolStripMenuItem();
            this.DemB = new System.Windows.Forms.ToolStripMenuItem();
            this.DemC = new System.Windows.Forms.ToolStripMenuItem();
            this.Arret = new System.Windows.Forms.ToolStripMenuItem();
            this.arretA = new System.Windows.Forms.ToolStripMenuItem();
            this.arretB = new System.Windows.Forms.ToolStripMenuItem();
            this.arretC = new System.Windows.Forms.ToolStripMenuItem();
            this.continuer = new System.Windows.Forms.ToolStripMenuItem();
            this.contA = new System.Windows.Forms.ToolStripMenuItem();
            this.contB = new System.Windows.Forms.ToolStripMenuItem();
            this.contC = new System.Windows.Forms.ToolStripMenuItem();
            this.Affichagetype = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbDefDemA = new System.Windows.Forms.TextBox();
            this.tbdefheureA = new System.Windows.Forms.TextBox();
            this.tbnbcaisseA = new System.Windows.Forms.TextBox();
            this.TauxdefdemA = new System.Windows.Forms.Label();
            this.labeltauxheureA = new System.Windows.Forms.Label();
            this.labelNbCaisseA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbDefDemB = new System.Windows.Forms.TextBox();
            this.tbdefheureB = new System.Windows.Forms.TextBox();
            this.tbnbcaisseB = new System.Windows.Forms.TextBox();
            this.TauxdefdemB = new System.Windows.Forms.Label();
            this.labeltauxheureB = new System.Windows.Forms.Label();
            this.labelNbCaisseB = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbDefDemC = new System.Windows.Forms.TextBox();
            this.tbdefheureC = new System.Windows.Forms.TextBox();
            this.tbnbcaisseC = new System.Windows.Forms.TextBox();
            this.TauxdefdemC = new System.Windows.Forms.Label();
            this.labeltauxheureC = new System.Windows.Forms.Label();
            this.labelNbCaisseC = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.LabelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerprod = new System.Windows.Forms.Timer(this.components);
            this.Menunav.SuspendLayout();
            this.Affichagetype.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menunav
            // 
            this.Menunav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menunav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.menuproduction});
            this.Menunav.Location = new System.Drawing.Point(0, 0);
            this.Menunav.Name = "Menunav";
            this.Menunav.Size = new System.Drawing.Size(804, 24);
            this.Menunav.TabIndex = 0;
            this.Menunav.Text = "Menu";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // menuproduction
            // 
            this.menuproduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarre,
            this.Arret,
            this.continuer});
            this.menuproduction.Name = "menuproduction";
            this.menuproduction.Size = new System.Drawing.Size(78, 20);
            this.menuproduction.Text = "Production";
            // 
            // demarre
            // 
            this.demarre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DemA,
            this.DemB,
            this.DemC});
            this.demarre.Name = "demarre";
            this.demarre.Size = new System.Drawing.Size(127, 22);
            this.demarre.Tag = "";
            this.demarre.Text = "Démarrer";
            // 
            // DemA
            // 
            this.DemA.Name = "DemA";
            this.DemA.Size = new System.Drawing.Size(82, 22);
            this.DemA.Tag = "\"A\"";
            this.DemA.Text = "A";
            this.DemA.Click += new System.EventHandler(this.Demarre_Click);
            // 
            // DemB
            // 
            this.DemB.Name = "DemB";
            this.DemB.Size = new System.Drawing.Size(82, 22);
            this.DemB.Text = "B";
            this.DemB.Click += new System.EventHandler(this.Demarre_Click);
            // 
            // DemC
            // 
            this.DemC.Name = "DemC";
            this.DemC.Size = new System.Drawing.Size(82, 22);
            this.DemC.Text = "C";
            this.DemC.Click += new System.EventHandler(this.Demarre_Click);
            // 
            // Arret
            // 
            this.Arret.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arretA,
            this.arretB,
            this.arretC});
            this.Arret.Name = "Arret";
            this.Arret.Size = new System.Drawing.Size(127, 22);
            this.Arret.Text = "Arrêter";
            // 
            // arretA
            // 
            this.arretA.Name = "arretA";
            this.arretA.Size = new System.Drawing.Size(82, 22);
            this.arretA.Text = "A";
            this.arretA.Click += new System.EventHandler(this.ArretA_Click);
            // 
            // arretB
            // 
            this.arretB.Name = "arretB";
            this.arretB.Size = new System.Drawing.Size(82, 22);
            this.arretB.Text = "B";
            this.arretB.Click += new System.EventHandler(this.ArretA_Click);
            // 
            // arretC
            // 
            this.arretC.Name = "arretC";
            this.arretC.Size = new System.Drawing.Size(82, 22);
            this.arretC.Text = "C";
            this.arretC.Click += new System.EventHandler(this.ArretA_Click);
            // 
            // continuer
            // 
            this.continuer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contA,
            this.contB,
            this.contC});
            this.continuer.Name = "continuer";
            this.continuer.Size = new System.Drawing.Size(127, 22);
            this.continuer.Text = "Continuer";
            // 
            // contA
            // 
            this.contA.Name = "contA";
            this.contA.Size = new System.Drawing.Size(82, 22);
            this.contA.Text = "A";
            this.contA.Click += new System.EventHandler(this.ContA_Click);
            // 
            // contB
            // 
            this.contB.Name = "contB";
            this.contB.Size = new System.Drawing.Size(82, 22);
            this.contB.Text = "B";
            this.contB.Click += new System.EventHandler(this.ContA_Click);
            // 
            // contC
            // 
            this.contC.Name = "contC";
            this.contC.Size = new System.Drawing.Size(82, 22);
            this.contC.Text = "C";
            this.contC.Click += new System.EventHandler(this.ContA_Click);
            // 
            // Affichagetype
            // 
            this.Affichagetype.Controls.Add(this.tabPage1);
            this.Affichagetype.Controls.Add(this.tabPage2);
            this.Affichagetype.Controls.Add(this.tabPage3);
            this.Affichagetype.Location = new System.Drawing.Point(286, 158);
            this.Affichagetype.Name = "Affichagetype";
            this.Affichagetype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Affichagetype.SelectedIndex = 0;
            this.Affichagetype.Size = new System.Drawing.Size(506, 138);
            this.Affichagetype.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbDefDemA);
            this.tabPage1.Controls.Add(this.tbdefheureA);
            this.tabPage1.Controls.Add(this.tbnbcaisseA);
            this.tabPage1.Controls.Add(this.TauxdefdemA);
            this.tabPage1.Controls.Add(this.labeltauxheureA);
            this.tabPage1.Controls.Add(this.labelNbCaisseA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Type A";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbDefDemA
            // 
            this.tbDefDemA.Location = new System.Drawing.Point(207, 72);
            this.tbDefDemA.Name = "tbDefDemA";
            this.tbDefDemA.Size = new System.Drawing.Size(110, 20);
            this.tbDefDemA.TabIndex = 5;
            this.tbDefDemA.Text = "0,0000";
            // 
            // tbdefheureA
            // 
            this.tbdefheureA.Location = new System.Drawing.Point(207, 43);
            this.tbdefheureA.Name = "tbdefheureA";
            this.tbdefheureA.Size = new System.Drawing.Size(110, 20);
            this.tbdefheureA.TabIndex = 4;
            this.tbdefheureA.Text = "0,0000";
            // 
            // tbnbcaisseA
            // 
            this.tbnbcaisseA.Location = new System.Drawing.Point(207, 15);
            this.tbnbcaisseA.Name = "tbnbcaisseA";
            this.tbnbcaisseA.Size = new System.Drawing.Size(110, 20);
            this.tbnbcaisseA.TabIndex = 3;
            this.tbnbcaisseA.Tag = "A";
            // 
            // TauxdefdemA
            // 
            this.TauxdefdemA.AutoSize = true;
            this.TauxdefdemA.Location = new System.Drawing.Point(6, 79);
            this.TauxdefdemA.Name = "TauxdefdemA";
            this.TauxdefdemA.Size = new System.Drawing.Size(156, 13);
            this.TauxdefdemA.TabIndex = 2;
            this.TauxdefdemA.Text = "Taux défauts depuis démarrage";
            // 
            // labeltauxheureA
            // 
            this.labeltauxheureA.AutoSize = true;
            this.labeltauxheureA.Location = new System.Drawing.Point(6, 50);
            this.labeltauxheureA.Name = "labeltauxheureA";
            this.labeltauxheureA.Size = new System.Drawing.Size(99, 13);
            this.labeltauxheureA.TabIndex = 1;
            this.labeltauxheureA.Text = "Taux défauts heure";
            // 
            // labelNbCaisseA
            // 
            this.labelNbCaisseA.AutoSize = true;
            this.labelNbCaisseA.Location = new System.Drawing.Point(6, 22);
            this.labelNbCaisseA.Name = "labelNbCaisseA";
            this.labelNbCaisseA.Size = new System.Drawing.Size(195, 13);
            this.labelNbCaisseA.TabIndex = 0;
            this.labelNbCaisseA.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbDefDemB);
            this.tabPage2.Controls.Add(this.tbdefheureB);
            this.tabPage2.Controls.Add(this.tbnbcaisseB);
            this.tabPage2.Controls.Add(this.TauxdefdemB);
            this.tabPage2.Controls.Add(this.labeltauxheureB);
            this.tabPage2.Controls.Add(this.labelNbCaisseB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type B";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbDefDemB
            // 
            this.tbDefDemB.Location = new System.Drawing.Point(207, 70);
            this.tbDefDemB.Name = "tbDefDemB";
            this.tbDefDemB.Size = new System.Drawing.Size(110, 20);
            this.tbDefDemB.TabIndex = 8;
            // 
            // tbdefheureB
            // 
            this.tbdefheureB.Location = new System.Drawing.Point(207, 41);
            this.tbdefheureB.Name = "tbdefheureB";
            this.tbdefheureB.Size = new System.Drawing.Size(110, 20);
            this.tbdefheureB.TabIndex = 7;
            // 
            // tbnbcaisseB
            // 
            this.tbnbcaisseB.Location = new System.Drawing.Point(207, 13);
            this.tbnbcaisseB.Name = "tbnbcaisseB";
            this.tbnbcaisseB.Size = new System.Drawing.Size(110, 20);
            this.tbnbcaisseB.TabIndex = 6;
            this.tbnbcaisseB.Tag = "B";
            // 
            // TauxdefdemB
            // 
            this.TauxdefdemB.AutoSize = true;
            this.TauxdefdemB.Location = new System.Drawing.Point(6, 77);
            this.TauxdefdemB.Name = "TauxdefdemB";
            this.TauxdefdemB.Size = new System.Drawing.Size(156, 13);
            this.TauxdefdemB.TabIndex = 5;
            this.TauxdefdemB.Text = "Taux défauts depuis démarrage";
            // 
            // labeltauxheureB
            // 
            this.labeltauxheureB.AutoSize = true;
            this.labeltauxheureB.Location = new System.Drawing.Point(6, 48);
            this.labeltauxheureB.Name = "labeltauxheureB";
            this.labeltauxheureB.Size = new System.Drawing.Size(99, 13);
            this.labeltauxheureB.TabIndex = 4;
            this.labeltauxheureB.Text = "Taux défauts heure";
            // 
            // labelNbCaisseB
            // 
            this.labelNbCaisseB.AutoSize = true;
            this.labelNbCaisseB.Location = new System.Drawing.Point(6, 20);
            this.labelNbCaisseB.Name = "labelNbCaisseB";
            this.labelNbCaisseB.Size = new System.Drawing.Size(195, 13);
            this.labelNbCaisseB.TabIndex = 3;
            this.labelNbCaisseB.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbDefDemC);
            this.tabPage3.Controls.Add(this.tbdefheureC);
            this.tabPage3.Controls.Add(this.tbnbcaisseC);
            this.tabPage3.Controls.Add(this.TauxdefdemC);
            this.tabPage3.Controls.Add(this.labeltauxheureC);
            this.tabPage3.Controls.Add(this.labelNbCaisseC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(498, 112);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Type C";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbDefDemC
            // 
            this.tbDefDemC.Location = new System.Drawing.Point(207, 72);
            this.tbDefDemC.Name = "tbDefDemC";
            this.tbDefDemC.Size = new System.Drawing.Size(110, 20);
            this.tbDefDemC.TabIndex = 8;
            // 
            // tbdefheureC
            // 
            this.tbdefheureC.Location = new System.Drawing.Point(207, 43);
            this.tbdefheureC.Name = "tbdefheureC";
            this.tbdefheureC.Size = new System.Drawing.Size(110, 20);
            this.tbdefheureC.TabIndex = 7;
            // 
            // tbnbcaisseC
            // 
            this.tbnbcaisseC.Location = new System.Drawing.Point(207, 15);
            this.tbnbcaisseC.Name = "tbnbcaisseC";
            this.tbnbcaisseC.Size = new System.Drawing.Size(110, 20);
            this.tbnbcaisseC.TabIndex = 6;
            this.tbnbcaisseC.Tag = "C";
            // 
            // TauxdefdemC
            // 
            this.TauxdefdemC.AutoSize = true;
            this.TauxdefdemC.Location = new System.Drawing.Point(6, 79);
            this.TauxdefdemC.Name = "TauxdefdemC";
            this.TauxdefdemC.Size = new System.Drawing.Size(156, 13);
            this.TauxdefdemC.TabIndex = 5;
            this.TauxdefdemC.Text = "Taux défauts depuis démarrage";
            // 
            // labeltauxheureC
            // 
            this.labeltauxheureC.AutoSize = true;
            this.labeltauxheureC.Location = new System.Drawing.Point(6, 50);
            this.labeltauxheureC.Name = "labeltauxheureC";
            this.labeltauxheureC.Size = new System.Drawing.Size(99, 13);
            this.labeltauxheureC.TabIndex = 4;
            this.labeltauxheureC.Text = "Taux défauts heure";
            // 
            // labelNbCaisseC
            // 
            this.labelNbCaisseC.AutoSize = true;
            this.labelNbCaisseC.Location = new System.Drawing.Point(6, 22);
            this.labelNbCaisseC.Name = "labelNbCaisseC";
            this.labelNbCaisseC.Size = new System.Drawing.Size(195, 13);
            this.labelNbCaisseC.TabIndex = 3;
            this.labelNbCaisseC.Text = "Nombre de caisses depuis le démarrage";
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(123, 302);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(669, 27);
            this.progressBarA.Step = 1;
            this.progressBarA.TabIndex = 2;
            this.progressBarA.Tag = "A";
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(123, 335);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(669, 27);
            this.progressBarB.TabIndex = 3;
            this.progressBarB.Tag = "B";
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(125, 368);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(667, 27);
            this.progressBarC.TabIndex = 4;
            this.progressBarC.Tag = "C";
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelA.Location = new System.Drawing.Point(12, 311);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(105, 18);
            this.LabelA.TabIndex = 5;
            this.LabelA.Text = "Production A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(12, 344);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(106, 18);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "Production B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(12, 377);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(107, 18);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "Production C";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerprod
            // 
            this.timerprod.Interval = 1000;
            this.timerprod.Tick += new System.EventHandler(this.Click_Timer);
            // 
            // Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 432);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.LabelA);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.Affichagetype);
            this.Controls.Add(this.Menunav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menunav;
            this.Name = "Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alphonse Patacaisse";
            this.Load += new System.EventHandler(this.Prod_Load);
            this.Menunav.ResumeLayout(false);
            this.Menunav.PerformLayout();
            this.Affichagetype.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menunav;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuproduction;
        private System.Windows.Forms.ToolStripMenuItem demarre;
        private System.Windows.Forms.ToolStripMenuItem DemA;
        private System.Windows.Forms.ToolStripMenuItem DemB;
        private System.Windows.Forms.ToolStripMenuItem DemC;
        private System.Windows.Forms.ToolStripMenuItem Arret;
        private System.Windows.Forms.ToolStripMenuItem arretA;
        private System.Windows.Forms.ToolStripMenuItem arretB;
        private System.Windows.Forms.ToolStripMenuItem arretC;
        private System.Windows.Forms.ToolStripMenuItem continuer;
        private System.Windows.Forms.ToolStripMenuItem contA;
        private System.Windows.Forms.ToolStripMenuItem contB;
        private System.Windows.Forms.ToolStripMenuItem contC;
        private System.Windows.Forms.TabControl Affichagetype;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label TauxdefdemA;
        private System.Windows.Forms.Label labeltauxheureA;
        private System.Windows.Forms.Label labelNbCaisseA;
        private System.Windows.Forms.Label TauxdefdemC;
        private System.Windows.Forms.Label labeltauxheureC;
        private System.Windows.Forms.Label labelNbCaisseC;
        private System.Windows.Forms.TextBox tbDefDemA;
        private System.Windows.Forms.TextBox tbdefheureA;
        private System.Windows.Forms.TextBox tbnbcaisseA;
        private System.Windows.Forms.TextBox tbDefDemC;
        private System.Windows.Forms.TextBox tbdefheureC;
        private System.Windows.Forms.TextBox tbnbcaisseC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbDefDemB;
        private System.Windows.Forms.TextBox tbdefheureB;
        private System.Windows.Forms.TextBox tbnbcaisseB;
        private System.Windows.Forms.Label TauxdefdemB;
        private System.Windows.Forms.Label labeltauxheureB;
        private System.Windows.Forms.Label labelNbCaisseB;
        private System.Windows.Forms.Timer timerprod;
        internal System.Windows.Forms.ProgressBar progressBarA;
    }
}

