using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
        private void frmForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
