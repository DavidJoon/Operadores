using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 200;
            int b = 300;

            labelA.Text = "O valor de A é: " + a;
            labelB.Text = "O valor de B é: " + b;

            int total = a + b;

            labelResultado.Text = "A soma dos valores é: " + total;
        }

        private void buttonOperadores_Click(object sender, EventArgs e)
        {
            int a = 200;
            int b = 300;

            listBox1.Items.Add("Valor A:  " + a);
            listBox1.Items.Add("Valor B:  " + b);
            listBox1.Items.Add("Mais 30 na A: " + (30 + a));
        }

        private void buttonFormatacao_Click(object sender, EventArgs e)
        {
            string produto = "Celular";
            float preco = 1290.88f;

            labelFormatacao.Text = string.Format("Produto: {0} \nPreço: {1:c}", produto, preco);
        }
    }
}
