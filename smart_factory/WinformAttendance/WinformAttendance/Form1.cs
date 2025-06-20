﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinformAttendance
{
    public partial class Form1 : Form
    {
        private string currentUser;
        private string currentRole;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public Form1(string username, string role)
        {
            InitializeComponent();
            currentUser = username;
            currentRole = role;

            this.FormClosed += Form1_FormClosed;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // 권한에 따라 UI 조정
            if (currentRole == "student")
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
            string connStr = "server=localhost;user=root;password=0000;database=attendance_project;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT student_id, name from students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                combobox학생.DataSource = dt;
                combobox학생.DisplayMember = "name";
                combobox학생.ValueMember = "student_id";
            }
            combobox출석상태.Items.AddRange(new string[] { "출석", "지각", "결석", "조퇴" });
            combobox출석상태.SelectedIndex = 0;
        }

        private void btn출석저장_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=0000;database=attendance_project;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO attendance (student_id, date, status) VALUES (@studentId, CURDATE(), @status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int studentid = Convert.ToInt32(combobox학생.SelectedValue);
                string status = combobox출석상태.SelectedItem.ToString();

                cmd.Parameters.AddWithValue("@studentId", studentid);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

                MessageBox.Show("출석 저장 완료");

            }
        }

        private void btn출석조회_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;password=0000;database=attendance_project;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                SELECT s.name, a.status , a.date
                FROM attendance a
                JOIN students s ON a.student_id = s.student_id
                WHERE a.date = @selectedDate";

                

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@selectedDate", dateTimePicker출석조회일.Value.Date);
                
                MySqlDataReader reader = cmd.ExecuteReader();

                listview출석목록.Items.Clear();

                bool hasRows = false;

                while (reader.Read()) 
                {

                    hasRows = true;

                    string name = reader["name"].ToString();
                    string status = reader["status"].ToString();
                    string date = Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd");

                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(status);
                    item.SubItems.Add(date);

                    if (status == "출석")
                    {
                        item.ForeColor = Color.Green;
                    }
                    else if (status == "결석")
                    {
                        item.ForeColor = Color.Red;
                    }
                    listview출석목록.Items.Add(item);
                }

                reader.Close();

                if (!hasRows)
                {
                    MessageBox.Show("선택할 날짜에 출석 기록이 없습니다.");
                }
            }
        }
        private void btn기간통계조회_Click(object sender, EventArgs e)
        {
            dataGridView기간통계.Rows.Clear();
            string connstr = "server=localhost;user=root;password=0000;database=attendance_project;";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();

                string query = @"
                SELECT s.name,
                       SUM(CASE WHEN a.status ='출석' THEN 1 ELSE 0 END) as 출석수,
                       SUM(CASE WHEN a.status ='지각' THEN 1 ELSE 0 END) as 지각수,
                       SUM(CASE WHEN a.status ='결석' THEN 1 ELSE 0 END) as 결석수,
                       SUM(CASE WHEN a.status ='조퇴' THEN 1 ELSE 0 END) as 조퇴수,
                       COUNT(*) AS 전체기록수
                FROM attendance a
                JOIN students s ON a.student_id = s.student_id
                WHERE a.date BETWEEN @startDate AND @endDate
                GROUP BY s.name";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker시작일.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker종료일.Value.Date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            int 출석 = Convert.ToInt32(reader["출석수"]);
                            int 지각 = Convert.ToInt32(reader["지각수"]);
                            int 결석 = Convert.ToInt32(reader["결석수"]);
                            int 조퇴 = Convert.ToInt32(reader["조퇴수"]);
                            int 전체 = Convert.ToInt32(reader["전체기록수"]);

                            double 출석률 = (전체 > 0) ? (출석 / (double)전체) * 100.0 : 0.0;
                            string 출석률표시 = 출석률.ToString("0.0") + "%";

                            //ListViewItem item = new ListViewItem(name);
                            //item.SubItems.Add(출석.ToString());
                            //item.SubItems.Add(지각.ToString());
                            //item.SubItems.Add(결석.ToString());
                            //item.SubItems.Add(조퇴.ToString());
                            //item.SubItems.Add(출석률표시);

                            int rowIndex = dataGridView기간통계.Rows.Add(name, 출석, 지각, 결석, 조퇴, 출석률표시);

                            if (출석률 >= 90)
                                dataGridView기간통계.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                            else if (출석률 >= 75)
                                dataGridView기간통계.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Orange;
                            else
                                dataGridView기간통계.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;

                        }

                        //List<ListViewItem> items = listView기간통계조회.Items.Cast<ListViewItem>().ToList();

                        //var sorted = items.OrderByDescending(item =>
                        //{
                        //    string rateText = item.SubItems[5].Text.Replace("%", "");
                        //    return double.Parse(rateText);
                        //}).ToList();

                        //listView기간통계조회.Items.Clear();
                        //listView기간통계조회.Items.AddRange(sorted.ToArray());

                        dataGridView기간통계.Sort(dataGridView기간통계.Columns["ColRate"], ListSortDirection.Descending);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 파일|*.csv";
            saveFileDialog.Title = "출석 통계 CSV 저장";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    // 헤더
                    var headers = dataGridView기간통계.Columns.Cast<DataGridViewColumn>();
                    sw.WriteLine(string.Join(",", headers.Select(col => col.HeaderText)));

                    // 데이터
                    foreach (DataGridViewRow row in dataGridView기간통계.Rows)
                    {
                        if(!row.IsNewRow)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString());
                            sw.WriteLine(string.Join(",", cells));
                        }
                    }
                }
                MessageBox.Show("CSV 저장 완료!");
            }
        }

    }
}
