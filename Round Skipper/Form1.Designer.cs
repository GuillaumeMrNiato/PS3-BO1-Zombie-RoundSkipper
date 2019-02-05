namespace Round_Skipper
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.monoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monoFlat_RadioButton1 = new MonoFlat.MonoFlat_RadioButton();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_RadioButton2 = new MonoFlat.MonoFlat_RadioButton();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.groupBox2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Separator1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.groupBox1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(444, 313);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Black ops 1 - Round Skipper By MrNiato";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monoFlat_Button3);
            this.groupBox2.Controls.Add(this.monoFlat_Button2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(61, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Skipper";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // monoFlat_Button3
            // 
            this.monoFlat_Button3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button3.Image = null;
            this.monoFlat_Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button3.Location = new System.Drawing.Point(45, 59);
            this.monoFlat_Button3.Name = "monoFlat_Button3";
            this.monoFlat_Button3.Size = new System.Drawing.Size(230, 31);
            this.monoFlat_Button3.TabIndex = 1;
            this.monoFlat_Button3.Text = "Stop !";
            this.monoFlat_Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button3.Click += new System.EventHandler(this.monoFlat_Button3_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(45, 22);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Size = new System.Drawing.Size(230, 31);
            this.monoFlat_Button2.TabIndex = 0;
            this.monoFlat_Button2.Text = "Start !";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(332, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 6;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // monoFlat_Separator1
            // 
            this.monoFlat_Separator1.Location = new System.Drawing.Point(61, 185);
            this.monoFlat_Separator1.Name = "monoFlat_Separator1";
            this.monoFlat_Separator1.Size = new System.Drawing.Size(312, 10);
            this.monoFlat_Separator1.TabIndex = 5;
            this.monoFlat_Separator1.Text = "monoFlat_Separator1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monoFlat_RadioButton1);
            this.groupBox1.Controls.Add(this.monoFlat_Button1);
            this.groupBox1.Controls.Add(this.monoFlat_RadioButton2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome !";
            // 
            // monoFlat_RadioButton1
            // 
            this.monoFlat_RadioButton1.Checked = false;
            this.monoFlat_RadioButton1.Location = new System.Drawing.Point(76, 24);
            this.monoFlat_RadioButton1.Name = "monoFlat_RadioButton1";
            this.monoFlat_RadioButton1.Size = new System.Drawing.Size(54, 17);
            this.monoFlat_RadioButton1.TabIndex = 2;
            this.monoFlat_RadioButton1.Text = "DEX";
            this.monoFlat_RadioButton1.CheckedChanged += new MonoFlat.MonoFlat_RadioButton.CheckedChangedEventHandler(this.monoFlat_RadioButton1_CheckedChanged);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(45, 47);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(230, 41);
            this.monoFlat_Button1.TabIndex = 0;
            this.monoFlat_Button1.Text = "Link PS3";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_RadioButton2
            // 
            this.monoFlat_RadioButton2.Checked = false;
            this.monoFlat_RadioButton2.Location = new System.Drawing.Point(178, 24);
            this.monoFlat_RadioButton2.Name = "monoFlat_RadioButton2";
            this.monoFlat_RadioButton2.Size = new System.Drawing.Size(54, 17);
            this.monoFlat_RadioButton2.TabIndex = 3;
            this.monoFlat_RadioButton2.Text = "CEX";
            this.monoFlat_RadioButton2.CheckedChanged += new MonoFlat.MonoFlat_RadioButton.CheckedChangedEventHandler(this.monoFlat_RadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 313);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Black ops 1 - Round Skipper By MrNiato";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MonoFlat.MonoFlat_RadioButton monoFlat_RadioButton2;
        private MonoFlat.MonoFlat_RadioButton monoFlat_RadioButton1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_Separator monoFlat_Separator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MonoFlat.MonoFlat_Button monoFlat_Button2;
        private MonoFlat.MonoFlat_Button monoFlat_Button3;
        private System.Windows.Forms.Timer timer1;
    }
}

