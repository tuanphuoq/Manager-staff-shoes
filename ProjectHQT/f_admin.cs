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

namespace ProjectHQT
{
    public partial class f_admin : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        public f_admin()
        {
            InitializeComponent();
        }

        private void f_admin_Load(object sender, EventArgs e)
        {
            btn_updateuser.Enabled = false;
            btn_deluser.Enabled = false;
            txt_userlogin.Enabled = false;
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            f_adduser f_adduser = new f_adduser();
            f_adduser.ShowDialog();
        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            this.grbox_info.Enabled = true;
        }

        private void btn_deluser_Click(object sender, EventArgs e)
        {
            //code delete from user where = userlogin
            string userlogin = this.txt_userlogin.Text;

            try
            {
                string query = "DELETE FROM users WHERE user_login = @userlogin";
                //MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                // Tạo một đối tượng Parameter.

                cmd.Parameters.Add("@userlogin", SqlDbType.NVarChar).Value = userlogin;

                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Xóa người dùng"+userlogin+"thành công");
                }
                else
                {
                    MessageBox.Show("Xóa người dùng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code select * from users
            string query = "SELECT user_login as N'Tên đăng nhập', user_name as N'Họ và tên', level_name as N'Chức vụ' FROM users, level WHERE users.user_level = level.user_level";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            dgvUsers.DataSource = dt;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conn.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //code update user 
            string userlogin = this.txt_userlogin.Text;
            string username = this.txt_username.Text;
            string level_string = this.cbox_level.Text;
            int level = 0;
            if (level_string == "ADMIN")
            {
                level = 1;
            }
            else if (level_string == "QUẢN LÝ")
            {
                level = 2;
            }
            else if (level_string == "NHÂN VIÊN")
            {
                level = 3;
            }

            try
            {
                string query = "UPDATE users SET user_name = @username, user_level = @level WHERE user_login = @userlogin";
                //MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                // Tạo một đối tượng Parameter.

                cmd.Parameters.Add("@userlogin", SqlDbType.NVarChar).Value = userlogin;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@level", SqlDbType.Int).Value = level;

                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Sửa người dùng" + userlogin + "thành công");
                }
                else
                {
                    MessageBox.Show("Sửa người dùng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbox_level.Text = "";
            int numrow;
            numrow = e.RowIndex;
            txt_userlogin.Text = dgvUsers.Rows[numrow].Cells[0].Value.ToString();
            txt_username.Text = dgvUsers.Rows[numrow].Cells[1].Value.ToString();
            cbox_level.SelectedText = dgvUsers.Rows[numrow].Cells[2].Value.ToString();
            btn_updateuser.Enabled = true;
            btn_deluser.Enabled = true;
        }
    }
}
