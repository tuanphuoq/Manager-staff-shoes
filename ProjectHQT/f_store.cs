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
    public partial class f_store : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        public f_store()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_announce.ForeColor = System.Drawing.Color.Red;
            lb_announce.Text = "Sản phẩm không tồn tại, vui lòng xem lại !";
            //CODE kiểm tra dữ liệu đã ghi trong txt_shoesname đã tồn tại trong csdl chưa
            string shoesid = txt_shoesid.Text;
            //so sánh
            string query = "SELECT shoes_name FROM shoes WHERE id_shoes ='"+shoesid+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                //cmd.Parameters.Add("@shoesid", SqlDbType.NVarChar).Value = shoesid;
                //int rowCount = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr["shoes_name"].ToString());
                    if (dr["shoes_name"].ToString() != null )
                    {    
                        lb_announce.ForeColor = System.Drawing.Color.Green;
                        lb_announce.Text = "Sản phẩm đã tồn tại. Tiếp tục nhập kho";
                    }
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

        }

        private void btn_store_shoes_Click(object sender, EventArgs e)
        {
            if(txt_shoesid.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin 'MÃ SẢN PHẨM'");
            }
            else if(txt_quantity.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin 'SỐ LƯỢNG'");
            }
            else
            {
                string masp = txt_shoesid.Text;
                string sl = txt_quantity.Text;
                //gọi hàm update số lượng sản phẩm
                string query = "execute updateQuantity '"+masp+"','"+sl+"'";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    int rowCount = cmd.ExecuteNonQuery();
                    //MessageBox.Show(rowCount.ToString());
                    if( rowCount > 0)
                    {
                        MessageBox.Show("Cập nhật số lượng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm cần cập nhật");
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
            }
        }

        private void btn_store_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
