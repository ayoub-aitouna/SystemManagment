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
            this.Entree = new Guna.UI.WinForms.GunaGradientButton();
            this.Sortee = new Guna.UI.WinForms.GunaGradientButton();
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton6 = new Guna.UI.WinForms.GunaGradientButton();
            this.valide = new Guna.UI.WinForms.GunaGradientButton();
            this.add = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matricule_equipe = new Guna.UI.WinForms.GunaTextBox();
            this.nom_equipe = new Guna.UI.WinForms.GunaTextBox();
            this.code_equipemnt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.add.SuspendLayout();
            this.SuspendLayout();
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
            this.Entree.Location = new System.Drawing.Point(35, 15);
            this.Entree.Name = "Entree";
            this.Entree.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Entree.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Entree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Entree.OnHoverForeColor = System.Drawing.Color.White;
            this.Entree.OnHoverImage = null;
            this.Entree.OnPressedColor = System.Drawing.Color.Black;
            this.Entree.Radius = 5;
            this.Entree.Size = new System.Drawing.Size(129, 45);
            this.Entree.TabIndex = 14;
            this.Entree.Text = "Entrée";
            // 
            // Sortee
            // 
            this.Sortee.AnimationHoverSpeed = 0.07F;
            this.Sortee.AnimationSpeed = 0.03F;
            this.Sortee.BackColor = System.Drawing.Color.Transparent;
            this.Sortee.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.Sortee.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.Sortee.BorderColor = System.Drawing.Color.Transparent;
            this.Sortee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sortee.FocusedColor = System.Drawing.Color.Empty;
            this.Sortee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Sortee.ForeColor = System.Drawing.Color.White;
            this.Sortee.Image = ((System.Drawing.Image)(resources.GetObject("Sortee.Image")));
            this.Sortee.ImageSize = new System.Drawing.Size(20, 20);
            this.Sortee.Location = new System.Drawing.Point(197, 14);
            this.Sortee.Name = "Sortee";
            this.Sortee.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Sortee.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Sortee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Sortee.OnHoverForeColor = System.Drawing.Color.White;
            this.Sortee.OnHoverImage = null;
            this.Sortee.OnPressedColor = System.Drawing.Color.Black;
            this.Sortee.Radius = 5;
            this.Sortee.Size = new System.Drawing.Size(129, 45);
            this.Sortee.TabIndex = 15;
            this.Sortee.Text = "Sorte";
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
            // 
            // valide
            // 
            this.valide.AnimationHoverSpeed = 0.07F;
            this.valide.AnimationSpeed = 0.03F;
            this.valide.BackColor = System.Drawing.Color.Transparent;
            this.valide.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.valide.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.valide.BorderColor = System.Drawing.Color.Transparent;
            this.valide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.valide.FocusedColor = System.Drawing.Color.Empty;
            this.valide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valide.ForeColor = System.Drawing.Color.White;
            this.valide.Image = ((System.Drawing.Image)(resources.GetObject("valide.Image")));
            this.valide.ImageOffsetX = -1;
            this.valide.ImageSize = new System.Drawing.Size(25, 25);
            this.valide.Location = new System.Drawing.Point(913, 17);
            this.valide.Name = "valide";
            this.valide.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.valide.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.valide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.valide.OnHoverForeColor = System.Drawing.Color.White;
            this.valide.OnHoverImage = null;
            this.valide.OnPressedColor = System.Drawing.Color.Black;
            this.valide.Radius = 20;
            this.valide.Size = new System.Drawing.Size(44, 44);
            this.valide.TabIndex = 20;
            // 
            // add
            // 
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.matricule_equipe);
            this.add.Controls.Add(this.nom_equipe);
            this.add.Controls.Add(this.code_equipemnt);
            this.add.Controls.Add(this.gunaGradientButton1);
            this.add.Location = new System.Drawing.Point(3, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(992, 458);
            this.add.TabIndex = 21;
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
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(32, 383);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 5;
            this.gunaGradientButton1.Size = new System.Drawing.Size(129, 45);
            this.gunaGradientButton1.TabIndex = 19;
            this.gunaGradientButton1.Text = "Ajoutter";
            // 
            // equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add);
            this.Controls.Add(this.valide);
            this.Controls.Add(this.gunaGradientButton6);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.progresbar);
            this.Controls.Add(this.Sortee);
            this.Controls.Add(this.Entree);
            this.Name = "equipe";
            this.Size = new System.Drawing.Size(995, 524);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton Entree;
        private Guna.UI.WinForms.GunaGradientButton Sortee;
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton6;
        private Guna.UI.WinForms.GunaGradientButton valide;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox matricule_equipe;
        private Guna.UI.WinForms.GunaTextBox nom_equipe;
        private Guna.UI.WinForms.GunaTextBox code_equipemnt;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}
