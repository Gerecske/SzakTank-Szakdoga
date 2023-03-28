using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzakTank2._0.Properties;

namespace SzakTank2._0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //UCLR LogReg = new UCLR();
            //Controls.Add(LogReg);
            UCModeSelector ModeSelect = new UCModeSelector("Gerecske");
            Controls.Add(ModeSelect);
        }

       
    }
}
