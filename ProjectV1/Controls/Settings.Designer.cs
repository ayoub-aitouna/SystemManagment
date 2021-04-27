namespace ProjectV1.Controls
{
    partial class Settings
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
            this.view_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.upload = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.view = new System.ComponentModel.BackgroundWorker();
            this.add = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_data
            // 
            this.view_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.view_data.Location = new System.Drawing.Point(0, 141);
            this.view_data.Name = "view_data";
            this.view_data.Size = new System.Drawing.Size(1076, 446);
            this.view_data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // barcode
            // 
            this.barcode.BackColor = System.Drawing.Color.Transparent;
            this.barcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barcode.BorderColor = System.Drawing.Color.Silver;
            this.barcode.BorderSize = 0;
            this.barcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcode.FocusedBaseColor = System.Drawing.Color.White;
            this.barcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.barcode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.barcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barcode.Location = new System.Drawing.Point(41, 17);
            this.barcode.Name = "barcode";
            this.barcode.PasswordChar = '\0';
            this.barcode.Radius = 20;
            this.barcode.SelectedText = "";
            this.barcode.Size = new System.Drawing.Size(400, 45);
            this.barcode.TabIndex = 20;
            this.barcode.TextOffsetX = 10;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(564, 17);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 20;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(400, 45);
            this.gunaTextBox1.TabIndex = 2;
            this.gunaTextBox1.TextOffsetX = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "le mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "rôle ";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Administrateur",
            "utilisateur",
            "directeur "});
            this.gunaComboBox1.Location = new System.Drawing.Point(35, 9);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 10;
            this.gunaComboBox1.Size = new System.Drawing.Size(300, 26);
            this.gunaComboBox1.TabIndex = 3;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaComboBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(41, 80);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(400, 45);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // upload
            // 
            this.upload.AnimationHoverSpeed = 0.07F;
            this.upload.AnimationSpeed = 0.03F;
            this.upload.BackColor = System.Drawing.Color.Transparent;
            this.upload.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.upload.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.upload.BorderColor = System.Drawing.Color.Transparent;
            this.upload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.upload.FocusedColor = System.Drawing.Color.Empty;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.White;
            this.upload.Image = global::ProjectV1.Properties.Resources.Vector;
            this.upload.ImageSize = new System.Drawing.Size(20, 20);
            this.upload.Location = new System.Drawing.Point(564, 80);
            this.upload.Name = "upload";
            this.upload.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.upload.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.upload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.upload.OnHoverForeColor = System.Drawing.Color.White;
            this.upload.OnHoverImage = null;
            this.upload.OnPressedColor = System.Drawing.Color.Black;
            this.upload.Radius = 20;
            this.upload.Size = new System.Drawing.Size(160, 45);
            this.upload.TabIndex = 21;
            this.upload.Text = "ajouter ";
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
            this.gunaGradientButton1.Image = global::ProjectV1.Properties.Resources.Close_Square;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(804, 80);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 20;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 45);
            this.gunaGradientButton1.TabIndex = 21;
            this.gunaGradientButton1.Text = "supprimer";
            // 
            // view
            // 
            this.view.DoWork += new System.ComponentModel.DoWorkEventHandler(this.view_DoWork);
            this.view.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.view_RunWorkerCompleted);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.view_data);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1076, 587);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_data;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox barcode;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaGradientButton upload;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.ComponentModel.BackgroundWorker view;
        private System.ComponentModel.BackgroundWorker add;
    }
}
