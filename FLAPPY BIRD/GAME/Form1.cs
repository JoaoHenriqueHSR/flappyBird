using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form1 : Form
    {
        int posObstaculo1;
        int posObstaculo2;
        int posBird;
        int ponto;    
        bool passouCano1 = false;
        int velocidade = 0;
        int gravidade = 1;
        int impulso = -15;
        int seg;
        public Form1()
        {
            InitializeComponent();
            posBird = picBird.Top;
            posObstaculo1 = picObstaculo1.Left;
            posObstaculo2 = picObstaculo2.Left;
            NovoJogo();
        }

        private void NovoJogo()
        {
            timer1.Start();
            picBird.Top = posBird;
            picObstaculo1.Left = posObstaculo1;
            picObstaculo2.Left = posObstaculo2;
            AlturaRand();
            ponto = 0;
            lbPonto.Text = "0";
            gravidade = 1;
            velocidade = 0;
            seg = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg>0)
            {
                seg -= 10;
                Console.WriteLine(seg);
            }

            if (seg < 1) {
                velocidade += gravidade;
                picBird.Top += velocidade;
                picObstaculo1.Left -= 2;



                if (picBird.Bottom >= this.ClientSize.Height ||
                    picBird.Top <= this.ClientSize.Height - this.ClientSize.Height)
                {
                    GameOver();
                }

                if (picBird.Left < picObstaculo1.Right &&
                    picBird.Right > picObstaculo1.Left &&
                    picBird.Top < picObstaculo1.Bottom &&
                    picBird.Bottom > picObstaculo1.Top)
                {
                    GameOver();
                }



                if (picObstaculo1.Right <= this.ClientSize.Width - this.ClientSize.Width)
                {
                    picObstaculo1.Left = this.ClientSize.Width;
                    passouCano1 = false;
                }


                if (!passouCano1 && picBird.Left > picObstaculo1.Right)
                {
                    ponto++;
                    lbPonto.Text = ponto.ToString();
                    passouCano1 = true;
                }

                picObstaculo2.Left -= 2;
                if (picBird.Left < picObstaculo2.Right &&
                    picBird.Right > picObstaculo2.Left &&
                    picBird.Top < picObstaculo2.Bottom &&
                    picBird.Bottom > picObstaculo2.Top)
                {
                    GameOver();
                }


                if (picObstaculo2.Right <= this.ClientSize.Width - this.ClientSize.Width)
                {
                    picObstaculo2.Left = this.ClientSize.Width;
                    AlturaRand();
                }
            }
            
        }

        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show($"Você perdeu o jogo! \nPontuação: {ponto}");
            NovoJogo();
        }

        private void AlturaRand()
        {
            int altura;
            Random rAltura = new Random();
            altura = rAltura.Next(0, this.ClientSize.Height - 200);
            picObstaculo2.Height = altura;

            altura = this.ClientSize.Height-picObstaculo2.Height-200;
            picObstaculo1.Height = altura;
            picObstaculo1.Top = this.ClientSize.Height - picObstaculo1.Height;

        }

        private void btnSaltar_Click(object sender, EventArgs e)
        {
            velocidade = impulso;
            seg = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            velocidade = impulso;
            seg = 0;
        }
    }
}
