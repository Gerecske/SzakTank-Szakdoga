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
    public partial class UCModeSelector : UserControl
    {
        private string User;
        public UCModeSelector(string User)
        {
            InitializeComponent();
            this.User = User;
        }

        private void btnTut_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UCMain Main = new UCMain(User);
            Controls.Clear();
            Controls.Add(Main);
        }
    }
}
