using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDotNet
{
    public partial class _4_FormVectores : Form
    {
        public _4_FormVectores()
        {
            InitializeComponent();
        }

        private void btnOperVec_Click(object sender, EventArgs e)
        {
            List<String> nombres = new List<String>();
            nombres.Add("Johnny");
            nombres.Add("Pedro");
            nombres.Add("Juan");
            nombres.Add("Andres");

            for (int x = 0; x < nombres.Count; x++)
            {
                MessageBox.Show(nombres[x]);
            }
        }
    }
}
