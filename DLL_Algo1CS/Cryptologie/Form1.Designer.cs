namespace Cryptologie
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
            this.TB_Crypte = new System.Windows.Forms.TextBox();
            this.TB_Normal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Crypter = new System.Windows.Forms.Button();
            this.BTN_Decrypter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_Addition = new System.Windows.Forms.RadioButton();
            this.RB_Circulaire = new System.Windows.Forms.RadioButton();
            this.RB_Rotation = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_SaveNormal = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_SaveCrypte = new System.Windows.Forms.Button();
            this.OFD_Load = new System.Windows.Forms.OpenFileDialog();
            this.SFD_Save = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Crypte
            // 
            this.TB_Crypte.Location = new System.Drawing.Point(12, 357);
            this.TB_Crypte.Multiline = true;
            this.TB_Crypte.Name = "TB_Crypte";
            this.TB_Crypte.Size = new System.Drawing.Size(399, 140);
            this.TB_Crypte.TabIndex = 0;
            this.TB_Crypte.TextChanged += new System.EventHandler(this.TB_Crypte_TextChanged);
            // 
            // TB_Normal
            // 
            this.TB_Normal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Normal.Location = new System.Drawing.Point(12, 145);
            this.TB_Normal.Multiline = true;
            this.TB_Normal.Name = "TB_Normal";
            this.TB_Normal.Size = new System.Drawing.Size(399, 140);
            this.TB_Normal.TabIndex = 0;
            this.TB_Normal.TextChanged += new System.EventHandler(this.TB_Normal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texte normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 12F);
            this.label2.Location = new System.Drawing.Point(163, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texte crypté";
            // 
            // BTN_Crypter
            // 
            this.BTN_Crypter.Location = new System.Drawing.Point(282, 293);
            this.BTN_Crypter.Name = "BTN_Crypter";
            this.BTN_Crypter.Size = new System.Drawing.Size(129, 28);
            this.BTN_Crypter.TabIndex = 3;
            this.BTN_Crypter.Text = "Crypter";
            this.BTN_Crypter.UseVisualStyleBackColor = true;
            this.BTN_Crypter.Click += new System.EventHandler(this.BTN_Crypter_Click);
            // 
            // BTN_Decrypter
            // 
            this.BTN_Decrypter.Location = new System.Drawing.Point(282, 503);
            this.BTN_Decrypter.Name = "BTN_Decrypter";
            this.BTN_Decrypter.Size = new System.Drawing.Size(129, 28);
            this.BTN_Decrypter.TabIndex = 4;
            this.BTN_Decrypter.Text = "Décrypter";
            this.BTN_Decrypter.UseVisualStyleBackColor = true;
            this.BTN_Decrypter.Click += new System.EventHandler(this.BTN_Decrypter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RB_Addition);
            this.groupBox1.Controls.Add(this.RB_Circulaire);
            this.groupBox1.Controls.Add(this.RB_Rotation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithmes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cryptologie.Properties.Resources.Interrogation;
            this.pictureBox1.Location = new System.Drawing.Point(258, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 10F);
            this.label3.Location = new System.Drawing.Point(49, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clé de cryptage :";
            // 
            // RB_Addition
            // 
            this.RB_Addition.AutoSize = true;
            this.RB_Addition.Location = new System.Drawing.Point(272, 26);
            this.RB_Addition.Name = "RB_Addition";
            this.RB_Addition.Size = new System.Drawing.Size(73, 21);
            this.RB_Addition.TabIndex = 2;
            this.RB_Addition.Text = "Atbash";
            this.RB_Addition.UseVisualStyleBackColor = true;
            // 
            // RB_Circulaire
            // 
            this.RB_Circulaire.AutoSize = true;
            this.RB_Circulaire.Location = new System.Drawing.Point(158, 26);
            this.RB_Circulaire.Name = "RB_Circulaire";
            this.RB_Circulaire.Size = new System.Drawing.Size(88, 21);
            this.RB_Circulaire.TabIndex = 1;
            this.RB_Circulaire.Text = "Circulaire";
            this.RB_Circulaire.UseVisualStyleBackColor = true;
            // 
            // RB_Rotation
            // 
            this.RB_Rotation.AutoSize = true;
            this.RB_Rotation.Checked = true;
            this.RB_Rotation.Location = new System.Drawing.Point(50, 26);
            this.RB_Rotation.Name = "RB_Rotation";
            this.RB_Rotation.Size = new System.Drawing.Size(82, 21);
            this.RB_Rotation.TabIndex = 0;
            this.RB_Rotation.TabStop = true;
            this.RB_Rotation.Text = "Rotation";
            this.RB_Rotation.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Charger...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_LoadNormal_Click);
            // 
            // BTN_SaveNormal
            // 
            this.BTN_SaveNormal.Enabled = false;
            this.BTN_SaveNormal.Location = new System.Drawing.Point(147, 291);
            this.BTN_SaveNormal.Name = "BTN_SaveNormal";
            this.BTN_SaveNormal.Size = new System.Drawing.Size(129, 28);
            this.BTN_SaveNormal.TabIndex = 7;
            this.BTN_SaveNormal.Text = "Sauvegarder...";
            this.BTN_SaveNormal.UseVisualStyleBackColor = true;
            this.BTN_SaveNormal.Click += new System.EventHandler(this.BTN_SaveNormal_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Charger...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BTN_LoadCrypte_Click);
            // 
            // BTN_SaveCrypte
            // 
            this.BTN_SaveCrypte.Enabled = false;
            this.BTN_SaveCrypte.Location = new System.Drawing.Point(147, 503);
            this.BTN_SaveCrypte.Name = "BTN_SaveCrypte";
            this.BTN_SaveCrypte.Size = new System.Drawing.Size(129, 28);
            this.BTN_SaveCrypte.TabIndex = 9;
            this.BTN_SaveCrypte.Text = "Sauvegarder...";
            this.BTN_SaveCrypte.UseVisualStyleBackColor = true;
            this.BTN_SaveCrypte.Click += new System.EventHandler(this.BTN_SaveCrypte_Click);
            // 
            // OFD_Load
            // 
            this.OFD_Load.FileName = "openFileDialog1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(158, 60);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(94, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(423, 539);
            this.Controls.Add(this.BTN_SaveCrypte);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_SaveNormal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Decrypter);
            this.Controls.Add(this.BTN_Crypter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Normal);
            this.Controls.Add(this.TB_Crypte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Cryptologie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Crypte;
        private System.Windows.Forms.TextBox TB_Normal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Crypter;
        private System.Windows.Forms.Button BTN_Decrypter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Addition;
        private System.Windows.Forms.RadioButton RB_Circulaire;
        private System.Windows.Forms.RadioButton RB_Rotation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_SaveNormal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_SaveCrypte;
        private System.Windows.Forms.OpenFileDialog OFD_Load;
        private System.Windows.Forms.SaveFileDialog SFD_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

