using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoreProcedureGenerator.Session;

namespace StoreProcedureGenerator
{
    public partial class MDIMaster : Form
    {

        #region "Initial Components"

        public MDIMaster()
        {
            InitializeComponent();

            this.tsmiConnect.Click += new EventHandler(tsmiConnect_Click);
        }

        #endregion

        #region "Form Buttons"

        private void tsmiConnect_Click(object sender, EventArgs e)
        {
            frmConnect objForm = new frmConnect();
            objForm.ShowDialog();
        }


        #endregion

    }
}
