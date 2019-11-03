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
    public partial class f_user : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        string username;
        public f_user()
        {
            InitializeComponent();
        }

        public f_user(string name) : this()
        {
            username = name;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = txt_nameshoes.Text;
            //code tìm kiếm theo tên sản phẩm
            string query = "select * from ds('"+search+"')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            dgvShow.DataSource = dt;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void btn_quantity_Click(object sender, EventArgs e)
        {
            string min = txt_quantity.Text;
            //gọi thủ tục tìm sản phẩm có số lượng < min
            string query = "select * from check_out('"+min+"')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            dgvShow.DataSource = dt;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void f_user_Load(object sender, EventArgs e)
        {
            lb_nameuser.Text = username;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //user view_shoes
            string query = "SELECT * FROM view_shoes";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            dgvShow.DataSource = dt;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            //thanh toán
            f_pay f_pay = new f_pay();
            f_pay.ShowDialog();
        }
    }
}
