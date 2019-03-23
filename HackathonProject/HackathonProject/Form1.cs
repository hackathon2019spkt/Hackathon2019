using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace HackathonProject
{
    public partial class Form1 : Form
    {
        // 1000px = 1m
        KhoiCau khoicau;
        MuiTen muiten;
        // Biến xét sự xuất hiện của vector
        public bool is_visible_gravity = false;
        public bool is_visible_acsimet = false;
        public bool is_visible_friction = false;
        public bool is_visible_resutant = false;
        // Giá trị sơ khởi của vật
        public double khoiluongriengvat = 7800;
        public double khoiluongriengchatlong = 1000;
        public double docaobandau;
        public double bankinhvat = 0.025;
        // Cờ xác định vật đang rơi
        public static bool Is_Falling = false;
        // Vị trí giữa vật
        public int Object_Mid_X;
        public int Object_Mid_Y;
        //Form biểu đồ
        frm_BieuDo frmChart;
        public static bool ischangetoupload = false;
        public static SaveExp upload;
        public Form1()
        {
            InitializeComponent();
            LoadVatThiNghiem();
            SetImageValue();
            SetFirstObjectValue();
            CreateRuler();
            LoadData();
        }

        #region Advance function: Thêm CSDL chất, xem lịch sử, xuất file
        int flagForm = 0;
        AddValue AddValueForm;
        History HistoryForm;
        Upload UploadForm;
        private void LoadData()
        {
            frmChart = new frm_BieuDo();
            frmChart.SetLabelObject(7800 + "");
            frmChart.SetLabelLiquid(1000 + "");
            frmChart.SetLabelRadius(((((double)pbx_Object.Size.Height) / 1000) / 2).ToString());
        }
        private void RemoveBasicPanel(bool visible)
        {
            pbx_Ruler.Visible = visible;
            pbx_Object.Visible = visible;
            pbx_Ruler.Visible = visible;
            pnl_Ruler.Visible = visible;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (flagForm == 0)
            {
                RemoveBasicPanel(false);
                AddValueForm = new AddValue();
                pnl_Board.Controls.Add(AddValueForm);
                flagForm = 10;
            }
            else if (flagForm == 10)
            {
                flagForm = 0;
                RemoveBasicPanel(true);
                pnl_Board.Controls.Remove(AddValueForm);
                LoadVatThiNghiem();
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            if (flagForm == 0)
            {
                RemoveBasicPanel(false);
                HistoryForm = new History();
                pnl_Board.Controls.Add(HistoryForm);
                flagForm = 20;
            }
            else if (flagForm == 20)
            {
                flagForm = 0;
                RemoveBasicPanel(true);
                pnl_Board.Controls.Remove(HistoryForm);
            }
        }

        string IDS = "ID-";
        int idSave;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                idSave = int.Parse(SaveExp_DAL.quantityElement().Substring(3)) + 1;
                SaveExp newSaveEx = new SaveExp();
                newSaveEx.ID = IDS + idSave.ToString();
                newSaveEx.Ngay = DateTime.Now.ToString();
                newSaveEx.Y = pbx_Object.Location.Y;
                newSaveEx.X = pbx_Object.Location.X;
                newSaveEx.Vt = float.Parse(khoicau.vt + "");
                newSaveEx.ThoiGian = float.Parse(khoicau.time + "");
                newSaveEx.A = float.Parse(khoicau.a + "");
                newSaveEx.BanKinh = float.Parse(khoicau.R + "");
                newSaveEx.KhoiLuongRiengVat = float.Parse(khoiluongriengvat + "");
                newSaveEx.KhoiLuongRiengChat = float.Parse(khoiluongriengchatlong + "");

                bool result = SaveExp_BUL.InsertSave(newSaveEx);

                if (result)
                {
                    MessageBox.Show("Save success!", "Notice");
                }
                else
                {
                    MessageBox.Show("Fail", "Notice");
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
                MessageBox.Show("Invalid dang an oshi!");
            }
            
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if (flagForm == 0)
            {
                RemoveBasicPanel(false);
                UploadForm = new Upload();
                pnl_Board.Controls.Add(UploadForm);
                flagForm = 30;
            }
            else if (flagForm == 30)
            {
                flagForm = 0;
                RemoveBasicPanel(true);
                pnl_Board.Controls.Remove(UploadForm);
                if (ischangetoupload)
                {
                    ReProcess();
                    ischangetoupload = false;
                }
            }
        }

        private void btn_BieuDo_Click(object sender, EventArgs e)
        {
            frmChart.Show();
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialgsave = new SaveFileDialog();
            dialgsave.Filter = "PNG Files (.png)|*.png|All Files (*.*)|*.*";
            dialgsave.FilterIndex = 1;
            if (dialgsave.ShowDialog() == DialogResult.OK)
            {
                frmChart.SaveFile(dialgsave.FileName);
                MessageBox.Show("Saving success");
            }

        }

        public void ReProcess()
        {
            if (!Is_Falling && upload != null)
            {
                pbx_Object.Location = new Point(upload.X, upload.Y);
                docaobandau = ((double)(pnl_Board.Size.Height - (pbx_Object.Location.Y + pbx_Object.Size.Height))) / 1000;
                khoicau = new KhoiCau(upload.KhoiLuongRiengVat, upload.BanKinh, upload.KhoiLuongRiengChat, docaobandau);
                    // Khởi tạo giá trị ban đầu
                khoicau.SetValue();
                // Khởi tạo giá trị cho các vector
                muiten = new MuiTen();
                // Khởi tạo gia tốc trọng trường cho mui ten
                muiten.p = -9.81;
                // Tắt thước đo
                pbx_Ruler.Visible = false;
                khoicau.V = upload.Vt;
                khoicau.a = upload.A;

                lbl_BanKinh.Text = (khoicau.R * 2) + " m";
                trb_BanKinh.Value = (int) (khoicau.R * 2 * 1000);
                
                for (int i = 0; i < cbx_ChatLong.Items.Count; i++)
                {
                    if (cbx_ChatLong.Items[i].ToString() == upload.KhoiLuongRiengChat.ToString())
                    {
                        cbx_ChatLong.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cbx_Vat.Items.Count; i++)
                {
                    if (cbx_Vat.Items[i].ToString() == upload.KhoiLuongRiengVat.ToString())
                    {
                        cbx_Vat.SelectedIndex = i;
                    }
                }
                frmChart.SetLabelInitalHeight(docaobandau);
                // Xác nhận đang rơi
                Is_Falling = true;
                frmChart.ResetData();
                tm_Main.Start();
            }
        }

        #endregion

        #region Basic function form: di chuyển form, exit, btn_Minimize_Click

        Bunifu.Framework.UI.Drag DragForm = new Bunifu.Framework.UI.Drag();
        private void pnl_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.Grab(this);
        }

        private void pnl_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            DragForm.MoveObject();
        }

        private void pnl_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            DragForm.Release();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close application ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            frm_About about = new frm_About();
            about.ShowDialog();
        }

        #endregion

        #region Paint

        Rectangle rect_chatlong;
        Rectangle rect_thanbinhtrai;
        Rectangle rect_thanbinhphai;
        Rectangle rect_daybinh;

        Image img_chatlong;
        Image img_thanbinh;
        Image img_daybinh;

        Graphics g;
        private void SetImageValue()
        {
            rect_chatlong = new Rectangle(270, 329, 300, 450);
            rect_thanbinhtrai = new Rectangle(260, 280, 10, 499);
            rect_thanbinhphai = new Rectangle(570, 280, 10, 499);
            rect_daybinh = new Rectangle(270, pnl_Board.Height - 5, 310, 5);

            img_chatlong = Properties.Resources.chatlong;
            img_thanbinh = Properties.Resources.binh;
            img_daybinh = Properties.Resources.day;
        }
        private void pnl_Board_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImage(img_chatlong, rect_chatlong);
            g.DrawImage(img_thanbinh, rect_thanbinhtrai);
            g.DrawImage(img_thanbinh, rect_thanbinhphai);
            g.DrawImage(img_daybinh, rect_daybinh);

            g.Dispose();
        }
        #endregion

        #region Create ruler: Tạo chỉ số thước đo

        int[] Ruler_Y = new int[16];
        int delta_height_ruler;
        private void pnl_Ruler_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White);
            pen.Width = 2;
            g.DrawRectangle(pen, new Rectangle(0, 0, pnl_Ruler.Width + 10, pnl_Ruler.Height));  
            for (int i = 1; i < 15; i++)
            {
                g.DrawLine(pen, 0, Ruler_Y[i] + delta_height_ruler, 25, Ruler_Y[i] + delta_height_ruler);
            }
        }
        private void CreateRuler()
        {
            for (int i = 1; i < 15; i++)
            {
                Label ruler;
                ruler = RulerLabel(((pnl_Ruler.Size.Height - (double)(i * 50)) / 1000) + " m");
                ruler.Location = new Point(20, i * 50 - ruler.Size.Height / 2);
                Ruler_Y[i] = ruler.Location.Y;
                pnl_Ruler.Controls.Add(ruler);
                delta_height_ruler = ruler.Size.Height / 2;
            }
        }
        private Label RulerLabel(string text)
        {
            Label ruler = new Label();
            ruler.Text = " " + text;
            ruler.Font = new Font("Century Gothic", 11);
            ruler.ForeColor = Color.White;
            return ruler;
        }

        #endregion

        #region Setting Experiment: bán kính vật, ẩn hiện vector, khối lượng riêng các chất

        private void trb_BanKinh_ValueChanged(object sender, EventArgs e)
        {
            pbx_Object.Size = new Size(trb_BanKinh.Value, trb_BanKinh.Value);
            bankinhvat = (((double)pbx_Object.Size.Height) / 1000) / 2;
            lbl_BanKinh.Text = "0.0" + pbx_Object.Size.Width + " m";
            frmChart.SetLabelRadius(((((double)pbx_Object.Size.Height) / 1000) / 2).ToString());
        }

        private void chb_TrongLuc_OnChange(object sender, EventArgs e)
        {
            if (chb_TrongLuc.Checked)
                is_visible_gravity = true;
            else
                is_visible_gravity = false;
        }

        private void chb_Acsimet_OnChange(object sender, EventArgs e)
        {
            if (chb_Acsimet.Checked)
                is_visible_acsimet = true;
            else
                is_visible_acsimet = false;
        }

        private void chb_MaSat_OnChange(object sender, EventArgs e)
        {
            if (chb_MaSat.Checked)
                is_visible_friction = true;
            else
                is_visible_friction = false;
        }

        private void chb_HopLuc_OnChange(object sender, EventArgs e)
        {
            if (chb_HopLuc.Checked)
                is_visible_resutant = true;
            else
                is_visible_resutant = false;
        }

        private void cbx_Vat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadDataFlag)
            {
                khoiluongriengvat = double.Parse(cbx_Vat.SelectedValue.ToString());
                if (frmChart != null)
                    frmChart.SetLabelObject(cbx_Vat.SelectedValue.ToString());
            }
                

        }

        private void cbx_ChatLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadDataFlag)
            {
                khoiluongriengchatlong = double.Parse(cbx_ChatLong.SelectedValue.ToString());
                if (frmChart != null)
                    frmChart.SetLabelLiquid(cbx_ChatLong.SelectedValue.ToString());
            }             
        }

        private void SetFirstObjectValue()
        {
            cbx_Vat.SelectedIndex = 0;
            cbx_ChatLong.SelectedIndex = 0;
        }
        bool LoadDataFlag = false;
        List<Vat> lstVatThiNghiem = new List<Vat>();
        List<DungDich> lstdungdichThiNghiem = new List<DungDich>();
        public void LoadVatThiNghiem()
        {
            lstVatThiNghiem = Vat_BUL.LoadVat();
            lstdungdichThiNghiem = DungDich_BUL.LoadDungDich();
            cbx_Vat.DataSource = lstVatThiNghiem;
            cbx_Vat.DisplayMember = "giaTriVat";
            cbx_Vat.ValueMember = "giaTriVat";
            cbx_ChatLong.DataSource = lstdungdichThiNghiem;
            cbx_ChatLong.DisplayMember = "giaTraiDungDich";
            cbx_ChatLong.ValueMember = "giaTraiDungDich";


            LoadDataFlag = true;
        }
        #endregion

        #region Move and set location: Di chuyển vật và bắt đầu thí nghiệm cùng các thông số sau khi được setting
        bool Object_ismove = false;
        int Object_X, Object_Y;
        private void pbx_Object_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Object_ismove = true;
                Object_X = e.X;
                Object_Y = e.Y;
                SetObjectHeight();
                pbx_Ruler.Visible = true;
                frmChart.ResetData();
            }
        }
        private void pbx_Object_MouseMove(object sender, MouseEventArgs e)
        {
            if (Object_ismove)
            {
                pbx_Object.Left += e.X - Object_X;
                pbx_Object.Top += e.Y - Object_Y;
                SetObjectHeight();
                pbx_Ruler.Width = (925 - (pbx_Object.Location.X + pbx_Object.Size.Width)) - 100;
                pbx_Ruler.Location = new Point(pbx_Object.Location.X + pbx_Object.Width, pbx_Object.Location.Y + pbx_Object.Height - 1);
            }
        }
        private void pbx_Object_MouseUp(object sender, MouseEventArgs e)
        {
            Object_ismove = false;
            if (IsOutside())
            {
                SetOutsideLocation();
            }
            else
            {
                // Set lại vị trí vật so với bình
                SetTrueLocation();
                
                // Gán độ cao ban đầu
                docaobandau = ((double)(pnl_Board.Size.Height - (pbx_Object.Location.Y + pbx_Object.Size.Height))) / 1000;
                frmChart.SetLabelInitalHeight(docaobandau);
                // Khởi tạo vật
                khoicau = new KhoiCau(khoiluongriengvat, bankinhvat, khoiluongriengchatlong, docaobandau);
                // Khởi tạo giá trị ban đầu
                khoicau.SetValue();
                // Khởi tạo giá trị cho các vector
                muiten = new MuiTen();
                // Khởi tạo gia tốc trọng trường cho mui ten
                muiten.p = -9.81;
                // Thủ tục dis enable menu
                ControlMenuPanel(false);
                // Xác nhận đang rơi
                Is_Falling = true;
                // Tắt thước đo
                pbx_Ruler.Visible = false;

                tm_Main.Start();
            }
        }
        private void ControlMenuPanel(bool EnableValue)
        {
            cbx_ChatLong.Enabled = cbx_Vat.Enabled = EnableValue;
            trb_BanKinh.Enabled = EnableValue;
            btn_Add.Enabled = btn_History.Enabled = EnableValue;
            btn_Save.Enabled = btn_Upload.Enabled = btn_XuatFile.Enabled = EnableValue;
            pbx_Object.Enabled = EnableValue;  

        }
        // Set độ cao vật cho label
        private void SetObjectHeight()
        {
            lbl_DoCao.Text = (double.Parse((pnl_Board.Size.Height - (pbx_Object.Location.Y + pbx_Object.Size.Height)).ToString()) / 1000).ToString() + " m";
        }
        // Set đúng vị trí vật so với bình
        private void SetTrueLocation()
        {
            // Giữa thân trái của bình
            if (pbx_Object.Location.X < rect_thanbinhtrai.Location.X)
            {
                if (pbx_Object.Location.X + pbx_Object.Size.Width > rect_thanbinhtrai.Location.X)
                {
                    pbx_Object.Location = new Point(rect_thanbinhtrai.Location.X + 11, pbx_Object.Location.Y);
                }
            }
            // Giữa thân phải của bình
            if (pbx_Object.Location.X < rect_thanbinhphai.Location.X)
            {
                if (pbx_Object.Location.X + pbx_Object.Size.Width > rect_thanbinhphai.Location.X)
                {
                    pbx_Object.Location = new Point(rect_thanbinhphai.Location.X - pbx_Object.Size.Width - 1, pbx_Object.Location.Y);
                }
            }
        }
        // kiểm tra tính đúng đắn của vị trí vật
        private bool IsOutside()
        {
            if (pbx_Object.Location.X <= 0)
            {
                return true;
            }
            if (pbx_Object.Location.Y <= 0)
            {
                return true;
            }
            if (pbx_Object.Location.X + pbx_Object.Size.Width >= pnl_Board.Size.Width - 80)
            {
                return true;
            }
            if (pbx_Object.Location.Y + pbx_Object.Size.Height >= pnl_Board.Size.Height)
            {
                return true;
            }
            return false;
        }
        // Set vị trí khi bị out màn hình cho vật
        private void SetOutsideLocation()
        {
            pbx_Object.Left = 1;
            pbx_Object.Top = 1;
        }
        #endregion 

        #region Timer_Tick: Vòng lặp và thao tác khi vật rơi: ẩn hiện di chuyển vector và vật
        double height;
        bool ObjectisInLiquid = false;
        private void tm_Main_Tick(object sender, EventArgs e)
        {
            ObjectisInLiquid = IsInLiquid();
            if (ObjectisInLiquid)
            {
                khoicau.DeltaY(true);
            }
            else
            {
                khoicau.DeltaY(false);
            }
            height = pnl_Board.Size.Height - (pbx_Object.Location.Y + pbx_Object.Size.Height);
            frmChart.SetData(khoicau.vt, khoicau.a, height, khoicau.time);
            SetObjectHeight();
            pbx_Object.Location = new Point(pbx_Object.Location.X, pnl_Board.Size.Height - (int)(khoicau.h * 1000) - pbx_Object.Size.Height);

            MovingArrow(ObjectisInLiquid);

            if (pbx_Object.Location.Y + pbx_Object.Size.Height > pnl_Board.Size.Height || (khoiluongriengchatlong == khoiluongriengvat && khoicau.vt == 0))
            {
                TimerStopAcction();
                AddHistory();
            }
        }
        
        // Xử lý ẩn hiện di chuyển vector
        private void MovingArrow(bool IsInLiquid)
        {
            Object_Mid_X = pbx_Object.Location.X + pbx_Object.Size.Width / 2;
            Object_Mid_Y = pbx_Object.Location.Y + pbx_Object.Size.Height / 2;
            if (is_visible_gravity)
            {
                SetLocationArrowP();
            }
            else
            {
                pbx_P.Visible = pbx_ArrowP.Visible = false;
            }
            if (is_visible_resutant)
            {
                SetLocationArrowResult();
            }
            else
            {
                pbx_HopLuc.Visible = pbx_ArrowHopLuc.Visible = false;
            }
            if (is_visible_acsimet && IsInLiquid)
            {
                SetLcationArrowFA();
            }
            else
            {
                pbx_FA.Visible = pbx_ArrowFA.Visible = false;
            }

            if (is_visible_friction && IsInLiquid)
            {
                SetLocationArrowMS();
            }
            else
            {
                pbx_FMS.Visible = pbx_ArrowFMS.Visible = false;
            }           
        }
        private void SetLocationArrowP()
        {
            pbx_P.Visible = pbx_ArrowP.Visible = true;
            pbx_P.Location = new Point(Object_Mid_X - 15, Object_Mid_Y);
            pbx_ArrowP.Location = new Point(pbx_P.Location.X - 3, pbx_P.Location.Y + pbx_P.Height - 2);
        }
        private void SetLcationArrowFA()
        {
            muiten.fa = khoicau.aa;
            pbx_FA.Visible = pbx_ArrowFA.Visible = true;
            
            pbx_FA.Height = (int)muiten.FALenght();
            pbx_FA.Location = new Point(Object_Mid_X - 15, Object_Mid_Y - pbx_FA.Height);
            pbx_ArrowFA.Location = new Point(pbx_FA.Location.X - 3, pbx_FA.Location.Y - pbx_ArrowFA.Height + 2);
        }
        private void SetLocationArrowResult()
        {
            muiten.hopluc = khoicau.a;
            pbx_HopLuc.Visible = pbx_ArrowHopLuc.Visible = true;

            pbx_HopLuc.Height = (int)muiten.HoplucLenght();

            if (muiten.hopluc > 0)
            {
                pbx_ArrowHopLuc.Image = Properties.Resources.ArrowHopLuc_up;
                pbx_HopLuc.Location = new Point(Object_Mid_X + 5, Object_Mid_Y - pbx_HopLuc.Height);
                pbx_ArrowHopLuc.Location = new Point(pbx_HopLuc.Location.X - 2, pbx_HopLuc.Location.Y - pbx_ArrowHopLuc.Height + 2);
            }
            else if (muiten.hopluc < 0)
            {
                pbx_ArrowHopLuc.Image = Properties.Resources.ArrowHopLuc_down;
                pbx_HopLuc.Location = new Point(Object_Mid_X + 5, Object_Mid_Y);
                pbx_ArrowHopLuc.Location = new Point(pbx_HopLuc.Location.X - 2, pbx_HopLuc.Location.Y + pbx_HopLuc.Height - 2);
            }
            else
            {
                pbx_HopLuc.Visible = pbx_ArrowHopLuc.Visible = false;
            }
        }
        private void SetLocationArrowMS()
        {
            muiten.fms = khoicau.fms / khoicau.m;
            pbx_FMS.Visible = pbx_ArrowFMS.Visible = true;

            pbx_FMS.Height = (int)muiten.FMSLenght();

            if (muiten.fms > 0)
            {
                pbx_ArrowFMS.Image = Properties.Resources.ArrowFMS_up;
                pbx_FMS.Location = new Point(Object_Mid_X + 5, Object_Mid_Y - pbx_FMS.Height);
                pbx_ArrowFMS.Location = new Point(pbx_FMS.Location.X - 2, pbx_FMS.Location.Y - pbx_ArrowFMS.Height + 2);
            }
            else if (muiten.fms < 0)
            {
                pbx_ArrowFMS.Image = Properties.Resources.ArrowFMS_down;
                pbx_FMS.Location = new Point(Object_Mid_X + 5, Object_Mid_Y);
                pbx_ArrowFMS.Location = new Point(pbx_FMS.Location.X - 2, pbx_FMS.Location.Y + pbx_FMS.Height - 2);
            }
            else
            {
                pbx_FMS.Visible = pbx_ArrowFMS.Visible = false;
            }
        }

        // Hành động khi dừng timer
        private void TimerStopAcction()
        {
            tm_Main.Stop();
            // Thủ tục xác nhận vật đã dừng
            Is_Falling = false;
            ControlMenuPanel(true);
            InvisibleVector();
            pbx_Ruler.Visible = true;
            pbx_Ruler.Location = new Point(pbx_Object.Location.X + pbx_Object.Width, pbx_Object.Location.Y + pbx_Object.Height - 1); ;
        }
        // Ẩn vector
        private void InvisibleVector()
        {
            pbx_P.Visible = pbx_ArrowP.Visible = false;
            pbx_ArrowFA.Visible = pbx_FA.Visible = false;
            pbx_FMS.Visible = pbx_ArrowFMS.Visible = false;
            pbx_ArrowHopLuc.Visible = pbx_HopLuc.Visible = false;
        }

        // Thao tác khi đang làm thí nghiệm
        private void pnl_Board_Click(object sender, EventArgs e)
        {
            if (Is_Falling)
            {
                tm_Main.Stop();
                btn_Resume.Visible = btn_Stop.Visible = true;
            }
        }
        private void btn_Resume_Click(object sender, EventArgs e)
        {
            tm_Main.Start();
            btn_Resume.Visible = btn_Stop.Visible = false;
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            TimerStopAcction();
            AddHistory();
            btn_Resume.Visible = btn_Stop.Visible = false;
        }

        string IDLichSu = "ID-";
        int maLichSu;
        private void AddHistory()
        {
            try
            {
                maLichSu = int.Parse(LichSu_DAL.quantityElement().Substring(3)) + 1;
                LichSu newLichSu = new LichSu();
                newLichSu.MaLichSu = IDLichSu+maLichSu;
                newLichSu.DoCaoBanDau = docaobandau.ToString();
                newLichSu.BanKinh = khoicau.R.ToString();
                newLichSu.KhoiLuongRiengChat = khoiluongriengchatlong.ToString();
                newLichSu.KhoiLuongRiengVat = khoiluongriengvat.ToString();
                newLichSu.ThoiGianTongHop = khoicau.time.ToString();
                bool result = LichSu_BUL.InsertLichSu(newLichSu);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                MessageBox.Show("Invalid dang an oshi!");
            }
        }

        // Xét vị trí của vật có đang trong nước
        private bool IsInLiquid()
        {
            // Trong bình
            if (pbx_Object.Location.X > rect_thanbinhtrai.Location.X && pbx_Object.Location.X < rect_thanbinhphai.Location.X - 10)
            {
                // Trong chất lỏng
                if (pbx_Object.Location.Y + pbx_Object.Size.Height >= rect_chatlong.Location.Y)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion        
    }

}
