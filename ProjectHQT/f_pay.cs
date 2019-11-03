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
    public partial class f_pay : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        public f_pay()
        {
            InitializeComponent();
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            //get the values
            string nameGuest = txt_guest.Text;
            string id_shoes = txt_idshoes.Text;
            
            string shoes_name = getShoes_name(id_shoes);
            int number = Int32.Parse(nUD_quantity.Value.ToString());
            
            //CODE ADD BILL
            try
            {
                insertBill(nameGuest);
                int bill_id = getBill_id(nameGuest);
                insertBill_detail(bill_id, id_shoes, shoes_name, number);

                //show data bill_detail
                string query4 = "select * from bill_detail";
                SqlDataAdapter da = new SqlDataAdapter(query4, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBill.DataSource = dt;
                dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void insertBill(string nameGuest)//insert to Bill table
        {
            string query = "insert into bill values (@nameGuest, @total)";
            //MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // Tạo một đối tượng Parameter.

            cmd.Parameters.Add("@nameGuest", SqlDbType.NVarChar).Value = nameGuest;
            cmd.Parameters.Add("@total", SqlDbType.Int).Value = 0;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private string getShoes_name(string id) //get shoes_name
        {
            string shoes_name = "";
            string query = "select * from shoes where id_shoes = '" + id + "'";
            //lấy shoes_name cho bảng bill_detail
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr["shoes_name"].ToString());
                    if (dr["shoes_name"].ToString() != null)
                    {
                        shoes_name = dr["shoes_name"].ToString();
                    }
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
            return shoes_name;
        }

        private int getBill_id(string name) //get bill_id
        {
            int bill_id = 0;
            string query = "select * from bill where guest_name = N'" +name+ "'";
            //lấy bill_id cho bảng bill_detail
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr["bill_id"].ToString());
                    if (dr["bill_id"].ToString() != null)
                    {
                        bill_id = Int32.Parse(dr["bill_id"].ToString());
                    }
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
            //MessageBox.Show(bill_id.ToString());
            return bill_id;
        }

        private void insertBill_detail(int bill_id, string shoes_id, string shoes_name, int quantity)
        {
            try
            { 
                string query = "insert into bill_detail values (@bill_id, @id_shoes, @shoes_name, @quantity, @pay )";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                // Tạo một đối tượng Parameter.
                cmd.Parameters.Add("@bill_id", SqlDbType.Int).Value = bill_id;
                cmd.Parameters.Add("@id_shoes", SqlDbType.Char).Value = shoes_id;
                cmd.Parameters.Add("@shoes_name", SqlDbType.NVarChar).Value = shoes_name;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@pay", SqlDbType.Money).Value = 0;
                cmd.ExecuteNonQuery();
                //conn.Close();
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

        private void btn_pay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
