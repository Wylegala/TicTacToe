namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pole1 = new System.Windows.Forms.Button();
            this.pole2 = new System.Windows.Forms.Button();
            this.pole3 = new System.Windows.Forms.Button();
            this.pole4 = new System.Windows.Forms.Button();
            this.pole5 = new System.Windows.Forms.Button();
            this.pole6 = new System.Windows.Forms.Button();
            this.pole7 = new System.Windows.Forms.Button();
            this.pole8 = new System.Windows.Forms.Button();
            this.pole9 = new System.Windows.Forms.Button();
            this.GlownyTekst = new System.Windows.Forms.Label();
            this.PrzyciskNowaGra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelSumaWygrO = new System.Windows.Forms.Label();
            this.LabelSumaWygrX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pole1
            // 
            this.pole1.BackColor = System.Drawing.SystemColors.Control;
            this.pole1.FlatAppearance.BorderSize = 0;
            this.pole1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole1.Location = new System.Drawing.Point(8, 112);
            this.pole1.Margin = new System.Windows.Forms.Padding(2);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(100, 97);
            this.pole1.TabIndex = 0;
            this.pole1.UseVisualStyleBackColor = false;
            this.pole1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pole2
            // 
            this.pole2.FlatAppearance.BorderSize = 0;
            this.pole2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole2.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole2.Location = new System.Drawing.Point(112, 112);
            this.pole2.Margin = new System.Windows.Forms.Padding(2);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(100, 97);
            this.pole2.TabIndex = 1;
            this.pole2.UseVisualStyleBackColor = true;
            this.pole2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pole3
            // 
            this.pole3.FlatAppearance.BorderSize = 0;
            this.pole3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole3.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole3.Location = new System.Drawing.Point(216, 112);
            this.pole3.Margin = new System.Windows.Forms.Padding(2);
            this.pole3.Name = "pole3";
            this.pole3.Size = new System.Drawing.Size(100, 97);
            this.pole3.TabIndex = 2;
            this.pole3.UseVisualStyleBackColor = true;
            this.pole3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pole4
            // 
            this.pole4.FlatAppearance.BorderSize = 0;
            this.pole4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole4.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole4.Location = new System.Drawing.Point(8, 213);
            this.pole4.Margin = new System.Windows.Forms.Padding(2);
            this.pole4.Name = "pole4";
            this.pole4.Size = new System.Drawing.Size(100, 97);
            this.pole4.TabIndex = 3;
            this.pole4.UseVisualStyleBackColor = true;
            this.pole4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pole5
            // 
            this.pole5.FlatAppearance.BorderSize = 0;
            this.pole5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole5.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole5.Location = new System.Drawing.Point(112, 213);
            this.pole5.Margin = new System.Windows.Forms.Padding(2);
            this.pole5.Name = "pole5";
            this.pole5.Size = new System.Drawing.Size(100, 97);
            this.pole5.TabIndex = 4;
            this.pole5.UseVisualStyleBackColor = true;
            this.pole5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pole6
            // 
            this.pole6.FlatAppearance.BorderSize = 0;
            this.pole6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole6.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole6.Location = new System.Drawing.Point(216, 213);
            this.pole6.Margin = new System.Windows.Forms.Padding(2);
            this.pole6.Name = "pole6";
            this.pole6.Size = new System.Drawing.Size(100, 97);
            this.pole6.TabIndex = 5;
            this.pole6.UseVisualStyleBackColor = true;
            this.pole6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pole7
            // 
            this.pole7.FlatAppearance.BorderSize = 0;
            this.pole7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole7.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole7.Location = new System.Drawing.Point(8, 315);
            this.pole7.Margin = new System.Windows.Forms.Padding(2);
            this.pole7.Name = "pole7";
            this.pole7.Size = new System.Drawing.Size(100, 97);
            this.pole7.TabIndex = 6;
            this.pole7.UseVisualStyleBackColor = true;
            this.pole7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pole8
            // 
            this.pole8.FlatAppearance.BorderSize = 0;
            this.pole8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole8.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole8.Location = new System.Drawing.Point(112, 315);
            this.pole8.Margin = new System.Windows.Forms.Padding(2);
            this.pole8.Name = "pole8";
            this.pole8.Size = new System.Drawing.Size(100, 97);
            this.pole8.TabIndex = 7;
            this.pole8.UseVisualStyleBackColor = true;
            this.pole8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pole9
            // 
            this.pole9.FlatAppearance.BorderSize = 0;
            this.pole9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pole9.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole9.Location = new System.Drawing.Point(216, 315);
            this.pole9.Margin = new System.Windows.Forms.Padding(2);
            this.pole9.Name = "pole9";
            this.pole9.Size = new System.Drawing.Size(100, 97);
            this.pole9.TabIndex = 8;
            this.pole9.UseVisualStyleBackColor = true;
            this.pole9.Click += new System.EventHandler(this.button9_Click);
            // 
            // GlownyTekst
            // 
            this.GlownyTekst.AutoSize = true;
            this.GlownyTekst.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GlownyTekst.Location = new System.Drawing.Point(48, 14);
            this.GlownyTekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GlownyTekst.Name = "GlownyTekst";
            this.GlownyTekst.Size = new System.Drawing.Size(232, 36);
            this.GlownyTekst.TabIndex = 9;
            this.GlownyTekst.Text = "Tura Gracza: O";
            // 
            // PrzyciskNowaGra
            // 
            this.PrzyciskNowaGra.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzyciskNowaGra.Location = new System.Drawing.Point(179, 62);
            this.PrzyciskNowaGra.Margin = new System.Windows.Forms.Padding(2);
            this.PrzyciskNowaGra.Name = "PrzyciskNowaGra";
            this.PrzyciskNowaGra.Size = new System.Drawing.Size(125, 33);
            this.PrzyciskNowaGra.TabIndex = 10;
            this.PrzyciskNowaGra.Text = "Nowa Gra";
            this.PrzyciskNowaGra.UseVisualStyleBackColor = true;
            this.PrzyciskNowaGra.Visible = false;
            this.PrzyciskNowaGra.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(107, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 274);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(209, 125);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 274);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(21, 207);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 6);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.Location = new System.Drawing.Point(21, 311);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(283, 6);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // LabelSumaWygrO
            // 
            this.LabelSumaWygrO.AutoSize = true;
            this.LabelSumaWygrO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSumaWygrO.Location = new System.Drawing.Point(39, 62);
            this.LabelSumaWygrO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSumaWygrO.Name = "LabelSumaWygrO";
            this.LabelSumaWygrO.Size = new System.Drawing.Size(103, 18);
            this.LabelSumaWygrO.TabIndex = 15;
            this.LabelSumaWygrO.Text = "Wygrane O: 0";
            // 
            // LabelSumaWygrX
            // 
            this.LabelSumaWygrX.AutoSize = true;
            this.LabelSumaWygrX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSumaWygrX.Location = new System.Drawing.Point(40, 84);
            this.LabelSumaWygrX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSumaWygrX.Name = "LabelSumaWygrX";
            this.LabelSumaWygrX.Size = new System.Drawing.Size(102, 18);
            this.LabelSumaWygrX.TabIndex = 16;
            this.LabelSumaWygrX.Text = "Wygrane X: 0";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 411);
            this.Controls.Add(this.LabelSumaWygrX);
            this.Controls.Add(this.LabelSumaWygrO);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrzyciskNowaGra);
            this.Controls.Add(this.GlownyTekst);
            this.Controls.Add(this.pole9);
            this.Controls.Add(this.pole8);
            this.Controls.Add(this.pole7);
            this.Controls.Add(this.pole6);
            this.Controls.Add(this.pole5);
            this.Controls.Add(this.pole4);
            this.Controls.Add(this.pole3);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicTacToe";
            this.Text = "Kółko i Krzyżyk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pole1;
        private System.Windows.Forms.Button pole2;
        private System.Windows.Forms.Button pole3;
        private System.Windows.Forms.Button pole4;
        private System.Windows.Forms.Button pole5;
        private System.Windows.Forms.Button pole6;
        private System.Windows.Forms.Button pole7;
        private System.Windows.Forms.Button pole8;
        private System.Windows.Forms.Button pole9;
        private System.Windows.Forms.Label GlownyTekst;
        private System.Windows.Forms.Button PrzyciskNowaGra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LabelSumaWygrO;
        private System.Windows.Forms.Label LabelSumaWygrX;
    }
}

