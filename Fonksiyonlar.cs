using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciProje
{
    public class Fonksiyonlar
    {
        public static void KontrolTemizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    nmr.Value = nmr.Minimum;
                }
                else if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    KontrolTemizle(gb.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flv = (FlowLayoutPanel)item;
                    KontrolTemizle(flv.Controls);
                }
                else if (item is DataGridView)
                {
                    DataGridView dgw = (DataGridView)item;
                    KontrolTemizle(dgw.Controls);
                }
                else if (item is ListBox)
                {
                    ListBox lb = (ListBox)item;
                    KontrolTemizle(lb.Controls);
                }


            }
        }

    }
}
