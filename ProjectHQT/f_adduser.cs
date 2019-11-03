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
    public partial class f_adduser : Form
    {
        public f_adduser()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            string userlogin = this.txt_add_login.Text;
            string username = this.txt_add_username.Text;
            string pass = this.txt_add_password.Text;
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
            //CODE ADD USER
            try
            {
                string query = "insert into users values (@user_login, @pass, @user_name, @user_level)";
                //MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                // Tạo một đối tượng Parameter.
                cmd.Parameters.Add("@user_login", SqlDbType.NVarChar).Value = userlogin;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                cmd.Parameters.Add("@user_name", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@user_level", SqlDbType.Int).Value = level;

                int rowCount = cmd.ExecuteNonQuery();
                if(rowCount > 0)
                {
                    MessageBox.Show("Thêm người dùng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại");
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
            //CLOSE FORM
            this.Close();
        }
    }
}
