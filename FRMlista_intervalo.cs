using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_lacos
{
    public partial class FRMlista_intervalo : Form
    {
        int ini, fim, num;

        public FRMlista_intervalo()
        {
            InitializeComponent();
        }


        private void BTdowhile_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            if (int.TryParse(TXBini.Text, out int ini) && int.TryParse(TXBfim.Text, out int fim))
            {

                num = ini;

                if (ini < fim)
                {
                    do
                    {
                        LBOXnum.Items.Add(num);
                        num++;
                    }
                    while (num >= ini && num <= fim);

                }

                else if (ini > fim)
                {
                    do
                    {
                        LBOXnum.Items.Add(num);
                        num--;
                    }
                    while (num <= ini && num >= fim);
                }

                else
                {
                    LBOXnum.Items.Add(num);
                }

                MessageBox.Show("Lista concluída", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Insira números inteiros", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }

        }


        private void BTfor_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            if (int.TryParse(TXBini.Text, out int ini) && int.TryParse(TXBfim.Text, out int fim))
            {

                num = ini;

                if (ini < fim)
                {
                    for (num = ini; num <= fim; num++)
                    {
                        LBOXnum.Items.Add(num);
                    }
                }

                else if (ini > fim)
                {
                    for (num = ini; num >= fim; num--)
                    {
                        LBOXnum.Items.Add(num);
                    }
                }

                else
                {
                    LBOXnum.Items.Add(num);
                }

                MessageBox.Show("Lista concluída", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Insira números inteiros", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }


        private void BTwhile_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            if (int.TryParse(TXBini.Text, out int ini) && int.TryParse(TXBfim.Text, out int fim))
            {
                num = ini;

                if (ini < fim)
                {
                    while (num >= ini && num <= fim)
                    {
                        LBOXnum.Items.Add(num);
                        num++;
                    }
                }

                else if (ini > fim)
                {
                    while (num <= ini && num >= fim)
                    {
                        LBOXnum.Items.Add(num);
                        num--;
                    }
                }

                else
                {
                    LBOXnum.Items.Add(num);
                }

                MessageBox.Show("Lista concluída", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            else
            {
                MessageBox.Show("Insira números inteiros", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        
    }
}
