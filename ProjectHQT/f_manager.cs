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
    public partial class f_manager : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GULEP1A;Initial Catalog=SHOES_STORE;Integrated Security=True");
        string username;
        public f_manager()
        {
            InitializeComponent();
        }

        public f_manager(string name) : this()
        {
            username = name;
        }
        private void btn_store_Click(object sender, EventArgs e)
        {
            f_store f_store = new f_store();
            f_store.ShowDialog();
        }

        private void btn_delshoes_Click(object sender, EventArgs e)
        {
            //code trigger xóa sản phârm

        }

        private void f_manager_Load(object sender, EventArgs e)
        {
            lb_nameuser.Text = username;
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            string query = "SELECT id_shoes, shoes_name, cost, quantity, brand_name FROM shoes, brand WHERE shoes.id_brand = brand.id_brand";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();

            da.Fill(dt);
            dgvShoes.DataSource = dt;
            dgvShoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conn.Close();
        }
    }
}
