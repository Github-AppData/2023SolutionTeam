using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                                                    "Database=PointOfSalesDB;" +
                                                    "Uid=root;" +
                                                    "Pwd=1234;");
        MySqlCommand cmd;
        // 폼이 표시되기 이 전에 발생한다.
        // - 데이터를 셋 하는 과정
        private void Form2_Load(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select name from coffee order by idx;";
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                int buttonIndex = 1;

                // 데이터가 없을 때까지 Read 된다.
                while (table.Read())
                {
                    // 기존에 만들어진 버튼을 찾음
                    Button btn = this.Controls.Find("btn" + buttonIndex.ToString(), true).FirstOrDefault() as Button;

                    if (btn != null)
                    {
                        // 버튼 텍스트 설정
                        btn.Text = table["name"].ToString();

                        // 버튼 이벤트 핸들러 등록
                        btn.Click += new EventHandler(btn_click);

                        // 다음 버튼을 위해 인덱스 증가
                        buttonIndex++;
                    }
                }

                table.Close();

                // kindOf_1btn, kindOf_2btn, kindOf_3btn Setting
                kindOf_1btn.Text = "coffee";
                kindOf_2btn.Text = "tea";
                kindOf_3btn.Text = "desert";
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

        public Form2()
        {
            InitializeComponent();
        }

        


        
        private void btn_click(object sender, EventArgs e)
        {
            // 이벤트가 발생한 버튼을 확인합니다.
            Button clickedButton = sender as Button;

            /*if (clickedButton != null)
            {
                // 버튼에 대한 추가 작업을 수행합니다.
                MessageBox.Show($"버튼 '{clickedButton.Text}'이(가) 눌렸습니다.");
            }*/

            string menuNameselectQuery = "select name, quantity, price from coffee where name = @name;";

            try
            {
                conn.Open();
                // MySqlCommand에 매개변수 추가
                using (MySqlCommand cmd2 = new MySqlCommand(menuNameselectQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("@name", clickedButton.Text);

                    Console.WriteLine(clickedButton.Text);
                    
                    using(MySqlDataReader table = cmd2.ExecuteReader())
                    {
                        // 여러 값을 저장할 리스트
                        List<string[]> listViewItems = new List<string[]>();
                        listViewItems.Clear();

                        while (table.Read())
                        {
                            string nameValue = table["name"].ToString();
                            // Console.WriteLine("nameValue : " + nameValue);
                            string quanValue = table["quantity"].ToString();
                            string priceValue = table["price"].ToString();
                            
                                try
                                {
                                    // 각각의 값을 배열에 저장
                                    var listViewArray = new string[] { nameValue, quanValue, priceValue };

                                    // ListViewItem 생성 및 각 컬럼 값 추가
                                    var listViewItem = new ListViewItem(listViewArray);

                                    // ListView에 아이템 추가
                                    OrderListView.Items.Add(listViewItem);
                                } catch (ArgumentOutOfRangeException ex)
                                {
                                    // 예외 처리 로직
                                    Console.WriteLine($"ListView에 아이템 추가 중 오류: {ex.Message}");
                                }
                              
                        }
                        table.Close();
                    }
                }
               
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
        private void kindof2_btn_click(object sender, EventArgs e)
        {

        }


        private void kindof3_btn_click(object sender, EventArgs e)
        {
            string menuAllDesertselectQuery = "select name from desert order by idx;";

            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllDesertselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                int buttonIndex = 1;

                // 데이터가 없을 때까지 Read 된다.
                while (table.Read())
                {
                    // 기존에 만들어진 버튼을 찾음
                    Button btn = this.Controls.Find("btn" + buttonIndex.ToString(), true).FirstOrDefault() as Button;

                    if (btn != null)
                    {
                        // 버튼 텍스트 설정
                        btn.Text = table["name"].ToString();

                        // 버튼 이벤트 핸들러 등록
                        //btn.Click += new EventHandler(btn_click);

                        // 다음 버튼을 위해 인덱스 증가
                        buttonIndex++;
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
        private void kindof1_btn_click(object sender, EventArgs e)
        {
            string menuAllselectQuery = "select name from coffee order by idx;";
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(menuAllselectQuery, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                int buttonIndex = 1;

                // 데이터가 없을 때까지 Read 된다.
                while (table.Read())
                {
                    // 기존에 만들어진 버튼을 찾음
                    Button btn = this.Controls.Find("btn" + buttonIndex.ToString(), true).FirstOrDefault() as Button;

                    if (btn != null)
                    {
                        // 버튼 텍스트 설정
                        btn.Text = table["name"].ToString();

                        // 다음 버튼을 위해 인덱스 증가
                        buttonIndex++;
                    }
                }
            }
            catch(MySqlException)
            {

            }finally
            {
                conn.Close();
            }
            
        }

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
