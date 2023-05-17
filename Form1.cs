using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GeradordeNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int quantidadeNumeros = 6;
            int valorMinimo = 1;
            int valorMaximo = 61;

            Random random = new Random();
            List<int> numerosAleatorios = new List<int>();


            for (int i = 0; i < quantidadeNumeros; i++)
            {
                int numeroAleatorio = random.Next(valorMinimo, valorMaximo + 1);
                numerosAleatorios.Add(numeroAleatorio);
            }

            numerosAleatorios.Sort();

            resultadoLabel.Text = "Números aleatórios:\n";

            foreach (int numero in numerosAleatorios)
            {
                resultadoLabel.Text += numero + ", ";
            }
        }
    }
}