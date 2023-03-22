using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_services
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            
            else
            {
                timer1.Enabled = false;
                frm_lgn lgn = new frm_lgn();
                this.Visible = false;
                lgn.ShowDialog();   

            }
        }
    }
}
