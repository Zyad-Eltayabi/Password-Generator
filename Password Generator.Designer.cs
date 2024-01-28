namespace Password_Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLevel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLevelName = new System.Windows.Forms.Label();
            this.btnLevel1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLevel2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLevel5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLevel4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLevel3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLevel6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.symbols = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numbers = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lowercase = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uppercase = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.tbLength = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnLevel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Location = new System.Drawing.Point(46, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 84);
            this.panel1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2PictureBox1.Image = global::Password_Generator.Properties.Resources.copy;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(370, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(17, 33);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(166, 23);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password Here";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(19)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(531, 734);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.guna2Panel2.Controls.Add(this.pnLevel);
            this.guna2Panel2.Controls.Add(this.btnGenerate);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.tbLength);
            this.guna2Panel2.Controls.Add(this.lbLength);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(47, 142);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(435, 554);
            this.guna2Panel2.TabIndex = 3;
            // 
            // pnLevel
            // 
            this.pnLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(19)))));
            this.pnLevel.Controls.Add(this.lbLevelName);
            this.pnLevel.Controls.Add(this.btnLevel1);
            this.pnLevel.Controls.Add(this.btnLevel2);
            this.pnLevel.Controls.Add(this.btnLevel5);
            this.pnLevel.Controls.Add(this.btnLevel4);
            this.pnLevel.Controls.Add(this.btnLevel3);
            this.pnLevel.Controls.Add(this.btnLevel6);
            this.pnLevel.Controls.Add(this.lbLevel);
            this.pnLevel.Location = new System.Drawing.Point(23, 396);
            this.pnLevel.Name = "pnLevel";
            this.pnLevel.Size = new System.Drawing.Size(386, 58);
            this.pnLevel.TabIndex = 4;
            // 
            // lbLevelName
            // 
            this.lbLevelName.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelName.Location = new System.Drawing.Point(144, 18);
            this.lbLevelName.Name = "lbLevelName";
            this.lbLevelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbLevelName.Size = new System.Drawing.Size(132, 24);
            this.lbLevelName.TabIndex = 12;
            this.lbLevelName.Text = "Easy";
            // 
            // btnLevel1
            // 
            this.btnLevel1.Animated = true;
            this.btnLevel1.BorderColor = System.Drawing.Color.White;
            this.btnLevel1.BorderThickness = 1;
            this.btnLevel1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel1.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel1.ForeColor = System.Drawing.Color.White;
            this.btnLevel1.Location = new System.Drawing.Point(282, 22);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel1.Size = new System.Drawing.Size(10, 13);
            this.btnLevel1.TabIndex = 11;
            this.btnLevel1.Text = "guna2CircleButton6";
            // 
            // btnLevel2
            // 
            this.btnLevel2.BorderColor = System.Drawing.Color.White;
            this.btnLevel2.BorderThickness = 1;
            this.btnLevel2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel2.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel2.ForeColor = System.Drawing.Color.White;
            this.btnLevel2.Location = new System.Drawing.Point(298, 22);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel2.Size = new System.Drawing.Size(10, 13);
            this.btnLevel2.TabIndex = 10;
            this.btnLevel2.Text = "guna2CircleButton5";
            // 
            // btnLevel5
            // 
            this.btnLevel5.Animated = true;
            this.btnLevel5.BorderColor = System.Drawing.Color.White;
            this.btnLevel5.BorderThickness = 1;
            this.btnLevel5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel5.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel5.ForeColor = System.Drawing.Color.White;
            this.btnLevel5.Location = new System.Drawing.Point(346, 22);
            this.btnLevel5.Name = "btnLevel5";
            this.btnLevel5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel5.Size = new System.Drawing.Size(10, 13);
            this.btnLevel5.TabIndex = 9;
            this.btnLevel5.Text = "guna2CircleButton4";
            // 
            // btnLevel4
            // 
            this.btnLevel4.BorderColor = System.Drawing.Color.White;
            this.btnLevel4.BorderThickness = 1;
            this.btnLevel4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel4.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel4.ForeColor = System.Drawing.Color.White;
            this.btnLevel4.Location = new System.Drawing.Point(330, 22);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel4.Size = new System.Drawing.Size(10, 13);
            this.btnLevel4.TabIndex = 8;
            this.btnLevel4.Text = "guna2CircleButton3";
            // 
            // btnLevel3
            // 
            this.btnLevel3.BorderColor = System.Drawing.Color.White;
            this.btnLevel3.BorderThickness = 1;
            this.btnLevel3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel3.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel3.ForeColor = System.Drawing.Color.White;
            this.btnLevel3.Location = new System.Drawing.Point(314, 22);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel3.Size = new System.Drawing.Size(10, 13);
            this.btnLevel3.TabIndex = 7;
            this.btnLevel3.Text = "guna2CircleButton2";
            // 
            // btnLevel6
            // 
            this.btnLevel6.BorderColor = System.Drawing.Color.White;
            this.btnLevel6.BorderThickness = 1;
            this.btnLevel6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLevel6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLevel6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLevel6.FillColor = System.Drawing.Color.Transparent;
            this.btnLevel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLevel6.ForeColor = System.Drawing.Color.White;
            this.btnLevel6.Location = new System.Drawing.Point(362, 22);
            this.btnLevel6.Name = "btnLevel6";
            this.btnLevel6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLevel6.Size = new System.Drawing.Size(10, 13);
            this.btnLevel6.TabIndex = 4;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(26, 22);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(80, 16);
            this.lbLevel.TabIndex = 6;
            this.lbLevel.Text = "STRENGTH";
            // 
            // btnGenerate
            // 
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnGenerate.Font = new System.Drawing.Font("Articulate", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGenerate.Location = new System.Drawing.Point(23, 475);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(386, 56);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.symbols);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.numbers);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.lowercase);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.uppercase);
            this.guna2Panel3.Location = new System.Drawing.Point(21, 167);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(388, 210);
            this.guna2Panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Include Symbols Letters";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // symbols
            // 
            this.symbols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.symbols.CheckedState.BorderRadius = 2;
            this.symbols.CheckedState.BorderThickness = 0;
            this.symbols.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(249)))), ((int)(((byte)(186)))));
            this.symbols.Location = new System.Drawing.Point(31, 154);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(20, 20);
            this.symbols.TabIndex = 14;
            this.symbols.Text = "guna2CustomCheckBox1";
            this.symbols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.symbols.UncheckedState.BorderRadius = 2;
            this.symbols.UncheckedState.BorderThickness = 0;
            this.symbols.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Include Numbers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numbers
            // 
            this.numbers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numbers.CheckedState.BorderRadius = 2;
            this.numbers.CheckedState.BorderThickness = 0;
            this.numbers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(249)))), ((int)(((byte)(186)))));
            this.numbers.Location = new System.Drawing.Point(31, 113);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(20, 20);
            this.numbers.TabIndex = 12;
            this.numbers.Text = "guna2CustomCheckBox1";
            this.numbers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numbers.UncheckedState.BorderRadius = 2;
            this.numbers.UncheckedState.BorderThickness = 0;
            this.numbers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Include Lowercase Letters";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lowercase
            // 
            this.lowercase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lowercase.CheckedState.BorderRadius = 2;
            this.lowercase.CheckedState.BorderThickness = 0;
            this.lowercase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(249)))), ((int)(((byte)(186)))));
            this.lowercase.Location = new System.Drawing.Point(31, 72);
            this.lowercase.Name = "lowercase";
            this.lowercase.Size = new System.Drawing.Size(20, 20);
            this.lowercase.TabIndex = 10;
            this.lowercase.Text = "guna2CustomCheckBox1";
            this.lowercase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lowercase.UncheckedState.BorderRadius = 2;
            this.lowercase.UncheckedState.BorderThickness = 0;
            this.lowercase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Include Uppercase Letters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uppercase
            // 
            this.uppercase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uppercase.CheckedState.BorderRadius = 2;
            this.uppercase.CheckedState.BorderThickness = 0;
            this.uppercase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(249)))), ((int)(((byte)(186)))));
            this.uppercase.Location = new System.Drawing.Point(31, 31);
            this.uppercase.Name = "uppercase";
            this.uppercase.Size = new System.Drawing.Size(20, 20);
            this.uppercase.TabIndex = 8;
            this.uppercase.Text = "guna2CustomCheckBox1";
            this.uppercase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.uppercase.UncheckedState.BorderRadius = 2;
            this.uppercase.UncheckedState.BorderThickness = 0;
            this.uppercase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // tbLength
            // 
            this.tbLength.LargeChange = 1;
            this.tbLength.Location = new System.Drawing.Point(37, 117);
            this.tbLength.Maximum = 24;
            this.tbLength.Minimum = 1;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(372, 23);
            this.tbLength.TabIndex = 4;
            this.tbLength.ThumbColor = System.Drawing.Color.Yellow;
            this.tbLength.Value = 1;
            this.tbLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLength.Location = new System.Drawing.Point(382, 42);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(27, 28);
            this.lbLength.TabIndex = 2;
            this.lbLength.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character Length";
            // 
            // guna2TaskBarProgress1
            // 
            this.guna2TaskBarProgress1.TargetForm = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 734);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.pnLevel.ResumeLayout(false);
            this.pnLevel.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbPassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar tbLength;
        private System.Windows.Forms.Label lbLength;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox uppercase;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CustomCheckBox symbols;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox numbers;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox lowercase;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2Panel pnLevel;
        private System.Windows.Forms.Label lbLevel;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel5;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel4;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnLevel6;
        private System.Windows.Forms.Label lbLevelName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

