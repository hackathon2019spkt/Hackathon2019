using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject
{
    public partial class Upload : UserControl
    {
        public Upload()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(btn_Load, 15);
        }

        List<SaveExp> lstSave;
        private void Upload_Load(object sender, EventArgs e)
        {
            lstSave = SaveExp_BUL.LoadSave();
            dtgv_SaveExp.DataSource = SaveExp_BUL.LoadSave();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }
    }
}
