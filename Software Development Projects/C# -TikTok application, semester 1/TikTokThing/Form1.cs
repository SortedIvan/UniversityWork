using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTokThing
{
    public partial class TikTok : Form
    {
        public TikTok()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int inputNr1 = Convert.ToInt32(tbFirstNumber.Text);
            int inputNr2 = Convert.ToInt32(tbSecondNumber.Text);

            for (int i = inputNr1; i <= inputNr2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    lbResult.Items.Add("TikTok");

                }
                else if (i % 3 == 0)
                {
                    lbResult.Items.Add("Tik");
                }
                else if (i % 5 == 0)
                {
                    lbResult.Items.Add("Tok");
                }
                else
                {
                    lbResult.Items.Add(i);
                }
            }
        }

        private void TikTok_Load(object sender, EventArgs e)
        {

        }
    }
}
