using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager
{
    public partial class UjUgyfelFrm : Form
    {
        public UjUgyfelFrm()
        {
            InitializeComponent();
            cegUgyfelTipusCbx.DataSource = Enum.GetValues(typeof(CegTipus));
            kapcsolattartoStatuszCbx.DataSource = Enum.GetValues(typeof(AlkalmazottStatusz));
        }
    }
}
