using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaElet
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int valor;
            int[] valores = { 100, 50, 20, 10, 2, 5 };
            int[] qtdNotas = new int[6];

            try
            {
                valor = int.Parse(txtValor.Text);

                //lblCem.Text = (valor / 100).ToString();
                //valor = valor % 100;
                //lblCinq.Text = (valor / 50).ToString();
                //valor = valor % 50;
                //lblVinte.Text = (valor / 20).ToString();
                //valor = valor % 20;

                if (valor == 1 || valor == 3)
                {
                    MessageBox.Show("Não é possivel retirar essa quantidade!");
                }
                else
                {
                    //olhar e verificar se eu vou precisar de, pelo menos uma,
                    //nota de 5
                    //Se for impar, precisa!
                    if(valor % 2 != 0)
                    {
                        qtdNotas[5] = 1;
                        valor -= 5;
                    }

                    for (int nota = 0; nota < 6; nota++)
                    {
                        qtdNotas[nota] += (valor / valores[nota]);
                        valor = valor % valores[nota];
                    }

                    //jogar nos labels
                    lblCem.Text = qtdNotas[0].ToString();
                    lblCinq.Text = qtdNotas[1].ToString();
                    lblVinte.Text = qtdNotas[2].ToString();
                    lblDez.Text = qtdNotas[3].ToString();
                    lblCinco.Text = qtdNotas[5].ToString();
                    lblDois.Text = qtdNotas[4].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
