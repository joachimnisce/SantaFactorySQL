using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace santaFactory
{
    public partial class formName : Form
    {
        public formName()
        {
            InitializeComponent();
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            frmdepartments frm = new frmdepartments();
            frm.ShowDialog();
        }

        private void btn_dwarves_Click(object sender, EventArgs e)
        {
            frmdwarves frm1 = new frmdwarves();
            frm1.ShowDialog();
        }
    }
}
