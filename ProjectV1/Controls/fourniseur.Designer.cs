﻿namespace ProjectV1
{
    partial class fourni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fourni));
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.cherche = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.ajoute = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fax = new Guna.UI.WinForms.GunaTextBox();
            this.btn_ajoute = new Guna.UI.WinForms.GunaGradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.email_fourniseur = new Guna.UI.WinForms.GunaTextBox();
            this.numero_fourniseur = new Guna.UI.WinForms.GunaTextBox();
            this.adress_fourniseur = new Guna.UI.WinForms.GunaTextBox();
            this.nom_fourniseur = new Guna.UI.WinForms.GunaTextBox();
            this.code_fourniseur = new Guna.UI.WinForms.GunaTextBox();
            this.back_forniseur__add = new System.ComponentModel.BackgroundWorker();
            this.back_fourniseur_view = new System.ComponentModel.BackgroundWorker();
            this.continer = new System.Windows.Forms.Panel();
            this.panel_view = new System.Windows.Forms.Panel();
            this.view_data = new System.Windows.Forms.DataGridView();
            this.update = new System.ComponentModel.BackgroundWorker();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.ajoute.SuspendLayout();
            this.continer.SuspendLayout();
            this.panel_view.SuspendLayout();
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
            this.progresbar.Location = new System.Drawing.Point(471, 3);
            this.progresbar.Name = "progresbar";
            this.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.progresbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progresbar.ProgressOffset = 20;
            this.progresbar.ProgressThickness = 10;
            this.progresbar.Size = new System.Drawing.Size(60, 60);
            this.progresbar.TabIndex = 17;
            this.progresbar.Value = 20;
            // 
            // cherche
            // 
            this.cherche.AnimationHoverSpeed = 0.07F;
            this.cherche.AnimationSpeed = 0.03F;
            this.cherche.BackColor = System.Drawing.Color.Transparent;
            this.cherche.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.cherche.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.cherche.BorderColor = System.Drawing.Color.Transparent;
            this.cherche.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cherche.FocusedColor = System.Drawing.Color.Empty;
            this.cherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherche.ForeColor = System.Drawing.Color.White;
            this.cherche.Image = ((System.Drawing.Image)(resources.GetObject("cherche.Image")));
            this.cherche.ImageOffsetX = -1;
            this.cherche.ImageSize = new System.Drawing.Size(25, 25);
            this.cherche.Location = new System.Drawing.Point(891, 16);
            this.cherche.Name = "cherche";
            this.cherche.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.cherche.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.cherche.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cherche.OnHoverForeColor = System.Drawing.Color.White;
            this.cherche.OnHoverImage = null;
            this.cherche.OnPressedColor = System.Drawing.Color.Black;
            this.cherche.Radius = 20;
            this.cherche.Size = new System.Drawing.Size(44, 44);
            this.cherche.TabIndex = 19;
            this.cherche.Click += new System.EventHandler(this.gunaGradientButton6_Click);
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
            this.gunaGradientButton4.Location = new System.Drawing.Point(841, 16);
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
            // ajoute
            // 
            this.ajoute.Controls.Add(this.label1);
            this.ajoute.Controls.Add(this.fax);
            this.ajoute.Controls.Add(this.btn_ajoute);
            this.ajoute.Controls.Add(this.label5);
            this.ajoute.Controls.Add(this.label4);
            this.ajoute.Controls.Add(this.label3);
            this.ajoute.Controls.Add(this.nom);
            this.ajoute.Controls.Add(this.code);
            this.ajoute.Controls.Add(this.email_fourniseur);
            this.ajoute.Controls.Add(this.numero_fourniseur);
            this.ajoute.Controls.Add(this.adress_fourniseur);
            this.ajoute.Controls.Add(this.nom_fourniseur);
            this.ajoute.Controls.Add(this.code_fourniseur);
            this.ajoute.Location = new System.Drawing.Point(0, -11);
            this.ajoute.Name = "ajoute";
            this.ajoute.Size = new System.Drawing.Size(995, 535);
            this.ajoute.TabIndex = 32;
            this.ajoute.Paint += new System.Windows.Forms.PaintEventHandler(this.ajoute_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fax";
            // 
            // fax
            // 
            this.fax.BackColor = System.Drawing.Color.Transparent;
            this.fax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fax.BorderColor = System.Drawing.Color.Silver;
            this.fax.BorderSize = 0;
            this.fax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fax.FocusedBaseColor = System.Drawing.Color.White;
            this.fax.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fax.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fax.Location = new System.Drawing.Point(26, 351);
            this.fax.Name = "fax";
            this.fax.PasswordChar = '\0';
            this.fax.Radius = 10;
            this.fax.SelectedText = "";
            this.fax.Size = new System.Drawing.Size(356, 50);
            this.fax.TabIndex = 44;
            this.fax.TextOffsetX = 10;
            // 
            // btn_ajoute
            // 
            this.btn_ajoute.AnimationHoverSpeed = 0.07F;
            this.btn_ajoute.AnimationSpeed = 0.03F;
            this.btn_ajoute.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajoute.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.btn_ajoute.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.btn_ajoute.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ajoute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ajoute.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ajoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoute.ForeColor = System.Drawing.Color.White;
            this.btn_ajoute.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajoute.Image")));
            this.btn_ajoute.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ajoute.Location = new System.Drawing.Point(53, 407);
            this.btn_ajoute.Name = "btn_ajoute";
            this.btn_ajoute.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_ajoute.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_ajoute.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ajoute.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ajoute.OnHoverImage = null;
            this.btn_ajoute.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ajoute.Radius = 5;
            this.btn_ajoute.Size = new System.Drawing.Size(129, 45);
            this.btn_ajoute.TabIndex = 42;
            this.btn_ajoute.Text = "Ajoutter";
            this.btn_ajoute.Click += new System.EventHandler(this.gunaGradientButton1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(50, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = " numero de teliphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Adress";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Location = new System.Drawing.Point(50, 71);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(59, 13);
            this.nom.TabIndex = 35;
            this.nom.Text = "Designition";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.Color.Transparent;
            this.code.Location = new System.Drawing.Point(50, 11);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(32, 13);
            this.code.TabIndex = 36;
            this.code.Text = "Code";
            // 
            // email_fourniseur
            // 
            this.email_fourniseur.BackColor = System.Drawing.Color.Transparent;
            this.email_fourniseur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_fourniseur.BorderColor = System.Drawing.Color.Silver;
            this.email_fourniseur.BorderSize = 0;
            this.email_fourniseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_fourniseur.FocusedBaseColor = System.Drawing.Color.White;
            this.email_fourniseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.email_fourniseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.email_fourniseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_fourniseur.Location = new System.Drawing.Point(26, 288);
            this.email_fourniseur.Name = "email_fourniseur";
            this.email_fourniseur.PasswordChar = '\0';
            this.email_fourniseur.Radius = 10;
            this.email_fourniseur.SelectedText = "";
            this.email_fourniseur.Size = new System.Drawing.Size(356, 50);
            this.email_fourniseur.TabIndex = 37;
            this.email_fourniseur.TextOffsetX = 10;
            // 
            // numero_fourniseur
            // 
            this.numero_fourniseur.BackColor = System.Drawing.Color.Transparent;
            this.numero_fourniseur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numero_fourniseur.BorderColor = System.Drawing.Color.Silver;
            this.numero_fourniseur.BorderSize = 0;
            this.numero_fourniseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero_fourniseur.FocusedBaseColor = System.Drawing.Color.White;
            this.numero_fourniseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numero_fourniseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.numero_fourniseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numero_fourniseur.Location = new System.Drawing.Point(26, 218);
            this.numero_fourniseur.Name = "numero_fourniseur";
            this.numero_fourniseur.PasswordChar = '\0';
            this.numero_fourniseur.Radius = 10;
            this.numero_fourniseur.SelectedText = "";
            this.numero_fourniseur.Size = new System.Drawing.Size(356, 50);
            this.numero_fourniseur.TabIndex = 38;
            this.numero_fourniseur.TextOffsetX = 10;
            // 
            // adress_fourniseur
            // 
            this.adress_fourniseur.BackColor = System.Drawing.Color.Transparent;
            this.adress_fourniseur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adress_fourniseur.BorderColor = System.Drawing.Color.Silver;
            this.adress_fourniseur.BorderSize = 0;
            this.adress_fourniseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress_fourniseur.FocusedBaseColor = System.Drawing.Color.White;
            this.adress_fourniseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adress_fourniseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.adress_fourniseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adress_fourniseur.Location = new System.Drawing.Point(26, 148);
            this.adress_fourniseur.Name = "adress_fourniseur";
            this.adress_fourniseur.PasswordChar = '\0';
            this.adress_fourniseur.Radius = 10;
            this.adress_fourniseur.SelectedText = "";
            this.adress_fourniseur.Size = new System.Drawing.Size(356, 50);
            this.adress_fourniseur.TabIndex = 39;
            this.adress_fourniseur.TextOffsetX = 10;
            // 
            // nom_fourniseur
            // 
            this.nom_fourniseur.BackColor = System.Drawing.Color.Transparent;
            this.nom_fourniseur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom_fourniseur.BorderColor = System.Drawing.Color.Silver;
            this.nom_fourniseur.BorderSize = 0;
            this.nom_fourniseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_fourniseur.FocusedBaseColor = System.Drawing.Color.White;
            this.nom_fourniseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nom_fourniseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nom_fourniseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_fourniseur.Location = new System.Drawing.Point(26, 78);
            this.nom_fourniseur.Name = "nom_fourniseur";
            this.nom_fourniseur.PasswordChar = '\0';
            this.nom_fourniseur.Radius = 10;
            this.nom_fourniseur.SelectedText = "";
            this.nom_fourniseur.Size = new System.Drawing.Size(356, 50);
            this.nom_fourniseur.TabIndex = 40;
            this.nom_fourniseur.TextOffsetX = 10;
            // 
            // code_fourniseur
            // 
            this.code_fourniseur.BackColor = System.Drawing.Color.Transparent;
            this.code_fourniseur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.code_fourniseur.BorderColor = System.Drawing.Color.Silver;
            this.code_fourniseur.BorderSize = 0;
            this.code_fourniseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_fourniseur.FocusedBaseColor = System.Drawing.Color.White;
            this.code_fourniseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.code_fourniseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.code_fourniseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.code_fourniseur.Location = new System.Drawing.Point(26, 18);
            this.code_fourniseur.Name = "code_fourniseur";
            this.code_fourniseur.PasswordChar = '\0';
            this.code_fourniseur.Radius = 10;
            this.code_fourniseur.SelectedText = "";
            this.code_fourniseur.Size = new System.Drawing.Size(356, 50);
            this.code_fourniseur.TabIndex = 41;
            this.code_fourniseur.TextOffsetX = 10;
            // 
            // back_forniseur__add
            // 
            this.back_forniseur__add.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back_forniseur__add_DoWork);
            this.back_forniseur__add.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.back_forniseur__add_RunWorkerCompleted);
            // 
            // back_fourniseur_view
            // 
            this.back_fourniseur_view.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back_fourniseur_view_DoWork);
            this.back_fourniseur_view.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.back_fourniseur_view_RunWorkerCompleted);
            // 
            // continer
            // 
            this.continer.Controls.Add(this.ajoute);
            this.continer.Controls.Add(this.panel_view);
            this.continer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.continer.Location = new System.Drawing.Point(0, 72);
            this.continer.Name = "continer";
            this.continer.Size = new System.Drawing.Size(995, 452);
            this.continer.TabIndex = 33;
            // 
            // panel_view
            // 
            this.panel_view.Controls.Add(this.view_data);
            this.panel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view.Location = new System.Drawing.Point(0, 0);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(995, 452);
            this.panel_view.TabIndex = 33;
            // 
            // view_data
            // 
            this.view_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_data.Location = new System.Drawing.Point(0, 0);
            this.view_data.Name = "view_data";
            this.view_data.Size = new System.Drawing.Size(995, 452);
            this.view_data.TabIndex = 0;
            this.view_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_data_CellValueChanged);
            // 
            // update
            // 
            this.update.DoWork += new System.ComponentModel.DoWorkEventHandler(this.update_DoWork);
            this.update.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.update_RunWorkerCompleted);
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(53, 15);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 5;
            this.gunaGradientButton1.Size = new System.Drawing.Size(129, 45);
            this.gunaGradientButton1.TabIndex = 45;
            this.gunaGradientButton1.Text = "Entrer";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click_2);
            // 
            // fourni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.continer);
            this.Controls.Add(this.cherche);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.progresbar);
            this.Name = "fourni";
            this.Size = new System.Drawing.Size(995, 524);
            this.Load += new System.EventHandler(this.fourni_Load);
            this.ajoute.ResumeLayout(false);
            this.ajoute.PerformLayout();
            this.continer.ResumeLayout(false);
            this.panel_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
        private Guna.UI.WinForms.GunaGradientButton cherche;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private System.Windows.Forms.Panel ajoute;
        private Guna.UI.WinForms.GunaGradientButton btn_ajoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label code;
        private Guna.UI.WinForms.GunaTextBox email_fourniseur;
        private Guna.UI.WinForms.GunaTextBox numero_fourniseur;
        private Guna.UI.WinForms.GunaTextBox adress_fourniseur;
        private Guna.UI.WinForms.GunaTextBox nom_fourniseur;
        private Guna.UI.WinForms.GunaTextBox code_fourniseur;
        private System.ComponentModel.BackgroundWorker back_forniseur__add;
        private System.ComponentModel.BackgroundWorker back_fourniseur_view;
        private System.Windows.Forms.Panel continer;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.DataGridView view_data;
        private System.ComponentModel.BackgroundWorker update;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox fax;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}
