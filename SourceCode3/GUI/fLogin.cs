using SourceCode.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
        }
        //private const int CS_DropShadow = 0x00020000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle = CS_DropShadow;
        //        return cp;
        //    }
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            string pass = this.txtPass.Text;
            if(BLL_QLNV.Instance.LogIn(username, pass) != null)
            {
                this.txtUser.Text = "";
                this.txtPass.Text = "";
                if (BLL_QLNV.Instance.LogIn(username,pass).LoaiThanhVien == "ADMIN")
                {
                    fMainAdmin f = new fMainAdmin(BLL_QLNV.Instance.LogIn(username, pass).LoaiThanhVien, BLL_QLNV.Instance.LogIn(username, pass).TenDangNhap);
                    f.Show();
                }
                if (BLL_QLNV.Instance.LogIn(username, pass).LoaiThanhVien == "NHANVIEN")
                {
                    fMainUser f = new fMainUser(BLL_QLNV.Instance.LogIn(username, pass).LoaiThanhVien, BLL_QLNV.Instance.LogIn(username, pass).TenDangNhap);
                    f.Show();
                }

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            //this.txtPass.UseSystemPasswordChar = !this.txtPass.UseSystemPasswordChar;
            txtPass.PasswordChar = CheckMK.Checked ?  '\0' : '●';
        }

    }
}
