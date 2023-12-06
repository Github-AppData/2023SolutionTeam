using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class Form4 : Form
    {
        // Mysql 관련 설정
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;" +
                                                    "Database=PointOfSalesDB;" +
                                                    "Uid=root;" +
                                                    "Pwd=1234;");

        ListViewItem clickedItem;
        string nameStringValue;
        string priceStringValue;

        // "수량" 컬럼의 인덱스를 지정 (예를 들어, 3번째 컬럼이라면 2를 사용)
        int nameColumnIndex = 0;
        // "수량" 컬럼의 인덱스를 지정 (예를 들어, 3번째 컬럼이라면 2를 사용)
        int priceColumnIndex = 1;

        int pricevalue_admin = 0;

        string idx;

        private void Form4_Load(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select name, price from coffee order by idx;";
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                int buttonIndex = 1;
                var i = 0;

                // 여러 값을 저장할 리스트
                List<string[]> listViewItems = new List<string[]>();
                listViewItems.Clear();

                // 데이터가 없을 때까지 Read 된다.
                while (table.Read())
                {

                    string nameValue = " ";
                    string priceValue = " ";

                    nameValue = table["name"].ToString();
                    priceValue = table["price"].ToString();

                    try
                    {
                        // 각각의 값을 배열에 저장
                        var listViewArray = new string[] { nameValue, priceValue };

                        // ListViewItem 생성 및 각 컬럼 값 추가
                        var listViewItem = new ListViewItem(listViewArray);

                        // ListView에 아이템 추가
                        listView.Items.Add(listViewItem);
                    }

                    catch (ArgumentOutOfRangeException ex)
                    {
                        // 예외 처리 로직
                        Console.WriteLine($"ListView에 아이템 추가 중 오류: {ex.Message}");
                    }
                }

                table.Close();

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        

        public Form4()
        {
            InitializeComponent();
        }

        private void selectkindof_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 아이템이 변경될 때 수행할 동작
            string selectedValue = selectkindof.SelectedItem.ToString();

            string menuAllselectQuery = "select name, price from "+ selectedValue + " order by idx;";
            conn.Open();

            listView.Items.Clear();

            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                // 여러 값을 저장할 리스트
                List<string[]> listViewItems = new List<string[]>();
                listViewItems.Clear();

                // 데이터가 없을 때까지 Read 된다.
                while (table.Read())
                {

                    string nameValue = " ";
                    string priceValue = " ";

                    nameValue = table["name"].ToString();
                    priceValue = table["price"].ToString();

                    try
                    {
                        // 각각의 값을 배열에 저장
                        var listViewArray = new string[] { nameValue, priceValue };

                        // ListViewItem 생성 및 각 컬럼 값 추가
                        var listViewItem = new ListViewItem(listViewArray);

                        // ListView에 아이템 추가
                        listView.Items.Add(listViewItem);
                    }

                    catch (ArgumentOutOfRangeException ex)
                    {
                        // 예외 처리 로직
                        Console.WriteLine($"ListView에 아이템 추가 중 오류: {ex.Message}");
                    }
                }
                table.Close();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void listView_MouseDown(object sender, MouseEventArgs e)
        {

            // 마우스 오른쪽 버튼 클릭인지 확인
            if (e.Button == MouseButtons.Left)
            {

                // 마우스 클릭한 위치의 아이템과 서브아이템 인덱스 가져오기
                clickedItem = listView.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    // 컬럼 인덱스를 사용하여 수량 값을 가져오기
                    nameStringValue = clickedItem.SubItems[nameColumnIndex].Text;
                    priceStringValue = clickedItem.SubItems[priceColumnIndex].Text;

                    // text 셋 하는 것
                    crudtext.Text = nameStringValue;
                    crudtext2.Text = priceStringValue;

                    // 콤보박스, 버튼 비활성화
                    crudCombo.Enabled = false;
                    btnInsert.Enabled = false;
                }
            }

            // 선택한 아이템의 기본키인 idx 값 구하기
            string table_name = selectkindof.Text;
            Console.WriteLine(table_name);
            Console.WriteLine(nameStringValue);
            string menuselectQuery = "SELECT idx FROM " + table_name + " WHERE name = '" + nameStringValue.Replace("'", "''") + "';";



            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(menuselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    idx = table["idx"].ToString();
                }

                table.Close(); 
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close( );
            }
        }



        private void crudtext_TextChanged(object sender, EventArgs e)
        {
            // crudtext에 텍스트가 없다면,,,
            if (string.IsNullOrWhiteSpace(crudtext.Text))
            {
                // 콤보박스, 버튼 활성화
                crudCombo.Enabled = true;
                btnInsert.Enabled = true;
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {

            // 선택된 아이템이 변경될 때 수행할 동작
            string selectedValue = selectkindof.SelectedItem.ToString();

            string re_name = crudtext.Text;
            string re_price = crudtext2.Text;

            string table_name = selectkindof.Text;

            string menuUpdateQuery = "UPDATE " + table_name + " SET name = '" + re_name + "', price = " + re_price + " WHERE idx = " + idx + ";";

            conn.Open();

            listView.Items.Clear();

            try
            {
                MySqlCommand cmd = new MySqlCommand(menuUpdateQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                MessageBox.Show("수정완료");
                table.Close();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 아이템이 변경될 때 수행할 동작
            string selectedValue = selectkindof.SelectedItem.ToString();
            string table_name = selectkindof.Text;

            string menuDeleteQuery = "DELETE FROM " + table_name + " WHERE idx = '" + idx + "';";


            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(menuDeleteQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                MessageBox.Show("삭제 완료");
                table.Close();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 선택된 아이템이 변경될 때 수행할 동작
            //string selectedValue = selectkindof.SelectedItem.ToString();

            string in_name = crudtext.Text;
            string in_price = crudtext2.Text;

            string table_name = crudCombo.Text;

            conn.Open();

            // string insertQuery = "INSERT INTO " + table_name + " (name, price) VALUES ("+ in_name + ","+ in_price + ")"+";";
            string insertQuery = "INSERT INTO " + table_name + " (name, price) VALUES ('" + menuName + "', " + menuPrice + ");";

            try
            {
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                MessageBox.Show("등록완료");

                table.Close();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
