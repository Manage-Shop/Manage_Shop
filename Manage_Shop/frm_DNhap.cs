using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Manage_Shop
{
    public partial class frm_DNhap : Form
    {
        public frm_DNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = null;
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Text = null;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ textbox
            string tendn = txtTenDN.Text;
            string matkhau = txtMK.Text;

            //kết nối csdl
            string str = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\DOANMONHOC\\PTPM\\Manage_Shop\\Manage_Shop\\Manage_Shop\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            //truy vấn dữ liệu
            SqlCommand cmd = new SqlCommand("SELECT matkhau, tennv, chucvu FROM NhanVien WHERE tendn = '" + tendn + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //so sánh password
            if (reader.HasRows)
            {
                reader.Read();

                /*
                // không cho nhân viên đăng nhập vào phần mềm
                if (reader.GetString(2) == "NHÂN VIÊN")
                {
                    MessageBox.Show("Xin lỗi. 'NHÂN VIÊN' không có quyền sử dụng phần mềm này!");
                    return;
                }
                 */

                if (reader.GetString(0) == matkhau)
                {
                    string tennv = reader.GetString(1);
                    string chucvu = reader.GetString(2);

                    

                    //MessageBox.Show("Đăng nhập thành công!");
                    MessageBox.Show("Xin chào " + "'" + chucvu + "'" + " " + tennv + "!");

                    // gọi frmMain lên và truyền tham số tennv và chucvu qua frmMain
                    frmMain f = new frmMain();
                    //f.nhandulieu_ten = tennv;
                    //f.nhandulieu_chucvu = chucvu;


                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Mật khẩu sai!");
                
            }
            else
            {
                MessageBox.Show("Người dùng không hợp lệ!");
            }

            reader.Close();
        }
    }
        }





