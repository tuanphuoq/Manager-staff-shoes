using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQT
{
    public partial class f_main : Form
    {
        string user_name;
        int user_level;
        
        public f_main()
        {
            InitializeComponent();
        }
        public f_main (string name, int level) : this()
        {
            user_name = name;
            user_level = level;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            f_admin f_admin = new f_admin();
            f_admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_manager f_manager = new f_manager(user_name);
            f_manager.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_user f_user = new f_user(user_name);
            f_user.ShowDialog();
        }

        private void f_main_Load(object sender, EventArgs e)
        {
            if(user_level == 3)
            {
                btn_admin.Enabled = false;
                btn_manager.Enabled = false;
            }
            else if(user_level == 2)
            {
                btn_admin.Enabled = false;
            }
            else
            {

            }
        }
    }
}
