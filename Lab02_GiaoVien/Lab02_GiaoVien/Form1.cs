using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            String[] datas = { "001", "002", "003", "004", "005", "006", "007", "008", "009", "010", "012", "013", "014" };
            this.cboMaSo.DataSource = datas;
            lbDanhSachMH.Text = "Click";
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = false;
            this.rdNu.Checked = false;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.lbMonHocDay.Items)
                this.lbDanhSachMH.Items.Add(ob);
            this.lbMonHocDay.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        
        private object GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhSachMonHoc mh = new DanhSachMonHoc();
            foreach (object ob in lbMonHocDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;

            return gv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaSo", typeof(int));
            table.Columns.Add("HoTen", typeof(string));
            table.Columns.Add("NgaySinh", typeof(DateTime));
            table.Columns.Add("GioiTinh", typeof(string));
            table.Columns.Add("SoDT", typeof(string));
            table.Columns.Add("Mail", typeof(string));
            table.Columns.Add("NgoaiNgu", typeof(string));
            table.Columns.Add("MonDay", typeof(string));

            table.Rows.Add(001, "Trần Thiên An", "17/05/2001", "Nữ", "0575852689", "thienan@gmail.com", "Tiếng Anh",
                "Tin học cơ sở,Lập trình cấu trúc C / C++,Cơ sở dữ liệu,Tiếng Anh B1", DateTime.Now);
            table.Rows.Add(002, "Ngọc Hoài An", "ABC", DateTime.Now);
            table.Rows.Add(3, "Thuốc lá", "555", DateTime.Now);
            table.Rows.Add(4, "Rượu vang", "Janet", DateTime.Now);
            table.Rows.Add(5, "Đèn bàn", "Melanie", DateTime.Now);

            return table;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }
    }
}
