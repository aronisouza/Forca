using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Forca : Form
    {
        public Forca()
        {
            InitializeComponent();
        }

        #region Move janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MoveJ(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        bool jogar;
        PictureBox[] pcb;
        string palavra;
        byte erro = 1;
        int pass = 0;
        //:: 1 para digitar palavra 2 para computador escolher
        byte modo = 2; 
        
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Sobre nj = new Sobre();
            nj.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!jogar)
            {
                txtDigite.Visible = true;
                txtDigite.Enabled = true;
                txtDigite.Focus();
            }
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            pnPerdeu.Visible = false;
            if (!pnInfor.Visible)
            {
                pnInfor.Visible = true;
            }

            pbImg.Image = Properties.Resources.Inicio;
            flpJogo.Controls.Clear();

            if (!string.IsNullOrEmpty(txtDigite.Text))
            {
                txtDigite.Enabled = false;
                txtDigite.Visible = false;
                modo = 1;
            }
            else txtDigite.Visible = false;

            if (modo == 1)
            {
                txtDigite.CharacterCasing = CharacterCasing.Lower;
                palavra = txtDigite.Text.ToLower();
                pcb = new PictureBox[txtDigite.Text.Length];
                for (int cont = 0; cont < txtDigite.Text.Length; cont++)
                {
                    pcb[cont] = new PictureBox();
                    pcb[cont].Width = 50;
                    pcb[cont].Height = 50;

                    pcb[cont].Paint += new PaintEventHandler(frmForca_Paint);

                    flpJogo.Controls.Add(pcb[cont]);
                }
            }
            // -- Para palavras escolhidas pelo computador --
            else
            {
                // -- Lista onde o computador escolhe a palavra --
                // -- Escolhe uma palavras no arry list da classe palavras

                Palavras pal = new Palavras();
                do
                {
                    if (pal.StrPal().Length <= 15)
                    {
                        lbPalavra.Text = Convert.ToString(pal.StrPal());
                        break;
                    }
                } while (true);

                lbPalavra.CharacterCasing = CharacterCasing.Lower;
                // -- Fim computador escolhe --

                palavra = lbPalavra.Text.ToLower();
                pcb = new PictureBox[lbPalavra.Text.Length];
                for (int cont = 0; cont < lbPalavra.Text.Length; cont++)
                {
                    pcb[cont] = new PictureBox();
                    pcb[cont].Width = 50;
                    pcb[cont].Height = 50;
                    pcb[cont].Paint += new PaintEventHandler(frmForca_Paint);
                    flpJogo.Controls.Add(pcb[cont]);
                }
            }
            btJogar.Enabled = false;
            txtDigite.Enabled = false;
            jogar = true;
        }

        private void frmForca_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Sienna, 2), 0, 45, 45, 45);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!jogar) return false;
            if (modo == 1)
            {
                if (lbJa.Text.ToLower().Contains(keyData.ToString().ToLower()))
                {
                    if (this.lbJa.ForeColor == SystemColors.WindowText) this.lbJa.ForeColor = Color.Red;
                    else this.lbJa.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    if (txtDigite.Text.ToLower().Contains(keyData.ToString().ToLower()))
                    {
                        if (!lbTest.Text.ToLower().Contains(keyData.ToString().ToLower()))
                        {
                            lbTest.Text = lbTest.Text + " " + keyData.ToString() + " -";
                        }
                        else
                        {
                            if (this.lbTest.ForeColor == SystemColors.WindowText) this.lbTest.ForeColor = Color.ForestGreen;
                            else this.lbTest.ForeColor = SystemColors.WindowText;
                        }
                        acertou(keyData.ToString());
                    }
                    else
                    {
                        lbJa.Text = lbJa.Text + " " + keyData.ToString() + " -";
                        errou();
                    }
                }
            }
            else
            {
                if (lbJa.Text.ToLower().Contains(keyData.ToString().ToLower()))
                {
                    if (this.lbJa.ForeColor == SystemColors.WindowText) this.lbJa.ForeColor = Color.Red;
                    else this.lbJa.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    if (lbPalavra.Text.ToLower().Contains(keyData.ToString().ToLower()))
                    {
                        if (!lbTest.Text.ToLower().Contains(keyData.ToString().ToLower()))
                        {
                            lbTest.Text = lbTest.Text + " " + keyData.ToString() + " -";
                        }
                        else
                        {
                            if (this.lbTest.ForeColor == SystemColors.WindowText) this.lbTest.ForeColor = Color.ForestGreen;
                            else this.lbTest.ForeColor = SystemColors.WindowText;

                        }
                        acertou(keyData.ToString());
                    }
                    else
                    {
                        lbJa.Text = lbJa.Text + " " + keyData.ToString() + " -";
                        errou();
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void reiniciar()
        {
            btJogar.Enabled = true;
            jogar = false;
            txtDigite.Text = string.Empty;
            lbJa.Text = string.Empty;
            lbTest.Text = string.Empty;
            erro = 1;
            pass = 0;
            modo = 2;
            lbTest.BackColor = SystemColors.Control;
            lbJa.BackColor = SystemColors.Control;
        }

        private void errou()
        {
            switch (erro)
            {
                case 1:
                    pbImg.Image = Properties.Resources.Cabeca;
                    break;
                case 2:
                    pbImg.Image = Properties.Resources.Tronco;
                    break;
                case 3:
                    pbImg.Image = Properties.Resources.BracoE;
                    break;
                case 4:
                    pbImg.Image = Properties.Resources.BracoD;
                    break;
                case 5:
                    pbImg.Image = Properties.Resources.Bunda;
                    break;
                case 6:
                    pbImg.Image = Properties.Resources.PernaE;
                    break;
                case 7:
                    pbImg.Image = Properties.Resources.PernaD;
                    break;
                case 8:
                    pbImg.Image = Properties.Resources.Morto;
                    pass = 1;
                    break;
                default:
                    break;
            }
            if (pass == 0) erro++;
            else
            {
                string txt;
                if (modo == 1)
                {
                    txt = txtDigite.Text.ToUpper();
                }
                else
                {
                    txt = lbPalavra.Text.ToUpper();
                }
                pnInfor.Visible = false;
                pnPerdeu.Visible = true;
                pcbPerder.Image = Properties.Resources.Enforcado;
                lblPerder.Text = "Você perdeu!!!";
                lblPerder.ForeColor = Color.Red;
                lbfalaPerdeu.Text = "A palavra era: " + txt;
                reiniciar();
            }
        }

        private void acertou(string Key)
        {
            if (modo == 1)
            {
                for (int cont = 0; cont < txtDigite.Text.Length; cont++)
                {
                    if (txtDigite.Text[cont].ToString() == Key.ToLower())
                    {
                        Graphics gra = pcb[cont].CreateGraphics();
                        gra.DrawString(Key, new Font("Verdana", 25), new SolidBrush(Color.Black), 0, 0);
                        palavra = palavra.Replace(Key.ToLower(), " ");

                    }
                }
            }
            else
            {
                for (int cont = 0; cont < lbPalavra.Text.Length; cont++)
                {
                    if (lbPalavra.Text[cont].ToString() == Key.ToLower())
                    {
                        Graphics gra = pcb[cont].CreateGraphics();
                        gra.DrawString(Key, new Font("Verdana", 25), new SolidBrush(Color.Black), 0, 0);
                        palavra = palavra.Replace(Key.ToLower(), " ");
                    }
                }
            }
            if (palavra.Trim() == "")
            {
                string txt;
                if (modo == 1)
                {
                    txt = lbPalavra.Text.ToUpper();
                }
                else
                {
                    txt = lbPalavra.Text.ToUpper();
                }
                pnInfor.Visible = false;
                pbImg.Image = Properties.Resources.Inicio;
                pnPerdeu.Visible = true;
                pcbPerder.Image = Properties.Resources.Vencer;
                lblPerder.Text = "Você Acertou!";
                lblPerder.ForeColor = Color.SpringGreen;
                lbfalaPerdeu.Text = "";
                reiniciar();
            }
        }
    }
}
