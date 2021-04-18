namespace ProjectV1
{
    partial class equipe
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipe));
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton6 = new Guna.UI.WinForms.GunaGradientButton();
            this.add = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matricule_equipe = new Guna.UI.WinForms.GunaTextBox();
            this.nom_equipe = new Guna.UI.WinForms.GunaTextBox();
            this.code_equipemnt = new Guna.UI.WinForms.GunaTextBox();
            this.ajouterequipe = new Guna.UI.WinForms.GunaGradientButton();
            this.working_back = new System.ComponentModel.BackgroundWorker();
            this.continer = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Panel();
            this.view_data = new System.Windows.Forms.DataGridView();
            this.Entree = new Guna.UI.WinForms.GunaGradientButton();
            this.worker_back_view = new System.ComponentModel.BackgroundWorker();
            this.add.SuspendLayout();
            this.continer.SuspendLayout();
            this.view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).BeginInit();
            this.SuspendLayout();
            // 
            // progresbar
            // 
            this.progresbar.Animated = true;
            this.progresbar.AnimationSpeed = 1.5F;
            this.progresbar.BackColor = System.Drawing.Color.Transparent;
            this.progresbar.BaseColor = System.Drawing.Color.White;
            this.progresbar.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.progresbar.IdleOffset = 20;
            this.progresbar.IdleThickness = 10;
            this.progresbar.Image = null;
            this.progresbar.ImageSize = new System.Drawing.Size(52, 52);
            this.progresbar.Location = new System.Drawing.Point(491, 14);
            this.progresbar.Name = "progresbar";
            this.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.progresbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progresbar.ProgressOffset = 20;
            this.progresbar.ProgressThickness = 10;
            this.progresbar.Size = new System.Drawing.Size(60, 60);
            this.progresbar.TabIndex = 17;
            this.progresbar.Value = 20;
            this.progresbar.Click += new System.EventHandler(this.progresbar_Click);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton4.Image")));
            this.gunaGradientButton4.ImageOffsetX = 2;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(769, 16);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Radius = 20;
            this.gunaGradientButton4.Size = new System.Drawing.Size(44, 44);
            this.gunaGradientButton4.TabIndex = 18;
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // gunaGradientButton6
            // 
            this.gunaGradientButton6.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton6.AnimationSpeed = 0.03F;
            this.gunaGradientButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton6.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton6.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton6.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton6.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton6.Image")));
            this.gunaGradientButton6.ImageOffsetX = -1;
            this.gunaGradientButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaGradientButton6.Location = new System.Drawing.Point(835, 17);
            this.gunaGradientButton6.Name = "gunaGradientButton6";
            this.gunaGradientButton6.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton6.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton6.OnHoverImage = null;
            this.gunaGradientButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.Radius = 20;
            this.gunaGradientButton6.Size = new System.Drawing.Size(44, 44);
            this.gunaGradientButton6.TabIndex = 19;
            this.gunaGradientButton6.Click += new System.EventHandler(this.gunaGradientButton6_Click);
            // 
            // add
            // 
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.matricule_equipe);
            this.add.Controls.Add(this.nom_equipe);
            this.add.Controls.Add(this.code_equipemnt);
            this.add.Controls.Add(this.ajouterequipe);
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Location = new System.Drawing.Point(0, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(995, 458);
            this.add.TabIndex = 21;
            this.add.Paint += new System.Windows.Forms.PaintEventHandler(this.add_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Code";
            // 
            // matricule_equipe
            // 
            this.matricule_equipe.BackColor = System.Drawing.Color.Transparent;
            this.matricule_equipe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matricule_equipe.BorderColor = System.Drawing.Color.Silver;
            this.matricule_equipe.BorderSize = 0;
            this.matricule_equipe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matricule_equipe.FocusedBaseColor = System.Drawing.Color.White;
            this.matricule_equipe.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.matricule_equipe.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.matricule_equipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.matricule_equipe.Location = new System.Drawing.Point(32, 218);
            this.matricule_equipe.Name = "matricule_equipe";
            this.matricule_equipe.PasswordChar = '\0';
            this.matricule_equipe.Radius = 10;
            this.matricule_equipe.SelectedText = "";
            this.matricule_equipe.Size = new System.Drawing.Size(356, 50);
            this.matricule_equipe.TabIndex = 27;
            this.matricule_equipe.TextOffsetX = 10;
            // 
            // nom_equipe
            // 
            this.nom_equipe.BackColor = System.Drawing.Color.Transparent;
            this.nom_equipe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom_equipe.BorderColor = System.Drawing.Color.Silver;
            this.nom_equipe.BorderSize = 0;
            this.nom_equipe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_equipe.FocusedBaseColor = System.Drawing.Color.White;
            this.nom_equipe.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nom_equipe.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nom_equipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_equipe.Location = new System.Drawing.Point(32, 148);
            this.nom_equipe.Name = "nom_equipe";
            this.nom_equipe.PasswordChar = '\0';
            this.nom_equipe.Radius = 10;
            this.nom_equipe.SelectedText = "";
            this.nom_equipe.Size = new System.Drawing.Size(356, 50);
            this.nom_equipe.TabIndex = 28;
            this.nom_equipe.TextOffsetX = 10;
            // 
            // code_equipemnt
            // 
            this.code_equipemnt.BackColor = System.Drawing.Color.Transparent;
            this.code_equipemnt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.code_equipemnt.BorderColor = System.Drawing.Color.Silver;
            this.code_equipemnt.BorderSize = 0;
            this.code_equipemnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_equipemnt.FocusedBaseColor = System.Drawing.Color.White;
            this.code_equipemnt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.code_equipemnt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.code_equipemnt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.code_equipemnt.Location = new System.Drawing.Point(32, 78);
            this.code_equipemnt.Name = "code_equipemnt";
            this.code_equipemnt.PasswordChar = '\0';
            this.code_equipemnt.Radius = 10;
            this.code_equipemnt.SelectedText = "";
            this.code_equipemnt.Size = new System.Drawing.Size(356, 50);
            this.code_equipemnt.TabIndex = 29;
            this.code_equipemnt.TextOffsetX = 10;
            // 
            // ajouterequipe
            // 
            this.ajouterequipe.AnimationHoverSpeed = 0.07F;
            this.ajouterequipe.AnimationSpeed = 0.03F;
            this.ajouterequipe.BackColor = System.Drawing.Color.Transparent;
            this.ajouterequipe.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.ajouterequipe.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.ajouterequipe.BorderColor = System.Drawing.Color.Transparent;
            this.ajouterequipe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ajouterequipe.FocusedColor = System.Drawing.Color.Empty;
            this.ajouterequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterequipe.ForeColor = System.Drawing.Color.White;
            this.ajouterequipe.Image = ((System.Drawing.Image)(resources.GetObject("ajouterequipe.Image")));
            this.ajouterequipe.ImageSize = new System.Drawing.Size(20, 20);
            this.ajouterequipe.Location = new System.Drawing.Point(32, 383);
            this.ajouterequipe.Name = "ajouterequipe";
            this.ajouterequipe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.ajouterequipe.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ajouterequipe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ajouterequipe.OnHoverForeColor = System.Drawing.Color.White;
            this.ajouterequipe.OnHoverImage = null;
            this.ajouterequipe.OnPressedColor = System.Drawing.Color.Black;
            this.ajouterequipe.Radius = 5;
            this.ajouterequipe.Size = new System.Drawing.Size(129, 45);
            this.ajouterequipe.TabIndex = 19;
            this.ajouterequipe.Text = "Ajoutter";
            this.ajouterequipe.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // working_back
            // 
            this.working_back.DoWork += new System.ComponentModel.DoWorkEventHandler(this.working_back_DoWork);
            this.working_back.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.working_back_RunWorkerCompleted);
            // 
            // continer
            // 
            this.continer.Controls.Add(this.add);
            this.continer.Controls.Add(this.view);
            this.continer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.continer.Location = new System.Drawing.Point(0, 66);
            this.continer.Name = "continer";
            this.continer.Size = new System.Drawing.Size(995, 458);
            this.continer.TabIndex = 30;
            // 
            // view
            // 
            this.view.Controls.Add(this.view_data);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(995, 458);
            this.view.TabIndex = 30;
            // 
            // view_data
            // 
            this.view_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_data.Location = new System.Drawing.Point(0, 0);
            this.view_data.Name = "view_data";
            this.view_data.Size = new System.Drawing.Size(995, 458);
            this.view_data.TabIndex = 0;
            // 
            // Entree
            // 
            this.Entree.AnimationHoverSpeed = 0.07F;
            this.Entree.AnimationSpeed = 0.03F;
            this.Entree.BackColor = System.Drawing.Color.Transparent;
            this.Entree.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.Entree.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.Entree.BorderColor = System.Drawing.Color.Transparent;
            this.Entree.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Entree.FocusedColor = System.Drawing.Color.Empty;
            this.Entree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entree.ForeColor = System.Drawing.Color.White;
            this.Entree.Image = ((System.Drawing.Image)(resources.GetObject("Entree.Image")));
            this.Entree.ImageSize = new System.Drawing.Size(20, 20);
            this.Entree.Location = new System.Drawing.Point(32, 14);
            this.Entree.Name = "Entree";
            this.Entree.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Entree.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Entree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Entree.OnHoverForeColor = System.Drawing.Color.White;
            this.Entree.OnHoverImage = null;
            this.Entree.OnPressedColor = System.Drawing.Color.Black;
            this.Entree.Radius = 5;
            this.Entree.Size = new System.Drawing.Size(129, 45);
            this.Entree.TabIndex = 31;
            this.Entree.Text = "Entrée";
            this.Entree.Click += new System.EventHandler(this.Entree_Click);
            // 
            // worker_back_view
            // 
            this.worker_back_view.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_back_view_DoWork);
            this.worker_back_view.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_back_view_RunWorkerCompleted);
            // 
            // equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Entree);
            this.Controls.Add(this.continer);
            this.Controls.Add(this.gunaGradientButton6);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.progresbar);
            this.Name = "equipe";
            this.Size = new System.Drawing.Size(995, 524);
            this.Load += new System.EventHandler(this.equipe_Load);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.continer.ResumeLayout(false);
            this.view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton6;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox matricule_equipe;
        private Guna.UI.WinForms.GunaTextBox nom_equipe;
        private Guna.UI.WinForms.GunaTextBox code_equipemnt;
        private Guna.UI.WinForms.GunaGradientButton ajouterequipe;
        private System.ComponentModel.BackgroundWorker working_back;
        private System.Windows.Forms.Panel continer;
        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.DataGridView view_data;
        private Guna.UI.WinForms.GunaGradientButton Entree;
        private System.ComponentModel.BackgroundWorker worker_back_view;
    }
}
