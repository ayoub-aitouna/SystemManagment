namespace ProjectV1
{
    partial class articlee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(articlee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.quantitier = new Guna.UI.WinForms.GunaTextBox();
            this.desination = new Guna.UI.WinForms.GunaTextBox();
            this.reference_intrene = new Guna.UI.WinForms.GunaTextBox();
            this.reference_fabricant = new Guna.UI.WinForms.GunaTextBox();
            this.prix = new Guna.UI.WinForms.GunaTextBox();
            this.code_ean = new Guna.UI.WinForms.GunaTextBox();
            this.barcode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upload = new Guna.UI.WinForms.GunaGradientButton();
            this.add_button = new Guna.UI.WinForms.GunaGradientButton();
            this.progresbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Sortee = new Guna.UI.WinForms.GunaGradientButton();
            this.Entree = new Guna.UI.WinForms.GunaGradientButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.View = new System.Windows.Forms.Panel();
            this.view_data = new System.Windows.Forms.DataGridView();
            this.Container = new System.Windows.Forms.Panel();
            this.viewData_worker = new System.ComponentModel.BackgroundWorker();
            this.add_data_worker = new System.ComponentModel.BackgroundWorker();
            this.gunaGradientButton6 = new Guna.UI.WinForms.GunaGradientButton();
            this.valide = new Guna.UI.WinForms.GunaGradientButton();
            this.entree_print_Document = new System.Drawing.Printing.PrintDocument();
            this.entree_print_Dialog = new System.Windows.Forms.PrintDialog();
            this.used_items_button = new Guna.UI.WinForms.GunaGradientButton();
            this.update_data = new System.ComponentModel.BackgroundWorker();
            this.Add.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).BeginInit();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Controls.Add(this.label8);
            this.Add.Controls.Add(this.label7);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.label5);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.label4);
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.label2);
            this.Add.Controls.Add(this.date);
            this.Add.Controls.Add(this.quantitier);
            this.Add.Controls.Add(this.desination);
            this.Add.Controls.Add(this.reference_intrene);
            this.Add.Controls.Add(this.reference_fabricant);
            this.Add.Controls.Add(this.prix);
            this.Add.Controls.Add(this.code_ean);
            this.Add.Controls.Add(this.barcode);
            this.Add.Controls.Add(this.gunaElipsePanel1);
            this.Add.Controls.Add(this.upload);
            this.Add.Controls.Add(this.add_button);
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(0, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(995, 441);
            this.Add.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date entree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantitier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "desination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reference Interne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reference Fabricant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Code ean";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BaseColor = System.Drawing.Color.White;
            this.date.BorderColor = System.Drawing.Color.Silver;
            this.date.CustomFormat = null;
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(559, 174);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.OnHoverBaseColor = System.Drawing.Color.White;
            this.date.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.OnPressedColor = System.Drawing.Color.Black;
            this.date.Radius = 19;
            this.date.Size = new System.Drawing.Size(155, 40);
            this.date.TabIndex = 19;
            this.date.Text = "11/04/2021";
            this.date.Value = new System.DateTime(2021, 4, 11, 22, 17, 2, 539);
            // 
            // quantitier
            // 
            this.quantitier.BackColor = System.Drawing.Color.Transparent;
            this.quantitier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantitier.BorderColor = System.Drawing.Color.Silver;
            this.quantitier.BorderSize = 0;
            this.quantitier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantitier.FocusedBaseColor = System.Drawing.Color.White;
            this.quantitier.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.quantitier.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.quantitier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantitier.Location = new System.Drawing.Point(559, 104);
            this.quantitier.Name = "quantitier";
            this.quantitier.PasswordChar = '\0';
            this.quantitier.Radius = 20;
            this.quantitier.SelectedText = "";
            this.quantitier.Size = new System.Drawing.Size(356, 50);
            this.quantitier.TabIndex = 18;
            this.quantitier.TextOffsetX = 10;
            // 
            // desination
            // 
            this.desination.BackColor = System.Drawing.Color.Transparent;
            this.desination.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.desination.BorderColor = System.Drawing.Color.Silver;
            this.desination.BorderSize = 0;
            this.desination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desination.FocusedBaseColor = System.Drawing.Color.White;
            this.desination.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.desination.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.desination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.desination.Location = new System.Drawing.Point(559, 34);
            this.desination.Name = "desination";
            this.desination.PasswordChar = '\0';
            this.desination.Radius = 20;
            this.desination.SelectedText = "";
            this.desination.Size = new System.Drawing.Size(356, 50);
            this.desination.TabIndex = 18;
            this.desination.TextOffsetX = 10;
            // 
            // reference_intrene
            // 
            this.reference_intrene.BackColor = System.Drawing.Color.Transparent;
            this.reference_intrene.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reference_intrene.BorderColor = System.Drawing.Color.Silver;
            this.reference_intrene.BorderSize = 0;
            this.reference_intrene.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reference_intrene.FocusedBaseColor = System.Drawing.Color.White;
            this.reference_intrene.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reference_intrene.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.reference_intrene.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reference_intrene.Location = new System.Drawing.Point(79, 314);
            this.reference_intrene.Name = "reference_intrene";
            this.reference_intrene.PasswordChar = '\0';
            this.reference_intrene.Radius = 20;
            this.reference_intrene.SelectedText = "";
            this.reference_intrene.Size = new System.Drawing.Size(356, 50);
            this.reference_intrene.TabIndex = 18;
            this.reference_intrene.TextOffsetX = 10;
            // 
            // reference_fabricant
            // 
            this.reference_fabricant.BackColor = System.Drawing.Color.Transparent;
            this.reference_fabricant.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reference_fabricant.BorderColor = System.Drawing.Color.Silver;
            this.reference_fabricant.BorderSize = 0;
            this.reference_fabricant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reference_fabricant.FocusedBaseColor = System.Drawing.Color.White;
            this.reference_fabricant.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reference_fabricant.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.reference_fabricant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reference_fabricant.Location = new System.Drawing.Point(79, 244);
            this.reference_fabricant.Name = "reference_fabricant";
            this.reference_fabricant.PasswordChar = '\0';
            this.reference_fabricant.Radius = 20;
            this.reference_fabricant.SelectedText = "";
            this.reference_fabricant.Size = new System.Drawing.Size(356, 50);
            this.reference_fabricant.TabIndex = 18;
            this.reference_fabricant.TextOffsetX = 10;
            // 
            // prix
            // 
            this.prix.BackColor = System.Drawing.Color.Transparent;
            this.prix.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prix.BorderColor = System.Drawing.Color.Silver;
            this.prix.BorderSize = 0;
            this.prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix.FocusedBaseColor = System.Drawing.Color.White;
            this.prix.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix.Location = new System.Drawing.Point(79, 174);
            this.prix.Name = "prix";
            this.prix.PasswordChar = '\0';
            this.prix.Radius = 20;
            this.prix.SelectedText = "";
            this.prix.Size = new System.Drawing.Size(356, 50);
            this.prix.TabIndex = 18;
            this.prix.TextOffsetX = 10;
            // 
            // code_ean
            // 
            this.code_ean.BackColor = System.Drawing.Color.Transparent;
            this.code_ean.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.code_ean.BorderColor = System.Drawing.Color.Silver;
            this.code_ean.BorderSize = 0;
            this.code_ean.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_ean.FocusedBaseColor = System.Drawing.Color.White;
            this.code_ean.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.code_ean.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.code_ean.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.code_ean.Location = new System.Drawing.Point(79, 104);
            this.code_ean.Name = "code_ean";
            this.code_ean.PasswordChar = '\0';
            this.code_ean.Radius = 20;
            this.code_ean.SelectedText = "";
            this.code_ean.Size = new System.Drawing.Size(356, 50);
            this.code_ean.TabIndex = 18;
            this.code_ean.TextOffsetX = 10;
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
            this.barcode.Location = new System.Drawing.Point(79, 34);
            this.barcode.Name = "barcode";
            this.barcode.PasswordChar = '\0';
            this.barcode.Radius = 20;
            this.barcode.SelectedText = "";
            this.barcode.Size = new System.Drawing.Size(356, 50);
            this.barcode.TabIndex = 18;
            this.barcode.TextOffsetX = 10;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(559, 244);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(356, 174);
            this.gunaElipsePanel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.ImageSize = new System.Drawing.Size(20, 20);
            this.upload.Location = new System.Drawing.Point(765, 169);
            this.upload.Name = "upload";
            this.upload.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.upload.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.upload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.upload.OnHoverForeColor = System.Drawing.Color.White;
            this.upload.OnHoverImage = null;
            this.upload.OnPressedColor = System.Drawing.Color.Black;
            this.upload.Radius = 20;
            this.upload.Size = new System.Drawing.Size(150, 45);
            this.upload.TabIndex = 9;
            this.upload.Text = "Upload";
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // add_button
            // 
            this.add_button.AnimationHoverSpeed = 0.07F;
            this.add_button.AnimationSpeed = 0.03F;
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.add_button.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.add_button.BorderColor = System.Drawing.Color.Transparent;
            this.add_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_button.FocusedColor = System.Drawing.Color.Empty;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.ImageSize = new System.Drawing.Size(20, 20);
            this.add_button.Location = new System.Drawing.Point(79, 379);
            this.add_button.Name = "add_button";
            this.add_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.add_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.add_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_button.OnHoverForeColor = System.Drawing.Color.White;
            this.add_button.OnHoverImage = null;
            this.add_button.OnPressedColor = System.Drawing.Color.Black;
            this.add_button.Radius = 5;
            this.add_button.Size = new System.Drawing.Size(129, 45);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Ajoutter";
            this.add_button.Click += new System.EventHandler(this.gunaGradientButton1_Click);
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
            this.progresbar.Location = new System.Drawing.Point(531, 21);
            this.progresbar.Name = "progresbar";
            this.progresbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.progresbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progresbar.ProgressOffset = 20;
            this.progresbar.ProgressThickness = 10;
            this.progresbar.Size = new System.Drawing.Size(60, 60);
            this.progresbar.TabIndex = 16;
            this.progresbar.Value = 20;
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
            this.gunaGradientButton4.Location = new System.Drawing.Point(801, 36);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Radius = 20;
            this.gunaGradientButton4.Size = new System.Drawing.Size(44, 44);
            this.gunaGradientButton4.TabIndex = 12;
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.pictureBox1;
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
            this.Sortee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortee.ForeColor = System.Drawing.Color.White;
            this.Sortee.Image = ((System.Drawing.Image)(resources.GetObject("Sortee.Image")));
            this.Sortee.ImageSize = new System.Drawing.Size(20, 20);
            this.Sortee.Location = new System.Drawing.Point(173, 36);
            this.Sortee.Name = "Sortee";
            this.Sortee.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Sortee.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Sortee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Sortee.OnHoverForeColor = System.Drawing.Color.White;
            this.Sortee.OnHoverImage = null;
            this.Sortee.OnPressedColor = System.Drawing.Color.Black;
            this.Sortee.Radius = 5;
            this.Sortee.Size = new System.Drawing.Size(129, 45);
            this.Sortee.TabIndex = 13;
            this.Sortee.Text = "Sorte";
            this.Sortee.Click += new System.EventHandler(this.sortee);
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
            this.Entree.Location = new System.Drawing.Point(27, 36);
            this.Entree.Name = "Entree";
            this.Entree.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Entree.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Entree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Entree.OnHoverForeColor = System.Drawing.Color.White;
            this.Entree.OnHoverImage = null;
            this.Entree.OnPressedColor = System.Drawing.Color.Black;
            this.Entree.Radius = 5;
            this.Entree.Size = new System.Drawing.Size(129, 45);
            this.Entree.TabIndex = 13;
            this.Entree.Text = "Entrée";
            this.Entree.Click += new System.EventHandler(this.Entree_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 4;
            this.guna2Elipse2.TargetControl = this.add_button;
            // 
            // View
            // 
            this.View.Controls.Add(this.view_data);
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.Location = new System.Drawing.Point(0, 0);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(995, 441);
            this.View.TabIndex = 14;
            // 
            // view_data
            // 
            this.view_data.AllowUserToAddRows = false;
            this.view_data.AllowUserToDeleteRows = false;
            this.view_data.AllowUserToResizeColumns = false;
            this.view_data.AllowUserToResizeRows = false;
            this.view_data.BackgroundColor = System.Drawing.Color.White;
            this.view_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.view_data.ColumnHeadersHeight = 25;
            this.view_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.view_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_data.GridColor = System.Drawing.Color.Black;
            this.view_data.Location = new System.Drawing.Point(0, 0);
            this.view_data.Name = "view_data";
            this.view_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_data.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.view_data.Size = new System.Drawing.Size(995, 441);
            this.view_data.TabIndex = 0;
            this.view_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_data_CellValueChanged);
            this.view_data.SelectionChanged += new System.EventHandler(this.view_data_SelectionChanged);
            // 
            // Container
            // 
            this.Container.Controls.Add(this.Add);
            this.Container.Controls.Add(this.View);
            this.Container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Container.Location = new System.Drawing.Point(0, 83);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(995, 441);
            this.Container.TabIndex = 14;
            // 
            // viewData_worker
            // 
            this.viewData_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.view_worker_DoWork);
            this.viewData_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.viewData_worker_ProgressChanged);
            this.viewData_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.view_worker_RunWorkerCompleted);
            // 
            // add_data_worker
            // 
            this.add_data_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.add_data_worker_DoWork);
            this.add_data_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.add_data_worker_RunWorkerCompleted);
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
            this.gunaGradientButton6.Location = new System.Drawing.Point(862, 36);
            this.gunaGradientButton6.Name = "gunaGradientButton6";
            this.gunaGradientButton6.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton6.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton6.OnHoverImage = null;
            this.gunaGradientButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.Radius = 20;
            this.gunaGradientButton6.Size = new System.Drawing.Size(44, 44);
            this.gunaGradientButton6.TabIndex = 13;
            this.gunaGradientButton6.Click += new System.EventHandler(this.gunaGradientButton6_Click);
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
            this.valide.Location = new System.Drawing.Point(934, 36);
            this.valide.Name = "valide";
            this.valide.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.valide.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.valide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.valide.OnHoverForeColor = System.Drawing.Color.White;
            this.valide.OnHoverImage = null;
            this.valide.OnPressedColor = System.Drawing.Color.Black;
            this.valide.Radius = 20;
            this.valide.Size = new System.Drawing.Size(44, 44);
            this.valide.TabIndex = 17;
            this.valide.Click += new System.EventHandler(this.valide_Click);
            // 
            // entree_print_Document
            // 
            this.entree_print_Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.entree_print_Document_PrintPage);
            // 
            // entree_print_Dialog
            // 
            this.entree_print_Dialog.Document = this.entree_print_Document;
            this.entree_print_Dialog.UseEXDialog = true;
            // 
            // used_items_button
            // 
            this.used_items_button.AnimationHoverSpeed = 0.07F;
            this.used_items_button.AnimationSpeed = 0.03F;
            this.used_items_button.BackColor = System.Drawing.Color.Transparent;
            this.used_items_button.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.used_items_button.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(132)))));
            this.used_items_button.BorderColor = System.Drawing.Color.Transparent;
            this.used_items_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.used_items_button.FocusedColor = System.Drawing.Color.Empty;
            this.used_items_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.used_items_button.ForeColor = System.Drawing.Color.White;
            this.used_items_button.Image = ((System.Drawing.Image)(resources.GetObject("used_items_button.Image")));
            this.used_items_button.ImageSize = new System.Drawing.Size(20, 20);
            this.used_items_button.Location = new System.Drawing.Point(328, 36);
            this.used_items_button.Name = "used_items_button";
            this.used_items_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.used_items_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.used_items_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.used_items_button.OnHoverForeColor = System.Drawing.Color.White;
            this.used_items_button.OnHoverImage = null;
            this.used_items_button.OnPressedColor = System.Drawing.Color.Black;
            this.used_items_button.Radius = 5;
            this.used_items_button.Size = new System.Drawing.Size(143, 45);
            this.used_items_button.TabIndex = 13;
            this.used_items_button.Text = "articles usagés ";
            this.used_items_button.Click += new System.EventHandler(this.used_items);
            // 
            // update_data
            // 
            this.update_data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.update_data_DoWork);
            this.update_data.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.update_data_RunWorkerCompleted);
            // 
            // articlee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progresbar);
            this.Controls.Add(this.valide);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.gunaGradientButton6);
            this.Controls.Add(this.Entree);
            this.Controls.Add(this.used_items_button);
            this.Controls.Add(this.Sortee);
            this.Controls.Add(this.gunaGradientButton4);
            this.Name = "articlee";
            this.Size = new System.Drawing.Size(995, 524);
            this.Load += new System.EventHandler(this.articlee_Load);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).EndInit();
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientButton upload;
        private Guna.UI.WinForms.GunaGradientButton add_button;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaGradientButton Sortee;
        private Guna.UI.WinForms.GunaGradientButton Entree;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel View;
        private System.Windows.Forms.DataGridView view_data;
        private System.Windows.Forms.Panel Container;
        private Guna.UI.WinForms.GunaCircleProgressBar progresbar;
        private System.ComponentModel.BackgroundWorker viewData_worker;
        private System.ComponentModel.BackgroundWorker add_data_worker;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton6;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaTextBox quantitier;
        private Guna.UI.WinForms.GunaTextBox desination;
        private Guna.UI.WinForms.GunaTextBox reference_intrene;
        private Guna.UI.WinForms.GunaTextBox reference_fabricant;
        private Guna.UI.WinForms.GunaTextBox prix;
        private Guna.UI.WinForms.GunaTextBox code_ean;
        private Guna.UI.WinForms.GunaTextBox barcode;
        private Guna.UI.WinForms.GunaDateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton valide;
        private System.Drawing.Printing.PrintDocument entree_print_Document;
        private System.Windows.Forms.PrintDialog entree_print_Dialog;
        private Guna.UI.WinForms.GunaGradientButton used_items_button;
        private System.ComponentModel.BackgroundWorker update_data;
    }
}
