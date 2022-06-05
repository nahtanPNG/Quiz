using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Nathan
{
    public partial class quiz : Form
    {
        public int pergunta = 1;
        public int pontuacao = 0;
        public quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton2.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_grimm;
            pictureBox1.Image = Properties.Resources.hornet;
            label1.Text = "Qual o nome da antagonista do jogo?";
            radioButton1.Text = "Hornet";
            radioButton2.Text = "Rosália";
            radioButton3.Text = "Amanda";
            button1.Visible = false;
            button2.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void quiz_Load(object sender, EventArgs e)
        {
            if (pergunta == 1)
            {
                pictureBox1.Image = Properties.Resources.knight;
                pictureBox1.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton1.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            
            }
            BackgroundImage = Properties.Resources.fundo_3;
            pictureBox1.Image = Properties.Resources.mapa;
            label1.Text = "Qual o nome do local que o jogo se passa";
            radioButton1.Text = "Cidade das lágrimas";
            radioButton2.Text = "Hollownest";
            radioButton3.Text = "São Paulo";
            button2.Visible = false;
            button3.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton2.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_4;
            pictureBox1.Image = Properties.Resources.cornifer;
            label1.Text = "Qual o nome do personagem abaixo?";
            radioButton1.Text = "Quirrel";
            radioButton2.Text = "Knight";
            radioButton3.Text = "Cornifer";
            button3.Visible = false;
            button4.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton3.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_5;
            pictureBox1.Image = Properties.Resources.amuletos;
            label1.Text = "Qual o nome dos itens abaixo?";
            radioButton1.Text = "Habilidades";
            radioButton2.Text = "Amuletos";
            radioButton3.Text = "Marca Página";
            button4.Visible = false;
            button5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton2.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_6;
            pictureBox1.Image = Properties.Resources.sly;
            label1.Text = "O que o personagem abaixo vende?";
            radioButton1.Text = "Mapa";
            radioButton2.Text = "Mágias";
            radioButton3.Text = "Armamentos";
            button5.Visible = false;
            button6.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton3.Checked == true)
            {
                pontuacao = pontuacao + 1;
                
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_8;
            pictureBox1.Image = Properties.Resources.boss;
            label1.Text = "O que é o personagem abaixo?";
            radioButton1.Text = "Mercador";
            radioButton2.Text = "Amigo";
            radioButton3.Text = "Boss";
            button6.Visible = false;
            button7.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton3.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_9;
            pictureBox1.Image = Properties.Resources.zote1;
            label1.Text = "Qual o nome do personagem abaixo?";
            radioButton1.Text = "Quirrel";
            radioButton2.Text = "Zote";
            radioButton3.Text = "Radiant";
            button7.Visible = false;
            button8.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton2.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.yGDQbSV;
            pictureBox1.Image = Properties.Resources.quirrel;
            label1.Text = "O personagem abaixo é caracterizado por:";
            radioButton1.Text = "Lutar contra você";
            radioButton2.Text = "Te ajudar em lutas";
            radioButton3.Text = "Te trair";
            button8.Visible = false;
            button9.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pergunta = pergunta + 1;
            label3.Text = "" + pergunta;
            if (radioButton2.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            BackgroundImage = Properties.Resources.fundo_10;
            pictureBox1.Image = Properties.Resources.bussola;
            label1.Text = "O amuleto abaixo server para:";
            radioButton1.Text = "Te guiar no mapa";
            radioButton2.Text = "Te dar um escudo";
            radioButton3.Text = "Aumentar seu dano";
            button9.Visible = false;
            button10.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pontuacao = pontuacao + 1;
                label2.Text = "Pontuação: " + pontuacao;
            }
            MessageBox.Show("Você acertou: " + pontuacao + " Questões!");
            this.Hide();
            var fim = new fim();
            fim.Show();

        }
    }
}
