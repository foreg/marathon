using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon.CustomElements
{
    /// <summary>
    /// Текстбокс, который позволяет писать в себя только цифры; также запрещена любая вставка
    /// </summary>
    class NumericTextBox : TextBox
    {
        private const int WM_PASTE = 0x0302;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}
