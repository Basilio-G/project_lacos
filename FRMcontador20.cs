using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_lacos
{
    public partial class FRMcontador20 : Form
    {
        int num = 0;
        public FRMcontador20()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTwhile_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            while (num <= 20)
            {
                LBOXnum.Items.Add(num);
                num++;
            }
            MessageBox.Show("Lista concluída", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);

            num = 0;
        }

        private void BTdowhile_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            do
            {
                LBOXnum.Items.Add(num);
                num++;
            }
            while (num <= 20);

            MessageBox.Show("Lista concluída", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
            num= 0;
        }

        private void BTfor_Click(object sender, EventArgs e)
        {
            LBOXnum.Items.Clear();

            for (num = 0; num <= 20; num++)
            {
                LBOXnum.Items.Add(num);

            }

            MessageBox.Show("Lista concluída", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);

            num = 0;
        }
    }
}
