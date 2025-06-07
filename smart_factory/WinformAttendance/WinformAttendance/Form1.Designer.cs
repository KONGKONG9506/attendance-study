namespace WinformAttendance
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox학생 = new System.Windows.Forms.ComboBox();
            this.combobox출석상태 = new System.Windows.Forms.ComboBox();
            this.btn출석저장 = new System.Windows.Forms.Button();
            this.btn출석조회 = new System.Windows.Forms.Button();
            this.btn출석목록 = new System.Windows.Forms.Label();
            this.btn출석날짜 = new System.Windows.Forms.Label();
            this.dateTimePicker출석일 = new System.Windows.Forms.DateTimePicker();
            this.listview출석목록 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListView출석통계 = new System.Windows.Forms.ListView();
            this.ListView이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView출석 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView결석 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView지각 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView조퇴 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn출석통계 = new System.Windows.Forms.Button();
            this.dateTimePicker시작일 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker종료일 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn기간통계조회 = new System.Windows.Forms.Button();
            this.listView기간통계조회 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "출석상태:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combobox학생
            // 
            this.combobox학생.FormattingEnabled = true;
            this.combobox학생.Location = new System.Drawing.Point(118, 16);
            this.combobox학생.Name = "combobox학생";
            this.combobox학생.Size = new System.Drawing.Size(200, 23);
            this.combobox학생.TabIndex = 4;
            // 
            // combobox출석상태
            // 
            this.combobox출석상태.FormattingEnabled = true;
            this.combobox출석상태.Location = new System.Drawing.Point(118, 66);
            this.combobox출석상태.Name = "combobox출석상태";
            this.combobox출석상태.Size = new System.Drawing.Size(200, 23);
            this.combobox출석상태.TabIndex = 5;
            // 
            // btn출석저장
            // 
            this.btn출석저장.BackColor = System.Drawing.Color.White;
            this.btn출석저장.Location = new System.Drawing.Point(22, 202);
            this.btn출석저장.Name = "btn출석저장";
            this.btn출석저장.Size = new System.Drawing.Size(120, 35);
            this.btn출석저장.TabIndex = 6;
            this.btn출석저장.Text = "출석 저장";
            this.btn출석저장.UseVisualStyleBackColor = false;
            this.btn출석저장.Click += new System.EventHandler(this.btn출석저장_Click);
            // 
            // btn출석조회
            // 
            this.btn출석조회.BackColor = System.Drawing.Color.White;
            this.btn출석조회.Location = new System.Drawing.Point(22, 258);
            this.btn출석조회.Name = "btn출석조회";
            this.btn출석조회.Size = new System.Drawing.Size(120, 35);
            this.btn출석조회.TabIndex = 7;
            this.btn출석조회.Text = "출석 조회";
            this.btn출석조회.UseVisualStyleBackColor = false;
            this.btn출석조회.Click += new System.EventHandler(this.btn출석조회_Click);
            // 
            // btn출석목록
            // 
            this.btn출석목록.AutoSize = true;
            this.btn출석목록.Location = new System.Drawing.Point(19, 307);
            this.btn출석목록.Name = "btn출석목록";
            this.btn출석목록.Size = new System.Drawing.Size(72, 15);
            this.btn출석목록.TabIndex = 9;
            this.btn출석목록.Text = "출석 목록";
            this.btn출석목록.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn출석날짜
            // 
            this.btn출석날짜.AutoSize = true;
            this.btn출석날짜.Location = new System.Drawing.Point(19, 158);
            this.btn출석날짜.Name = "btn출석날짜";
            this.btn출석날짜.Size = new System.Drawing.Size(77, 15);
            this.btn출석날짜.TabIndex = 10;
            this.btn출석날짜.Text = "출석 날짜:";
            // 
            // dateTimePicker출석일
            // 
            this.dateTimePicker출석일.Location = new System.Drawing.Point(118, 151);
            this.dateTimePicker출석일.Name = "dateTimePicker출석일";
            this.dateTimePicker출석일.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker출석일.TabIndex = 11;
            this.dateTimePicker출석일.Value = new System.DateTime(2025, 6, 2, 19, 43, 38, 0);
            // 
            // listview출석목록
            // 
            this.listview출석목록.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview출석목록.FullRowSelect = true;
            this.listview출석목록.HideSelection = false;
            this.listview출석목록.Location = new System.Drawing.Point(8, 334);
            this.listview출석목록.Name = "listview출석목록";
            this.listview출석목록.Size = new System.Drawing.Size(360, 150);
            this.listview출석목록.TabIndex = 12;
            this.listview출석목록.UseCompatibleStateImageBehavior = false;
            this.listview출석목록.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "출석상태";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출석일";
            this.columnHeader3.Width = 156;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 530);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listview출석목록);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker출석일);
            this.tabPage1.Controls.Add(this.combobox학생);
            this.tabPage1.Controls.Add(this.btn출석날짜);
            this.tabPage1.Controls.Add(this.combobox출석상태);
            this.tabPage1.Controls.Add(this.btn출석목록);
            this.tabPage1.Controls.Add(this.btn출석저장);
            this.tabPage1.Controls.Add(this.btn출석조회);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "출석";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListView출석통계);
            this.tabPage2.Controls.Add(this.Btn출석통계);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "출석통계";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListView출석통계
            // 
            this.ListView출석통계.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListView이름,
            this.ListView출석,
            this.ListView결석,
            this.ListView지각,
            this.ListView조퇴});
            this.ListView출석통계.FullRowSelect = true;
            this.ListView출석통계.GridLines = true;
            this.ListView출석통계.HideSelection = false;
            this.ListView출석통계.Location = new System.Drawing.Point(20, 102);
            this.ListView출석통계.Name = "ListView출석통계";
            this.ListView출석통계.Size = new System.Drawing.Size(336, 362);
            this.ListView출석통계.TabIndex = 1;
            this.ListView출석통계.UseCompatibleStateImageBehavior = false;
            this.ListView출석통계.View = System.Windows.Forms.View.Details;
            this.ListView출석통계.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ListView이름
            // 
            this.ListView이름.Text = "이름";
            this.ListView이름.Width = 82;
            // 
            // ListView출석
            // 
            this.ListView출석.Text = "출석";
            this.ListView출석.Width = 63;
            // 
            // ListView결석
            // 
            this.ListView결석.Text = "결석";
            this.ListView결석.Width = 62;
            // 
            // ListView지각
            // 
            this.ListView지각.Text = "지각";
            this.ListView지각.Width = 65;
            // 
            // ListView조퇴
            // 
            this.ListView조퇴.Text = "조퇴";
            this.ListView조퇴.Width = 73;
            // 
            // Btn출석통계
            // 
            this.Btn출석통계.Location = new System.Drawing.Point(47, 19);
            this.Btn출석통계.Name = "Btn출석통계";
            this.Btn출석통계.Size = new System.Drawing.Size(289, 51);
            this.Btn출석통계.TabIndex = 0;
            this.Btn출석통계.Text = "출석 통계";
            this.Btn출석통계.UseVisualStyleBackColor = true;
            this.Btn출석통계.Click += new System.EventHandler(this.btn출석통계_Click);
            // 
            // dateTimePicker시작일
            // 
            this.dateTimePicker시작일.Location = new System.Drawing.Point(425, 66);
            this.dateTimePicker시작일.Name = "dateTimePicker시작일";
            this.dateTimePicker시작일.Size = new System.Drawing.Size(339, 25);
            this.dateTimePicker시작일.TabIndex = 14;
            this.dateTimePicker시작일.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker종료일
            // 
            this.dateTimePicker종료일.Location = new System.Drawing.Point(422, 143);
            this.dateTimePicker종료일.Name = "dateTimePicker종료일";
            this.dateTimePicker종료일.Size = new System.Drawing.Size(339, 25);
            this.dateTimePicker종료일.TabIndex = 15;
            this.dateTimePicker종료일.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(422, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "시작일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(422, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "종료일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn기간통계조회
            // 
            this.btn기간통계조회.Location = new System.Drawing.Point(422, 191);
            this.btn기간통계조회.Name = "btn기간통계조회";
            this.btn기간통계조회.Size = new System.Drawing.Size(134, 36);
            this.btn기간통계조회.TabIndex = 18;
            this.btn기간통계조회.Text = "기간통계조회";
            this.btn기간통계조회.UseVisualStyleBackColor = true;
            this.btn기간통계조회.Click += new System.EventHandler(this.btn기간통계조회_Click);
            // 
            // listView기간통계조회
            // 
            this.listView기간통계조회.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView기간통계조회.FullRowSelect = true;
            this.listView기간통계조회.GridLines = true;
            this.listView기간통계조회.HideSelection = false;
            this.listView기간통계조회.Location = new System.Drawing.Point(422, 242);
            this.listView기간통계조회.Name = "listView기간통계조회";
            this.listView기간통계조회.Size = new System.Drawing.Size(353, 273);
            this.listView기간통계조회.TabIndex = 19;
            this.listView기간통계조회.UseCompatibleStateImageBehavior = false;
            this.listView기간통계조회.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이름";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "출석";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "지각";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "결석";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "조퇴";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "출석률";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 527);
            this.Controls.Add(this.listView기간통계조회);
            this.Controls.Add(this.btn기간통계조회);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker종료일);
            this.Controls.Add(this.dateTimePicker시작일);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox학생;
        private System.Windows.Forms.ComboBox combobox출석상태;
        private System.Windows.Forms.Button btn출석저장;
        private System.Windows.Forms.Button btn출석조회;
        private System.Windows.Forms.Label btn출석목록;
        private System.Windows.Forms.Label btn출석날짜;
        private System.Windows.Forms.DateTimePicker dateTimePicker출석일;
        private System.Windows.Forms.ListView listview출석목록;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ListView출석통계;
        private System.Windows.Forms.ColumnHeader ListView이름;
        private System.Windows.Forms.ColumnHeader ListView출석;
        private System.Windows.Forms.ColumnHeader ListView지각;
        private System.Windows.Forms.Button Btn출석통계;
        private System.Windows.Forms.ColumnHeader ListView결석;
        private System.Windows.Forms.ColumnHeader ListView조퇴;
        private System.Windows.Forms.DateTimePicker dateTimePicker시작일;
        private System.Windows.Forms.DateTimePicker dateTimePicker종료일;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn기간통계조회;
        private System.Windows.Forms.ListView listView기간통계조회;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

