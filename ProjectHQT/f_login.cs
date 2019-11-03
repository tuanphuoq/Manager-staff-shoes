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
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

       

        private void f_login_Load(object sender, EventArgs e)
        {
            this.txt_userlogin.Focus();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        private int get_level(string userlogin, string pass)
        {
            int level_user = 0;
            try
            {
                
                string query = "SELECT user_level FROM users WHERE user_login = '" + userlogin +"'";
                //SqlCommand cmd = new SqlCommand(query, conn);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                if(dt != null)
                {
                    foreach( DataRow dr in dt.Rows)
                    {
                        string level_user_string = dr["user_level"].ToString();
                        level_user = Int32.Parse(level_user_string);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi !");
            }
            finally
            {
                conn.Close();
            }
            return level_user;
        }

        users u1;
        private void setUser(string userlogin, string pass)
        {
            string name ="";
            int level = 0;
            string query = "SELECT user_name, user_level FROM users where user_login = '"+userlogin+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    name = dr["user_name"].ToString();
                    string level_string = dr["user_level"].ToString();
                    level = Int32.Parse(level_string);
                    //u1 = new users(name, level);
                }
            }
            conn.Close();
            u1 = new users(name, level);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            /*
            string userlogin = this.txt_userlogin.Text;
            string pass = this.txt_password.Text;
            //MessageBox.Show(check_login(userlogin, pass).ToString());
           
            //setUser(userlogin, pass);
            //
            try
            {
                //string query = "execute check_login '@userlogin','@pass'";
                string query = "select user_name from users where user_login = '@userlogin'and pass = '@pass'";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.Add("@userlogin", SqlDbType.Char).Value = userlogin;
                cmd.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
                MessageBox.Show(query);
                MessageBox.Show(userlogin);
                MessageBox.Show(pass);
                int rowCount = cmd.ExecuteNonQuery();
                MessageBox.Show(rowCount.ToString());
                if (rowCount > 0)
                {
                    //setUser(userlogin, pass);
                    string show = "Xin chào " + u1.getUsername();
                    MessageBox.Show(show);
                    this.Hide();
                    string name = u1.getUsername();
                    int level = u1.getLevel();
                    f_main f_main = new f_main(name, level);
                    f_main.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
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
            */
            string userlogin = this.txt_userlogin.Text;
            string pass = this.txt_password.Text;
            //string level_string = this.cbox_level.Text;

            //CODE ADD USER
            string query = "select user_name from users where user_login ='"+userlogin+"' and pass = '"+pass+"'";
            //MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.Add("@user_login", SqlDbType.NVarChar).Value = userlogin;
            //cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            try
            {
                setUser(userlogin, pass);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr["user_name"].ToString());
                    if (dr["user_name"].ToString() != "")
                    {
                        //bill_id = Int32.Parse(dr["bill_id"].ToString());
                        MessageBox.Show("Đăng nhập thành công");
                        //setUser(userlogin, pass);
                        string show = "Xin chào " + u1.getUsername();
                        MessageBox.Show(show);
                        this.Hide();
                        string name = u1.getUsername();
                        int level = u1.getLevel();
                        f_main f_main = new f_main(name, level);
                        f_main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }
                // Tạo một đối tượng Parameter.
                
                /*
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                */
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
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool check_login(string userlogin, string pass)
        {
            bool check = false;
            try
            {
                string query = "select user_name from users where user_login = '@userlogin'and pass = '@pass'";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.Add("@userlogin", SqlDbType.Char).Value = userlogin;
                cmd.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
                int rowCount = cmd.ExecuteNonQuery();
                if(rowCount > 0)
                {
                    check =  true;
                }
                else
                {
                    check = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return check;
        }
    }
}
