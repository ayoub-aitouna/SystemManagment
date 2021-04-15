namespace ProjectV1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MENU = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forneseur = new Guna.UI.WinForms.GunaGradientButton();
            this.equipment = new Guna.UI.WinForms.GunaGradientButton();
            this.settings = new Guna.UI.WinForms.GunaGradientButton();
            this.users = new Guna.UI.WinForms.GunaGradientButton();
            this.article = new Guna.UI.WinForms.GunaGradientButton();
            this.dashboard_button = new Guna.UI.WinForms.GunaGradientButton();
            this.homa_container = new System.Windows.Forms.Panel();
            this.equipe1 = new ProjectV1.equipe();
            this.fourni1 = new ProjectV1.fourni();
            this.articlee1 = new ProjectV1.articlee();
            this.MENU.SuspendLayout();
            this.LOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.homa_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.White;
            this.MENU.Controls.Add(this.LOGO);
            this.MENU.Controls.Add(this.forneseur);
            this.MENU.Controls.Add(this.equipment);
            this.MENU.Controls.Add(this.settings);
            this.MENU.Controls.Add(this.users);
            this.MENU.Controls.Add(this.article);
            this.MENU.Controls.Add(this.dashboard_button);
            this.MENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(172, 588);
            this.MENU.TabIndex = 0;
            // 
            // LOGO
            // 
            this.LOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOGO.Controls.Add(this.pictureBox1);
            this.LOGO.Location = new System.Drawing.Point(32, 12);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(97, 54);
            this.LOGO.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // forneseur
            // 
            this.forneseur.AnimationHoverSpeed = 0.07F;
            this.forneseur.AnimationSpeed = 0.03F;
            this.forneseur.BackColor = System.Drawing.Color.Transparent;
            this.forneseur.BaseColor1 = System.Drawing.Color.Transparent;
            this.forneseur.BaseColor2 = System.Drawing.Color.Transparent;
            this.forneseur.BorderColor = System.Drawing.Color.Black;
            this.forneseur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forneseur.FocusedColor = System.Drawing.Color.Empty;
            this.forneseur.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forneseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.forneseur.Image = ((System.Drawing.Image)(resources.GetObject("forneseur.Image")));
            this.forneseur.ImageSize = new System.Drawing.Size(20, 20);
            this.forneseur.Location = new System.Drawing.Point(20, 154);
            this.forneseur.Name = "forneseur";
            this.forneseur.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forneseur.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forneseur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.forneseur.OnHoverForeColor = System.Drawing.Color.Black;
            this.forneseur.OnHoverImage = null;
            this.forneseur.OnPressedColor = System.Drawing.Color.Black;
            this.forneseur.Radius = 15;
            this.forneseur.Size = new System.Drawing.Size(140, 40);
            this.forneseur.TabIndex = 4;
            this.forneseur.Text = "Forneseur";
            this.forneseur.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // equipment
            // 
            this.equipment.AnimationHoverSpeed = 0.07F;
            this.equipment.AnimationSpeed = 0.03F;
            this.equipment.BackColor = System.Drawing.Color.Transparent;
            this.equipment.BaseColor1 = System.Drawing.Color.Transparent;
            this.equipment.BaseColor2 = System.Drawing.Color.Transparent;
            this.equipment.BorderColor = System.Drawing.Color.Black;
            this.equipment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.equipment.FocusedColor = System.Drawing.Color.Empty;
            this.equipment.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.equipment.Image = ((System.Drawing.Image)(resources.GetObject("equipment.Image")));
            this.equipment.ImageSize = new System.Drawing.Size(20, 20);
            this.equipment.Location = new System.Drawing.Point(20, 246);
            this.equipment.Name = "equipment";
            this.equipment.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.equipment.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.equipment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.equipment.OnHoverForeColor = System.Drawing.Color.Black;
            this.equipment.OnHoverImage = null;
            this.equipment.OnPressedColor = System.Drawing.Color.Black;
            this.equipment.Radius = 15;
            this.equipment.Size = new System.Drawing.Size(140, 40);
            this.equipment.TabIndex = 4;
            this.equipment.Text = "Equipment";
            this.equipment.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // settings
            // 
            this.settings.AnimationHoverSpeed = 0.07F;
            this.settings.AnimationSpeed = 0.03F;
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BaseColor1 = System.Drawing.Color.Transparent;
            this.settings.BaseColor2 = System.Drawing.Color.Transparent;
            this.settings.BorderColor = System.Drawing.Color.Black;
            this.settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settings.FocusedColor = System.Drawing.Color.Empty;
            this.settings.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageSize = new System.Drawing.Size(20, 20);
            this.settings.Location = new System.Drawing.Point(20, 337);
            this.settings.Name = "settings";
            this.settings.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settings.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.settings.OnHoverForeColor = System.Drawing.Color.Black;
            this.settings.OnHoverImage = null;
            this.settings.OnPressedColor = System.Drawing.Color.Black;
            this.settings.Radius = 15;
            this.settings.Size = new System.Drawing.Size(140, 40);
            this.settings.TabIndex = 4;
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // users
            // 
            this.users.AnimationHoverSpeed = 0.07F;
            this.users.AnimationSpeed = 0.03F;
            this.users.BackColor = System.Drawing.Color.Transparent;
            this.users.BaseColor1 = System.Drawing.Color.Transparent;
            this.users.BaseColor2 = System.Drawing.Color.Transparent;
            this.users.BorderColor = System.Drawing.Color.Black;
            this.users.DialogResult = System.Windows.Forms.DialogResult.None;
            this.users.FocusedColor = System.Drawing.Color.Empty;
            this.users.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.users.Image = ((System.Drawing.Image)(resources.GetObject("users.Image")));
            this.users.ImageSize = new System.Drawing.Size(20, 20);
            this.users.Location = new System.Drawing.Point(20, 292);
            this.users.Name = "users";
            this.users.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.users.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.users.OnHoverBorderColor = System.Drawing.Color.Black;
            this.users.OnHoverForeColor = System.Drawing.Color.Black;
            this.users.OnHoverImage = null;
            this.users.OnPressedColor = System.Drawing.Color.Black;
            this.users.Radius = 15;
            this.users.Size = new System.Drawing.Size(140, 40);
            this.users.TabIndex = 4;
            this.users.Text = "Users";
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // article
            // 
            this.article.AnimationHoverSpeed = 0.07F;
            this.article.AnimationSpeed = 0.03F;
            this.article.BackColor = System.Drawing.Color.Transparent;
            this.article.BaseColor1 = System.Drawing.Color.Transparent;
            this.article.BaseColor2 = System.Drawing.Color.Transparent;
            this.article.BorderColor = System.Drawing.Color.Black;
            this.article.DialogResult = System.Windows.Forms.DialogResult.None;
            this.article.FocusedColor = System.Drawing.Color.Empty;
            this.article.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.article.Image = ((System.Drawing.Image)(resources.GetObject("article.Image")));
            this.article.ImageSize = new System.Drawing.Size(20, 20);
            this.article.Location = new System.Drawing.Point(20, 200);
            this.article.Name = "article";
            this.article.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.article.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.article.OnHoverBorderColor = System.Drawing.Color.Black;
            this.article.OnHoverForeColor = System.Drawing.Color.Black;
            this.article.OnHoverImage = null;
            this.article.OnPressedColor = System.Drawing.Color.Black;
            this.article.Radius = 15;
            this.article.Size = new System.Drawing.Size(140, 40);
            this.article.TabIndex = 4;
            this.article.Text = "Article";
            this.article.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.AnimationHoverSpeed = 0.07F;
            this.dashboard_button.AnimationSpeed = 0.03F;
            this.dashboard_button.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_button.BaseColor1 = System.Drawing.Color.Transparent;
            this.dashboard_button.BaseColor2 = System.Drawing.Color.Transparent;
            this.dashboard_button.BorderColor = System.Drawing.Color.Black;
            this.dashboard_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dashboard_button.FocusedColor = System.Drawing.Color.Empty;
            this.dashboard_button.Font = new System.Drawing.Font("Neometric", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.dashboard_button.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_button.Image")));
            this.dashboard_button.ImageSize = new System.Drawing.Size(20, 20);
            this.dashboard_button.Location = new System.Drawing.Point(20, 107);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dashboard_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dashboard_button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.dashboard_button.OnHoverForeColor = System.Drawing.Color.Black;
            this.dashboard_button.OnHoverImage = null;
            this.dashboard_button.OnPressedColor = System.Drawing.Color.Black;
            this.dashboard_button.Radius = 15;
            this.dashboard_button.Size = new System.Drawing.Size(140, 40);
            this.dashboard_button.TabIndex = 4;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // homa_container
            // 
            this.homa_container.Controls.Add(this.equipe1);
            this.homa_container.Controls.Add(this.fourni1);
            this.homa_container.Controls.Add(this.articlee1);
            this.homa_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homa_container.Location = new System.Drawing.Point(172, 0);
            this.homa_container.Name = "homa_container";
            this.homa_container.Size = new System.Drawing.Size(1060, 588);
            this.homa_container.TabIndex = 1;
            // 
            // equipe1
            // 
            this.equipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipe1.Location = new System.Drawing.Point(0, 0);
            this.equipe1.Name = "equipe1";
            this.equipe1.Size = new System.Drawing.Size(1060, 588);
            this.equipe1.TabIndex = 2;
            // 
            // fourni1
            // 
            this.fourni1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourni1.Location = new System.Drawing.Point(0, 0);
            this.fourni1.Name = "fourni1";
            this.fourni1.Size = new System.Drawing.Size(1060, 588);
            this.fourni1.TabIndex = 1;
            // 
            // articlee1
            // 
            this.articlee1.BackColor = System.Drawing.Color.White;
            this.articlee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlee1.Location = new System.Drawing.Point(0, 0);
            this.articlee1.Name = "articlee1";
            this.articlee1.Size = new System.Drawing.Size(1060, 588);
            this.articlee1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 588);
            this.Controls.Add(this.homa_container);
            this.Controls.Add(this.MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "METLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MENU.ResumeLayout(false);
            this.LOGO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.homa_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MENU;
        private Guna.UI.WinForms.GunaGradientButton equipment;
        private Guna.UI.WinForms.GunaGradientButton dashboard_button;
        private Guna.UI.WinForms.GunaGradientButton forneseur;
        private System.Windows.Forms.Panel LOGO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel homa_container;
        private Guna.UI.WinForms.GunaGradientButton settings;
        private Guna.UI.WinForms.GunaGradientButton users;
        private Guna.UI.WinForms.GunaGradientButton article;
        private articlee articlee1;
        private fourni fourni1;
        private equipe equipe1;
    }
}

