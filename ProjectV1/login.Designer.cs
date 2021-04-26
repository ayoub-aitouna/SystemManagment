namespace ProjectV1.Units
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajoute = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.pasword = new Guna.UI.WinForms.GunaTextBox();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backlogin = new System.ComponentModel.BackgroundWorker();
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.progresbar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_ajoute);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nom);
            this.panel2.Controls.Add(this.pasword);
            this.panel2.Controls.Add(this.username);
            this.panel2.Location = new System.Drawing.Point(500, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 496);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(224, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
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
            this.btn_ajoute.Location = new System.Drawing.Point(181, 344);
            this.btn_ajoute.Name = "btn_ajoute";
            this.btn_ajoute.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_ajoute.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_ajoute.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ajoute.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ajoute.OnHoverImage = null;
            this.btn_ajoute.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ajoute.Radius = 5;
            this.btn_ajoute.Size = new System.Drawing.Size(173, 45);
            this.btn_ajoute.TabIndex = 45;
            this.btn_ajoute.Text = "Connecter";
            this.btn_ajoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ajoute.UseWaitCursor = true;
            this.btn_ajoute.Click += new System.EventHandler(this.btn_ajoute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(118, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mots de passe";
            this.label3.UseWaitCursor = true;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.nom.Location = new System.Drawing.Point(118, 191);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(81, 16);
            this.nom.TabIndex = 42;
            this.nom.Text = "Usser name";
            this.nom.UseWaitCursor = true;
            // 
            // pasword
            // 
            this.pasword.BackColor = System.Drawing.Color.Transparent;
            this.pasword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pasword.BorderColor = System.Drawing.Color.Silver;
            this.pasword.BorderSize = 0;
            this.pasword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pasword.FocusedBaseColor = System.Drawing.Color.White;
            this.pasword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pasword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pasword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pasword.Location = new System.Drawing.Point(94, 268);
            this.pasword.Name = "pasword";
            this.pasword.PasswordChar = '\0';
            this.pasword.Radius = 10;
            this.pasword.SelectedText = "";
            this.pasword.Size = new System.Drawing.Size(356, 50);
            this.pasword.TabIndex = 43;
            this.pasword.TextOffsetX = 10;
            this.pasword.UseWaitCursor = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.BorderColor = System.Drawing.Color.Silver;
            this.username.BorderSize = 0;
            this.username.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.Location = new System.Drawing.Point(94, 198);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 10;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(356, 50);
            this.username.TabIndex = 44;
            this.username.TextOffsetX = 10;
            this.username.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 561);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // backlogin
            // 
            this.backlogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backlogin_DoWork);
            this.backlogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backlogin_RunWorkerCompleted);
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
            this.progresbar.Location = new System.Drawing.Point(230, 26);
            this.progresbar.Name = "progresbar";
            this.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.progresbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progresbar.ProgressOffset = 20;
            this.progresbar.ProgressThickness = 10;
            this.progresbar.Size = new System.Drawing.Size(60, 60);
            this.progresbar.TabIndex = 50;
            this.progresbar.Value = 20;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1232, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MTLE";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nom;
        private Guna.UI.WinForms.GunaTextBox pasword;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaGradientButton btn_ajoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backlogin;
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
    }
}