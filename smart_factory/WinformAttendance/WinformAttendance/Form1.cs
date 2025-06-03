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

namespace WinformAttendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                cmd.Parameters.AddWithValue("@selectedDate", dateTimePicker출석일.Value.Date);
                MySqlDataReader reader = cmd.ExecuteReader();

                listview출석목록.Items.Clear();

                bool hasRows = false;

                while (reader.Read()) 
                {

                    hasRows = true;

                    string name = reader["name"].ToString();
                    string status = reader["status"].ToString();
                    string date = Convert.ToDateTime(reader["date"]).ToString("yyyy-mm-dd");

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


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
