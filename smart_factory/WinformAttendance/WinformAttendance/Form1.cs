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
                SELECT s.name, a.status
                FROM attendance a
                JOIN students s ON a.student_id = s.student_id
                WHERE a.date = CURDATE()";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                listBox출석목록.Items.Clear();

                while (reader.Read()) 
                { 
                    string line = $"{reader["name"]} - { reader["status"]}";
                    listBox출석목록.Items.Add(line);
                }

                reader.Close();
            }
        }
    }
}
