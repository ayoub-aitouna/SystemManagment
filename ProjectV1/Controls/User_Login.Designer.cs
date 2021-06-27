namespace ProjectV1.Controls
{
    partial class User_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.remamber = new System.Windows.Forms.CheckBox();
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajoute = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.pasword = new Guna.UI.WinForms.GunaTextBox();
            this.backlogin = new System.ComponentModel.BackgroundWorker();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // remamber
            // 
            this.remamber.AutoSize = true;
            this.remamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remamber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.remamber.Location = new System.Drawing.Point(823, 366);
            this.remamber.Name = "remamber";
            this.remamber.Size = new System.Drawing.Size(113, 19);
            this.remamber.TabIndex = 52;
            this.remamber.Text = "Remamber me ";
            this.remamber.UseVisualStyleBackColor = true;
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
            this.progresbar.Location = new System.Drawing.Point(934, 116);
            this.progresbar.Name = "progresbar";
            this.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.progresbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progresbar.ProgressOffset = 20;
            this.progresbar.ProgressThickness = 10;
            this.progresbar.Size = new System.Drawing.Size(60, 60);
            this.progresbar.TabIndex = 1;
            this.progresbar.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(918, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_ajoute.Image = null;
            this.btn_ajoute.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ajoute.Location = new System.Drawing.Point(895, 392);
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
            this.btn_ajoute.Click += new System.EventHandler(this.btn_ajoute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(820, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mots de passe";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.nom.Location = new System.Drawing.Point(820, 229);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(81, 16);
            this.nom.TabIndex = 42;
            this.nom.Text = "Usser name";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.BorderColor = System.Drawing.Color.Silver;
            this.username.BorderSize = 0;
            this.username.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.Location = new System.Drawing.Point(796, 239);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 10;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(356, 50);
            this.username.TabIndex = 2;
            this.username.Text = "user";
            this.username.TextOffsetX = 10;
            // 
            // pasword
            // 
            this.pasword.BackColor = System.Drawing.Color.Transparent;
            this.pasword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pasword.BorderColor = System.Drawing.Color.Silver;
            this.pasword.BorderSize = 0;
            this.pasword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pasword.FocusedBaseColor = System.Drawing.Color.White;
            this.pasword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pasword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pasword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pasword.Location = new System.Drawing.Point(796, 308);
            this.pasword.Name = "pasword";
            this.pasword.PasswordChar = '\0';
            this.pasword.Radius = 10;
            this.pasword.SelectedText = "";
            this.pasword.Size = new System.Drawing.Size(356, 50);
            this.pasword.TabIndex = 3;
            this.pasword.Text = "pass";
            this.pasword.TextOffsetX = 10;
            this.pasword.Enter += new System.EventHandler(this.pasword_Enter);
            // 
            // backlogin
            // 
            this.backlogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backlogin_DoWork);
            this.backlogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backlogin_RunWorkerCompleted);
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(790, 627);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox1.TabIndex = 53;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.remamber);
            this.Controls.Add(this.btn_ajoute);
            this.Controls.Add(this.progresbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Name = "User_Login";
            this.Size = new System.Drawing.Size(1248, 627);
            this.Load += new System.EventHandler(this.User_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox remamber;
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btn_ajoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nom;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaTextBox pasword;
        private System.ComponentModel.BackgroundWorker backlogin;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
    }
}
