using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManager.Services
{
    public class ClickEventService
    {
        public void ClickOnButton(Button button)
        {
            button.BackColor = Color.FromArgb(70, 40, 90);
        }
        public void LeaveButton(Button button)
        {
            button.BackColor = Color.FromArgb(25, 15, 35);
        }

        
        
    }
}
