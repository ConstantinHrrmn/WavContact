using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WavContact.Metier
{
    class Darkmode
    {
        public static Color ChangeMode(Control.ControlCollection controls)
        {
            Color backcolor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            Color invertedColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            foreach (Control item in controls)
            {
                item.BackColor = backcolor;
                item.ForeColor = invertedColor;

                if (item.Name == "btnClose")
                {
                    item.ForeColor = Color.Red;
                }

                if (item.Name == "btnSwitchMode")
                {
                    item.Text = Properties.Settings.Default.darkmode ? "Clair" : "Foncé";
                }
            }

            return backcolor;
        }
    }
}
