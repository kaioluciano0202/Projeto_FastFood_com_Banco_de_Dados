using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_BigMac_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MacPedido_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\kaiocs\textto" + DateTime.Now.ToString("dd_MM_ss") + ".txt", txt_Texto.Text);
            txt_Texto.Clear();
            MessageBox.Show("Pedido Realizado");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "BigMac Combo \r\n Preço R$:45,00"; //valor e quebrando o texto
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "McChicken Combo \r\n Preço R$:26,50"; //valor e quebrando o texto
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "CheddarBurger Combo \r\n Preço R$:25,00"; //valor e quebrando o texto
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "Quarter Pounder Combo \r\n Preço R$:32,00"; //valor e quebrando o texto
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txt_Texto.Text = "BigMac Combo \r\n Preço R$:45,00"; //valor e quebrando o texto
        }
    }
}
