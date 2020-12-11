using System.Windows.Forms;

namespace EESSP
{
    class HelperForm
    {

        private Form form;

        public HelperForm(Form form)
        {
            this.form = form;
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    form.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    form.SelectNextControl(ctrl, false, true, true, true);
                }
                else return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    form.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    form.SelectNextControl(ctrl, false, true, true, true);
                }
                else return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
