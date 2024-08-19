using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_lacos
{
    public partial class FRMtabuada : Form
    {
        public FRMtabuada()
        {
            InitializeComponent();
        }

        private void BTcalc_Click(object sender, EventArgs e)
        {
            int num, mult = 0, result;

            if (int.TryParse(TXnum.Text, out num))
            {
                LBOXresult.Items.Clear();

                while (mult <= 10)
                {
                    result = num * mult;
                    LBOXresult.Items.Add($"{num} x {mult} = {result}");
                    mult++;
                }
            }

            else
            {
                MessageBox.Show("Insira um número inteiro");
            }


        }

        private void TXnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int num, mult = 0, result;

                if (int.TryParse(TXnum.Text, out num))
                {
                    LBOXresult.Items.Clear();

                    while (mult <= 10)
                    {
                        result = num * mult;
                        LBOXresult.Items.Add($"{num} x {mult} = {result}");
                        mult++;
                    }
                }

                else
                {
                    MessageBox.Show("Insira um número inteiro");
                }
            }

            else
            {

            }
        }
    }
}
