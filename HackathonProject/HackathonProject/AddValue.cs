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
    public partial class AddValue : UserControl
    {
        public AddValue()
        {
            InitializeComponent();
        }
        private void btn_OValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        static string maVat = "V-";

        static int i;
        private void btn_OAdd_Click(object sender, EventArgs e)
        {
            i =dtgv_Vat.RowCount;
            bool result;
            i++;
            Vat newVat = new Vat();
            if(Validate(btn_OName.Text, btn_OValue.Text))
            {
                newVat.MaVat = maVat + i;
                newVat.TenVat = btn_OName.Text;
                newVat.GiaTriVat = btn_OValue.Text;
                newVat.ISDEFAUT = "0";
                result=Vat_BUL.InsertVat(newVat);
                if (result)
                {
                    lstVatThiNghiem.Add(newVat);
                    dtgv_Vat.DataSource = typeof(List<Vat>);
                    dtgv_Vat.DataSource = lstVatThiNghiem;
                    dtgv_Vat.DataSource = lstVatThiNghiem;
                    MessageBox.Show("Insert success!", "Notice");
                }
                else
                {
                    MessageBox.Show("Fail!", "Notice");
                }
            }
        }

        private bool Validate(string text1, string text2)
        {
            if (text1.Trim() == "" || text1.Length>10 || text2.Length>10)
            {
                return false;
            }
            return true;
        }
        List<Vat> lstVatThiNghiem;
        private void AddValue_Load(object sender, EventArgs e)
        {
            lstVatThiNghiem = Vat_BUL.LoadVat();
            dtgv_Vat.DataSource = Vat_BUL.LoadVat();
            dtgv_Vat.Columns[0].HeaderText = "MA";

            lstDungDich = DungDich_BUL.LoadDungDich();
            dtgv_DungDich.DataSource = DungDich_BUL.LoadDungDich();

        }

        private void btn_ODelete_Click(object sender, EventArgs e)
        {
            bool result;
            if(dtgv_Vat.SelectedRows[0].Cells["ISDEFAUT"].Value.ToString()=="1")
            {
                MessageBox.Show("Not accept delete data!", "Notice");
            }
            else
            {
                result = Vat_BUL.DeleteVat(dtgv_Vat.SelectedRows[0].Cells["MAVAT"].Value.ToString());
                if (result)
                {
                    lstVatThiNghiem = Vat_BUL.LoadVat();
                    dtgv_Vat.DataSource = typeof(List<DungDich>);
                    dtgv_Vat.DataSource = lstVatThiNghiem;
                    dtgv_Vat.DataSource = lstVatThiNghiem;
                    MessageBox.Show("Delete success!", "Notice");
                }
                else
                {
                    MessageBox.Show("Fail", "Notice");
                }
            }
            
        }
        List<DungDich> lstDungDich = new List<DungDich>();
        static string maDungDich = "D-";
        static int j;
        private void btn_LAdd_Click(object sender, EventArgs e)
        {
            j = dtgv_DungDich.RowCount;
            bool result;
            i++;
            DungDich newDungDich = new DungDich();
            if (Validate(btn_OName.Text, btn_OValue.Text))
            {
                newDungDich.MaDungDich = maDungDich + j;
                newDungDich.TenDungDich = btn_LName.Text;
                newDungDich.GiaTraiDungDich = btn_LValue.Text;
                newDungDich.ISDEFAUT = "0";
                result = DungDich_BUL.InsertDungDich(newDungDich);
                if (result)
                {
                    lstDungDich.Add(newDungDich);
                    dtgv_DungDich.DataSource = typeof(List<DungDich>);
                    dtgv_DungDich.DataSource = lstDungDich;
                    dtgv_DungDich.DataSource = lstDungDich;
                    MessageBox.Show("Insert success!", "Notice");
                }
                else
                {
                    MessageBox.Show("Fail!", "Notice");
                }
            }
        }

        private void btn_LDelete_Click(object sender, EventArgs e)
        {
            bool result;
            if (dtgv_DungDich.SelectedRows[0].Cells["ISDEFAUT"].Value.ToString() == "1")
            {
                MessageBox.Show("Not accept delete data!", "Notice");
            }
            else
            {
                result = DungDich_BUL.DeleteDungDich(dtgv_DungDich.SelectedRows[0].Cells["MADUNGDICH"].Value.ToString());
                if (result)
                {
                    lstDungDich = DungDich_BUL.LoadDungDich();
                    dtgv_DungDich.DataSource = typeof(List<DungDich>);
                    dtgv_DungDich.DataSource = lstDungDich;
                    dtgv_DungDich.DataSource = lstDungDich;
                    MessageBox.Show("Delete success!", "Notice");
                }
                else
                {
                    MessageBox.Show("Fail", "Notice");
                }
            }
                
        }
    }
}
