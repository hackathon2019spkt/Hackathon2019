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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        List<LichSu> lstLichSu;
        private void History_Load(object sender, EventArgs e)   
        {
            lstLichSu = LichSu_BUL.LoadLichSu();
            dtgv_LishSu.DataSource = LichSu_BUL.LoadLichSu();
            dtgv_LishSu.Columns[0].HeaderText = "ID";
            dtgv_LishSu.Columns[1].HeaderText = "Height 0";
            dtgv_LishSu.Columns[2].HeaderText = "Radius";
            dtgv_LishSu.Columns[3].HeaderText = "Liquid Density";
            dtgv_LishSu.Columns[4].HeaderText = "Object Density";
            dtgv_LishSu.Columns[5].HeaderText = "Total time";
        }

        private void btn_ODelete_Click(object sender, EventArgs e)
        {
            bool result;
            result = LichSu_BUL.DeleteLichSu(dtgv_LishSu.SelectedRows[0].Cells["MALICHSU"].Value.ToString());
            if (result)
            {
                lstLichSu = LichSu_BUL.LoadLichSu();
                dtgv_LishSu.DataSource = typeof(List<LichSu>);
                dtgv_LishSu.DataSource = lstLichSu;
                dtgv_LishSu.DataSource = lstLichSu;
                dtgv_LishSu.Columns[0].HeaderText = "ID";
                dtgv_LishSu.Columns[1].HeaderText = "Height 0";
                dtgv_LishSu.Columns[2].HeaderText = "Radius";
                dtgv_LishSu.Columns[3].HeaderText = "Liquid Density";
                dtgv_LishSu.Columns[4].HeaderText = "Object Density";
                dtgv_LishSu.Columns[5].HeaderText = "Total time";
                MessageBox.Show("Delete success!", "Notice");
            }
            else
            {
                MessageBox.Show("Fail", "Notice");
            }
        }
    }
}
