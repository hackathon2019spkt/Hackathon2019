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
           
                MessageBox.Show("Delete success!", "Notice");
            }
            else
            {
                MessageBox.Show("Fail", "Notice");
            }
        }
    }
}
