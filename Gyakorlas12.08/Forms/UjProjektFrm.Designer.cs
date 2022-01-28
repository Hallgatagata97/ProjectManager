
namespace ProjektManager
{
    partial class UjProjektFrm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Button();
            this.rendelesadatokPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.megnevezesTbx = new System.Windows.Forms.TextBox();
            this.projektDgv = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.visszaBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.cegIdTbx = new System.Windows.Forms.TextBox();
            this.hataridoDTP = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.hazszamTbx = new System.Windows.Forms.TextBox();
            this.AdoszamTbx = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.orszagTbx = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.telefonszamTbx = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.iranyitoszamTbx = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.telepulesTbx = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.kozteruletTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cegnevCbx = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mennyisegNud = new System.Windows.Forms.NumericUpDown();
            this.szolgaltatasCbx = new System.Windows.Forms.ComboBox();
            this.szolgaltatasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagerDBDataSet2 = new ProjektManager.ProjectManagerDBDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.arTbx = new System.Windows.Forms.TextBox();
            this.ujProjektekBtn = new System.Windows.Forms.Button();
            this.szolgaltatasokTableAdapter = new ProjektManager.ProjectManagerDBDataSet2TableAdapters.szolgaltatasokTableAdapter();
            this.panel2.SuspendLayout();
            this.rendelesadatokPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szolgaltatasokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.xBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 91);
            this.panel2.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.label26.Location = new System.Drawing.Point(645, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 35);
            this.label26.TabIndex = 3;
            this.label26.Text = "Projektek";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBtn
            // 
            this.xBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xBtn.FlatAppearance.BorderSize = 0;
            this.xBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.xBtn.Location = new System.Drawing.Point(1450, 0);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(50, 50);
            this.xBtn.TabIndex = 2;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = true;
            // 
            // rendelesadatokPnl
            // 
            this.rendelesadatokPnl.Controls.Add(this.button1);
            this.rendelesadatokPnl.Controls.Add(this.label27);
            this.rendelesadatokPnl.Controls.Add(this.megnevezesTbx);
            this.rendelesadatokPnl.Controls.Add(this.projektDgv);
            this.rendelesadatokPnl.Controls.Add(this.label25);
            this.rendelesadatokPnl.Controls.Add(this.label14);
            this.rendelesadatokPnl.Controls.Add(this.label15);
            this.rendelesadatokPnl.Controls.Add(this.visszaBtn);
            this.rendelesadatokPnl.Controls.Add(this.label16);
            this.rendelesadatokPnl.Controls.Add(this.mentesBtn);
            this.rendelesadatokPnl.Controls.Add(this.cegIdTbx);
            this.rendelesadatokPnl.Controls.Add(this.hataridoDTP);
            this.rendelesadatokPnl.Controls.Add(this.label17);
            this.rendelesadatokPnl.Controls.Add(this.hazszamTbx);
            this.rendelesadatokPnl.Controls.Add(this.AdoszamTbx);
            this.rendelesadatokPnl.Controls.Add(this.label18);
            this.rendelesadatokPnl.Controls.Add(this.orszagTbx);
            this.rendelesadatokPnl.Controls.Add(this.label19);
            this.rendelesadatokPnl.Controls.Add(this.telefonszamTbx);
            this.rendelesadatokPnl.Controls.Add(this.label20);
            this.rendelesadatokPnl.Controls.Add(this.iranyitoszamTbx);
            this.rendelesadatokPnl.Controls.Add(this.label21);
            this.rendelesadatokPnl.Controls.Add(this.telepulesTbx);
            this.rendelesadatokPnl.Controls.Add(this.label22);
            this.rendelesadatokPnl.Controls.Add(this.kozteruletTbx);
            this.rendelesadatokPnl.Controls.Add(this.emailTbx);
            this.rendelesadatokPnl.Controls.Add(this.label23);
            this.rendelesadatokPnl.Controls.Add(this.cegnevCbx);
            this.rendelesadatokPnl.Controls.Add(this.label24);
            this.rendelesadatokPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.rendelesadatokPnl.Location = new System.Drawing.Point(0, 91);
            this.rendelesadatokPnl.Name = "rendelesadatokPnl";
            this.rendelesadatokPnl.Size = new System.Drawing.Size(1500, 666);
            this.rendelesadatokPnl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1121, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 95;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(229, 249);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 18);
            this.label27.TabIndex = 94;
            this.label27.Text = "Projekt Megnevezés";
            // 
            // megnevezesTbx
            // 
            this.megnevezesTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megnevezesTbx.Location = new System.Drawing.Point(232, 275);
            this.megnevezesTbx.Name = "megnevezesTbx";
            this.megnevezesTbx.Size = new System.Drawing.Size(391, 26);
            this.megnevezesTbx.TabIndex = 93;
            // 
            // projektDgv
            // 
            this.projektDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projektDgv.Location = new System.Drawing.Point(12, 342);
            this.projektDgv.Name = "projektDgv";
            this.projektDgv.RowHeadersWidth = 51;
            this.projektDgv.RowTemplate.Height = 24;
            this.projektDgv.Size = new System.Drawing.Size(1476, 324);
            this.projektDgv.TabIndex = 92;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(20, 318);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 21);
            this.label25.TabIndex = 91;
            this.label25.Text = "Szolgáltatások";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(1092, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 89;
            this.label14.Text = "Házszám";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(15, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 18);
            this.label15.TabIndex = 81;
            this.label15.Text = "Leadási határidő";
            // 
            // visszaBtn
            // 
            this.visszaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.visszaBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.visszaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visszaBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visszaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.visszaBtn.Location = new System.Drawing.Point(1152, 840);
            this.visszaBtn.Name = "visszaBtn";
            this.visszaBtn.Size = new System.Drawing.Size(109, 45);
            this.visszaBtn.TabIndex = 78;
            this.visszaBtn.Text = "Vissza";
            this.visszaBtn.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(229, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 88;
            this.label16.Text = "Email cím";
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.mentesBtn.FlatAppearance.BorderSize = 0;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.mentesBtn.Location = new System.Drawing.Point(1267, 840);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(109, 45);
            this.mentesBtn.TabIndex = 77;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // cegIdTbx
            // 
            this.cegIdTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegIdTbx.Location = new System.Drawing.Point(20, 46);
            this.cegIdTbx.Name = "cegIdTbx";
            this.cegIdTbx.Size = new System.Drawing.Size(179, 26);
            this.cegIdTbx.TabIndex = 66;
            // 
            // hataridoDTP
            // 
            this.hataridoDTP.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hataridoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hataridoDTP.Location = new System.Drawing.Point(20, 275);
            this.hataridoDTP.Name = "hataridoDTP";
            this.hataridoDTP.Size = new System.Drawing.Size(179, 26);
            this.hataridoDTP.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(21, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 18);
            this.label17.TabIndex = 87;
            this.label17.Text = "Telefonszám";
            // 
            // hazszamTbx
            // 
            this.hazszamTbx.Enabled = false;
            this.hazszamTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hazszamTbx.Location = new System.Drawing.Point(1095, 118);
            this.hazszamTbx.Name = "hazszamTbx";
            this.hazszamTbx.Size = new System.Drawing.Size(179, 26);
            this.hazszamTbx.TabIndex = 73;
            // 
            // AdoszamTbx
            // 
            this.AdoszamTbx.Enabled = false;
            this.AdoszamTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdoszamTbx.Location = new System.Drawing.Point(20, 120);
            this.AdoszamTbx.Name = "AdoszamTbx";
            this.AdoszamTbx.Size = new System.Drawing.Size(1395, 26);
            this.AdoszamTbx.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(876, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 18);
            this.label18.TabIndex = 86;
            this.label18.Text = "Közterület";
            // 
            // orszagTbx
            // 
            this.orszagTbx.Enabled = false;
            this.orszagTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orszagTbx.Location = new System.Drawing.Point(232, 120);
            this.orszagTbx.Name = "orszagTbx";
            this.orszagTbx.Size = new System.Drawing.Size(179, 26);
            this.orszagTbx.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(659, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 18);
            this.label19.TabIndex = 85;
            this.label19.Text = "Település";
            // 
            // telefonszamTbx
            // 
            this.telefonszamTbx.Enabled = false;
            this.telefonszamTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonszamTbx.Location = new System.Drawing.Point(20, 201);
            this.telefonszamTbx.Name = "telefonszamTbx";
            this.telefonszamTbx.Size = new System.Drawing.Size(179, 26);
            this.telefonszamTbx.TabIndex = 69;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(445, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 18);
            this.label20.TabIndex = 84;
            this.label20.Text = "Irányítószám";
            // 
            // iranyitoszamTbx
            // 
            this.iranyitoszamTbx.Enabled = false;
            this.iranyitoszamTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iranyitoszamTbx.Location = new System.Drawing.Point(448, 120);
            this.iranyitoszamTbx.Name = "iranyitoszamTbx";
            this.iranyitoszamTbx.Size = new System.Drawing.Size(179, 26);
            this.iranyitoszamTbx.TabIndex = 70;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(229, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 18);
            this.label21.TabIndex = 83;
            this.label21.Text = "Ország";
            // 
            // telepulesTbx
            // 
            this.telepulesTbx.Enabled = false;
            this.telepulesTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telepulesTbx.Location = new System.Drawing.Point(662, 120);
            this.telepulesTbx.Name = "telepulesTbx";
            this.telepulesTbx.Size = new System.Drawing.Size(179, 26);
            this.telepulesTbx.TabIndex = 71;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(21, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 18);
            this.label22.TabIndex = 82;
            this.label22.Text = "Adószám";
            // 
            // kozteruletTbx
            // 
            this.kozteruletTbx.Enabled = false;
            this.kozteruletTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kozteruletTbx.Location = new System.Drawing.Point(879, 120);
            this.kozteruletTbx.Name = "kozteruletTbx";
            this.kozteruletTbx.Size = new System.Drawing.Size(179, 26);
            this.kozteruletTbx.TabIndex = 72;
            // 
            // emailTbx
            // 
            this.emailTbx.Enabled = false;
            this.emailTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTbx.Location = new System.Drawing.Point(232, 201);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(179, 26);
            this.emailTbx.TabIndex = 74;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(229, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 18);
            this.label23.TabIndex = 80;
            this.label23.Text = "Cégnév";
            // 
            // cegnevCbx
            // 
            this.cegnevCbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cegnevCbx.FormattingEnabled = true;
            this.cegnevCbx.Location = new System.Drawing.Point(232, 44);
            this.cegnevCbx.Name = "cegnevCbx";
            this.cegnevCbx.Size = new System.Drawing.Size(826, 26);
            this.cegnevCbx.TabIndex = 75;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(21, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 18);
            this.label24.TabIndex = 79;
            this.label24.Text = "CégID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 784);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "Szolgáltatás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(545, 780);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mennyiség";
            // 
            // mennyisegNud
            // 
            this.mennyisegNud.Location = new System.Drawing.Point(548, 803);
            this.mennyisegNud.Name = "mennyisegNud";
            this.mennyisegNud.Size = new System.Drawing.Size(120, 22);
            this.mennyisegNud.TabIndex = 83;
            // 
            // szolgaltatasCbx
            // 
            this.szolgaltatasCbx.DataSource = this.szolgaltatasokBindingSource;
            this.szolgaltatasCbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szolgaltatasCbx.FormattingEnabled = true;
            this.szolgaltatasCbx.Location = new System.Drawing.Point(24, 801);
            this.szolgaltatasCbx.Name = "szolgaltatasCbx";
            this.szolgaltatasCbx.Size = new System.Drawing.Size(337, 26);
            this.szolgaltatasCbx.TabIndex = 95;
            // 
            // szolgaltatasokBindingSource
            // 
            this.szolgaltatasokBindingSource.DataMember = "szolgaltatasok";
            this.szolgaltatasokBindingSource.DataSource = this.projectManagerDBDataSet2;
            // 
            // projectManagerDBDataSet2
            // 
            this.projectManagerDBDataSet2.DataSetName = "ProjectManagerDBDataSet2";
            this.projectManagerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(418, 780);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Ár";
            // 
            // arTbx
            // 
            this.arTbx.Enabled = false;
            this.arTbx.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arTbx.Location = new System.Drawing.Point(421, 801);
            this.arTbx.Name = "arTbx";
            this.arTbx.Size = new System.Drawing.Size(99, 26);
            this.arTbx.TabIndex = 97;
            // 
            // ujProjektekBtn
            // 
            this.ujProjektekBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ujProjektekBtn.FlatAppearance.BorderSize = 0;
            this.ujProjektekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujProjektekBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujProjektekBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.ujProjektekBtn.Location = new System.Drawing.Point(1379, 784);
            this.ujProjektekBtn.Name = "ujProjektekBtn";
            this.ujProjektekBtn.Size = new System.Drawing.Size(109, 45);
            this.ujProjektekBtn.TabIndex = 98;
            this.ujProjektekBtn.Text = "Hozzáadás";
            this.ujProjektekBtn.UseVisualStyleBackColor = false;
            // 
            // szolgaltatasokTableAdapter
            // 
            this.szolgaltatasokTableAdapter.ClearBeforeFill = true;
            // 
            // UjProjektFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.ujProjektekBtn);
            this.Controls.Add(this.arTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.szolgaltatasCbx);
            this.Controls.Add(this.mennyisegNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rendelesadatokPnl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UjProjektFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UjProjektFrm";
            this.Load += new System.EventHandler(this.UjProjektFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rendelesadatokPnl.ResumeLayout(false);
            this.rendelesadatokPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szolgaltatasokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Panel rendelesadatokPnl;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox megnevezesTbx;
        private System.Windows.Forms.DataGridView projektDgv;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button visszaBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.TextBox cegIdTbx;
        private System.Windows.Forms.DateTimePicker hataridoDTP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox hazszamTbx;
        private System.Windows.Forms.TextBox AdoszamTbx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox orszagTbx;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox telefonszamTbx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox iranyitoszamTbx;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox telepulesTbx;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox kozteruletTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cegnevCbx;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mennyisegNud;
        private System.Windows.Forms.ComboBox szolgaltatasCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arTbx;
        private System.Windows.Forms.Button ujProjektekBtn;
        private ProjectManagerDBDataSet2 projectManagerDBDataSet2;
        private System.Windows.Forms.BindingSource szolgaltatasokBindingSource;
        private ProjectManagerDBDataSet2TableAdapters.szolgaltatasokTableAdapter szolgaltatasokTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}