using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EESSP
{
    public partial class DiagnosticDialogForm : Form
    {
        public string CIM { get; private set; }
        private ArrayList cims;

        public DiagnosticDialogForm(ConnectionClass connectionClass)
        {
            InitializeComponent();
            cims = connectionClass.getListCIM();
            createAutoSuggest();
            ActiveControl = textBoxDiagnostic;
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            CIM = new CimCodes(cims, textBoxDiagnostic.Text, "ID").ID;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CIM = "";
            Close();
        }

        private void createAutoSuggest()
        {
            var source = new AutoCompleteStringCollection();
            string[] diagnostics = new string[cims.Count];
            int count = 0;

            foreach (CimCodes cim in cims)
            {
                diagnostics[count] = cim.Diagnostic;
                count++;
            }
            source.AddRange(diagnostics);

            textBoxDiagnostic.AutoCompleteCustomSource = source;
        }

        private void DiagnosticDialogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !CIM.Equals("")) buttonChoose_Click(sender, e);
        }
    }
}
