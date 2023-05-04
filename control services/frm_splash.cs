using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=mssql-115648-0.cloudclusters.net,10046;Initial Catalog=gldturfreDeploy;User ID=PedroSampaio;Password=PedroSampaio1!";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
                /*
                timer1.Enabled = false;
                frm_lgn lgn = new frm_lgn();
                this.Visible = false;
                lgn.ShowDialog();   
                */
            }
        }
    }
}

