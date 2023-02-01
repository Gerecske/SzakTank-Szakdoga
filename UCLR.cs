using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzakTank2._0
{
    public partial class UCLR : UserControl
    {
        public UCLR()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            UCRegister UCReg = new UCRegister();
            Controls.Clear();
            Controls.Add(UCReg);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UCLogin UCLog = new UCLogin();
            Controls.Clear();
            Controls.Add(UCLog);
        }
    }
}
