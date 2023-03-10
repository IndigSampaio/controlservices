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
    public partial class frm_consultDistancia : Form
    {
        public frm_consultDistancia()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel2.Enabled == true)
            {
                System.Diagnostics.Process.Start(@"Chrome.exe", "https://web.whatsapp.com/send?phone=5511984062207");
            }
        }
    }
}
