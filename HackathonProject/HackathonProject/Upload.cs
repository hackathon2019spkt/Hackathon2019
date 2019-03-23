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
            dtgv_SaveExp.Columns[0].HeaderText = "ID";
            dtgv_SaveExp.Columns[1].HeaderText = "Date";
            dtgv_SaveExp.Columns[2].HeaderText = "Y";
            dtgv_SaveExp.Columns[3].HeaderText = "Velocity";
            dtgv_SaveExp.Columns[4].HeaderText = "Time";
            dtgv_SaveExp.Columns[5].HeaderText = "Accerlation";
            dtgv_SaveExp.Columns[6].HeaderText = "Radius";
            dtgv_SaveExp.Columns[7].HeaderText = "Object Density";
            dtgv_SaveExp.Columns[8].HeaderText = "Liquid Density";
            dtgv_SaveExp.Columns[9].HeaderText = "X";
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            Form1.upload = getInfor();
            Form1.ischangetoupload = true;
        }

        private SaveExp getInfor()
        {
            SaveExp infor = new SaveExp();
            infor.ID = dtgv_SaveExp.SelectedRows[0].Cells["ID"].Value.ToString();
            infor.Ngay = dtgv_SaveExp.SelectedRows[0].Cells["NGAY"].Value.ToString();
            infor.Y = int.Parse(dtgv_SaveExp.SelectedRows[0].Cells["Y"].Value.ToString());
            infor.Vt = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["VT"].Value.ToString());
            infor.ThoiGian = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["THOIGIAN"].Value.ToString());
            infor.A = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["A"].Value.ToString());
            infor.BanKinh = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["BANKINH"].Value.ToString());
            infor.KhoiLuongRiengVat = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["KHOILUONGRIENGVAT"].Value.ToString());
            infor.KhoiLuongRiengChat = float.Parse(dtgv_SaveExp.SelectedRows[0].Cells["KHOILUONGRIENGCHAT"].Value.ToString());
            infor.X = int.Parse(dtgv_SaveExp.SelectedRows[0].Cells["X"].Value.ToString());

            return infor;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result;
            result = SaveExp_BUL.DeleteSave(dtgv_SaveExp.SelectedRows[0].Cells["ID"].Value.ToString());
            if (result)
            {
                lstSave = SaveExp_BUL.LoadSave();
                dtgv_SaveExp.DataSource = typeof(List<SaveExp>);
                dtgv_SaveExp.DataSource = lstSave;
                dtgv_SaveExp.DataSource = lstSave;
                dtgv_SaveExp.Columns[0].HeaderText = "ID";
                dtgv_SaveExp.Columns[1].HeaderText = "Date";
                dtgv_SaveExp.Columns[2].HeaderText = "Y";
                dtgv_SaveExp.Columns[3].HeaderText = "Velocity";
                dtgv_SaveExp.Columns[4].HeaderText = "Time";
                dtgv_SaveExp.Columns[5].HeaderText = "Accerlation";
                dtgv_SaveExp.Columns[6].HeaderText = "Radius";
                dtgv_SaveExp.Columns[7].HeaderText = "Object Density";
                dtgv_SaveExp.Columns[8].HeaderText = "Liquid Density";
                dtgv_SaveExp.Columns[9].HeaderText = "X";
                MessageBox.Show("Delete success!", "Notice");
            }
            else
            {
                MessageBox.Show("Fail", "Notice");
            }
        }
    }
}
