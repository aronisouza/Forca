namespace Forca
{
    partial class Forca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forca));
            this.flpJogo = new System.Windows.Forms.FlowLayoutPanel();
            this.btJogar = new System.Windows.Forms.Label();
            this.gbCerto = new System.Windows.Forms.GroupBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbfalaPerdeu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbJa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDigite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnInfor = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPerdeu = new System.Windows.Forms.Panel();
            this.lblPerder = new System.Windows.Forms.Label();
            this.lbPalavra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pcbPerder = new System.Windows.Forms.PictureBox();
            this.gbCerto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnInfor.SuspendLayout();
            this.pnPerdeu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerder)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJogo
            // 
            this.flpJogo.BackColor = System.Drawing.Color.White;
            this.flpJogo.Location = new System.Drawing.Point(50, 473);
            this.flpJogo.Name = "flpJogo";
            this.flpJogo.Size = new System.Drawing.Size(867, 59);
            this.flpJogo.TabIndex = 7;
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btJogar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btJogar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogar.ForeColor = System.Drawing.Color.SpringGreen;
            this.btJogar.Location = new System.Drawing.Point(574, -1);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(78, 47);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "Iniciar";
            this.btJogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // gbCerto
            // 
            this.gbCerto.BackColor = System.Drawing.Color.White;
            this.gbCerto.Controls.Add(this.lbTest);
            this.gbCerto.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCerto.ForeColor = System.Drawing.Color.Black;
            this.gbCerto.Location = new System.Drawing.Point(309, 130);
            this.gbCerto.Name = "gbCerto";
            this.gbCerto.Size = new System.Drawing.Size(609, 61);
            this.gbCerto.TabIndex = 11;
            this.gbCerto.TabStop = false;
            this.gbCerto.Text = " Letras certas ";
            // 
            // lbTest
            // 
            this.lbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTest.AutoSize = true;
            this.lbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTest.Location = new System.Drawing.Point(16, 21);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(22, 29);
            this.lbTest.TabIndex = 10;
            this.lbTest.Text = "-";
            // 
            // lbfalaPerdeu
            // 
            this.lbfalaPerdeu.AutoSize = true;
            this.lbfalaPerdeu.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfalaPerdeu.Location = new System.Drawing.Point(193, 119);
            this.lbfalaPerdeu.Name = "lbfalaPerdeu";
            this.lbfalaPerdeu.Size = new System.Drawing.Size(153, 33);
            this.lbfalaPerdeu.TabIndex = 16;
            this.lbfalaPerdeu.Text = "A palavra era:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbJa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(309, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Letras erradas ";
            // 
            // lbJa
            // 
            this.lbJa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJa.AutoSize = true;
            this.lbJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbJa.Location = new System.Drawing.Point(16, 20);
            this.lbJa.Name = "lbJa";
            this.lbJa.Size = new System.Drawing.Size(22, 29);
            this.lbJa.TabIndex = 10;
            this.lbJa.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Para jogar novamente é só inicar um novo jogo!!!";
            // 
            // txtDigite
            // 
            this.txtDigite.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtDigite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDigite.Enabled = false;
            this.txtDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigite.ForeColor = System.Drawing.Color.Lime;
            this.txtDigite.Location = new System.Drawing.Point(657, 8);
            this.txtDigite.Name = "txtDigite";
            this.txtDigite.PasswordChar = '+';
            this.txtDigite.Size = new System.Drawing.Size(169, 30);
            this.txtDigite.TabIndex = 4;
            this.txtDigite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigite.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(651, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digitar uma palavra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informações!";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(534, 227);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // pnInfor
            // 
            this.pnInfor.BackColor = System.Drawing.Color.White;
            this.pnInfor.Controls.Add(this.label4);
            this.pnInfor.Controls.Add(this.label7);
            this.pnInfor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.pnInfor.Location = new System.Drawing.Point(24, 10);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(561, 261);
            this.pnInfor.TabIndex = 18;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.Red;
            this.btFechar.Location = new System.Drawing.Point(877, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Padding = new System.Windows.Forms.Padding(5);
            this.btFechar.Size = new System.Drawing.Size(46, 46);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "X";
            this.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(832, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.label2.Size = new System.Drawing.Size(46, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(575, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo da Forca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveJ);
            // 
            // pnPerdeu
            // 
            this.pnPerdeu.Controls.Add(this.pnInfor);
            this.pnPerdeu.Controls.Add(this.label6);
            this.pnPerdeu.Controls.Add(this.lbfalaPerdeu);
            this.pnPerdeu.Controls.Add(this.lblPerder);
            this.pnPerdeu.Controls.Add(this.pcbPerder);
            this.pnPerdeu.Location = new System.Drawing.Point(299, 197);
            this.pnPerdeu.Name = "pnPerdeu";
            this.pnPerdeu.Size = new System.Drawing.Size(618, 272);
            this.pnPerdeu.TabIndex = 15;
            this.pnPerdeu.Visible = false;
            // 
            // lblPerder
            // 
            this.lblPerder.AutoSize = true;
            this.lblPerder.Font = new System.Drawing.Font("Segoe Print", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerder.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPerder.Location = new System.Drawing.Point(213, 16);
            this.lblPerder.Name = "lblPerder";
            this.lblPerder.Size = new System.Drawing.Size(370, 82);
            this.lblPerder.TabIndex = 15;
            this.lblPerder.Text = "Você perdeu!!!";
            // 
            // lbPalavra
            // 
            this.lbPalavra.Enabled = false;
            this.lbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalavra.Location = new System.Drawing.Point(237, 15);
            this.lbPalavra.Name = "lbPalavra";
            this.lbPalavra.Size = new System.Drawing.Size(244, 20);
            this.lbPalavra.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flpJogo);
            this.panel1.Controls.Add(this.txtDigite);
            this.panel1.Controls.Add(this.btJogar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gbCerto);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPalavra);
            this.panel1.Controls.Add(this.pnPerdeu);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 540);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Forca.Properties.Resources.panico;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.Image = global::Forca.Properties.Resources.Inicio;
            this.pbImg.Location = new System.Drawing.Point(6, 51);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(297, 481);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 2;
            this.pbImg.TabStop = false;
            // 
            // pcbPerder
            // 
            this.pcbPerder.Location = new System.Drawing.Point(3, 3);
            this.pcbPerder.Name = "pcbPerder";
            this.pcbPerder.Size = new System.Drawing.Size(187, 270);
            this.pcbPerder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPerder.TabIndex = 14;
            this.pcbPerder.TabStop = false;
            // 
            // Forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(925, 542);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.gbCerto.ResumeLayout(false);
            this.gbCerto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            this.pnPerdeu.ResumeLayout(false);
            this.pnPerdeu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPerder;
        private System.Windows.Forms.FlowLayoutPanel flpJogo;
        private System.Windows.Forms.Label btJogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCerto;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbfalaPerdeu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbJa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDigite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnInfor;
        private System.Windows.Forms.Label btFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPerdeu;
        private System.Windows.Forms.Label lblPerder;
        private System.Windows.Forms.TextBox lbPalavra;
        private System.Windows.Forms.Panel panel1;
    }
}

