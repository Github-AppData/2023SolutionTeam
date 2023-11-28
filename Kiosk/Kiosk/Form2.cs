using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kiosk
{
    public partial class Form2 : Form
    {
        // Mysql 관련 설정
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;" +
                                                    "Database=PointOfSalesDB" +
                                                    "Uid=root" +
                                                    "Pwd=12345");

        // 폼이 표시되기 이 전에 발생한다.
        // - 데이터를 셋 하는 과정
        private void Form2_Load(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select * from menu order by idx;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
