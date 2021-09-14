using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2608
{
    public partial class frmIdades : Form
    {
        int pos = 0, maiorIdade = 0;

        public frmIdades()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","SAIR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtIdade.Text) > maiorIdade)
                {
                    maiorIdade = int.Parse(txtIdade.Text);
                }

                pos++; //ir para próxima pessoa
                txtIdade.Clear(); //limpa a caixa de texto
                if (pos <= 5)
                {
                    lblIdade.Text = "Insira a idade " + pos + ":";
                    if(pos == 5)
                        btnProximo.Text = "Terminar";
                }
                else
                {
                    txtIdade.ReadOnly = true;
                    btnProximo.Enabled = false;
                    btnInicio.Enabled = true;
                    lblIdade.Text = "Insira a idade:";
                    btnProximo.Text = "Próximo";
                    //mostrar a maior idade
                    MessageBox.Show("A maior idade lida é: " + maiorIdade,
                        "MAIOR IDADE LIDA", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                txtIdade.Focus();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            txtIdade.ReadOnly = false; //habilitar para edição
            btnProximo.Enabled = true;
            txtIdade.Focus();
            pos = 1;
            maiorIdade = 0;
            lblIdade.Text = "Insira a idade " + pos + ":";
            btnInicio.Enabled = false;
        }
    }
}
