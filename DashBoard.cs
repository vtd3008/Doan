using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DashBoard: Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        bool nhansuExpand = false;
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void nhansuTransition_Tick(object sender, EventArgs e)
        {
            if (nhansuExpand == false)
            {
                nhansuContainer.Height += 10;
                if (nhansuContainer.Height >= 165)
                {
                    nhansuTransition.Stop();
                    nhansuExpand = true;
                }
            }
            else{
                nhansuContainer.Height -= 10;
                if(nhansuContainer.Height <= 41){
                    nhansuTransition.Stop();
                    nhansuExpand = false; 
                }
            }
        }

        private void nhansu_Click(object sender, EventArgs e)
        {
            nhansuTransition.Start();
        }
    }
}
