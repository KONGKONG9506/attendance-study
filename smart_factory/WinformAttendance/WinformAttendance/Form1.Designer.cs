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
            this.btn출석날짜 = new System.Windows.Forms.Label();
            this.dateTimePicker출석일 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn기간통계조회 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker종료일 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker시작일 = new System.Windows.Forms.DateTimePicker();
            this.listview출석목록 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn출석목록 = new System.Windows.Forms.Label();
            this.btn출석조회 = new System.Windows.Forms.Button();
            this.dataGridView기간통계 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAttend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView기간통계)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "출석상태:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combobox학생
            // 
            this.combobox학생.FormattingEnabled = true;
            this.combobox학생.Location = new System.Drawing.Point(118, 16);
            this.combobox학생.Name = "combobox학생";
            this.combobox학생.Size = new System.Drawing.Size(272, 23);
            this.combobox학생.TabIndex = 4;
            // 
            // combobox출석상태
            // 
            this.combobox출석상태.FormattingEnabled = true;
            this.combobox출석상태.Location = new System.Drawing.Point(118, 107);
            this.combobox출석상태.Name = "combobox출석상태";
            this.combobox출석상태.Size = new System.Drawing.Size(272, 23);
            this.combobox출석상태.TabIndex = 5;
            // 
            // btn출석저장
            // 
            this.btn출석저장.BackColor = System.Drawing.Color.White;
            this.btn출석저장.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn출석저장.Location = new System.Drawing.Point(60, 291);
            this.btn출석저장.Name = "btn출석저장";
            this.btn출석저장.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn출석저장.Size = new System.Drawing.Size(330, 157);
            this.btn출석저장.TabIndex = 6;
            this.btn출석저장.Text = "출석 저장";
            this.btn출석저장.UseVisualStyleBackColor = false;
            this.btn출석저장.Click += new System.EventHandler(this.btn출석저장_Click);
            // 
            // btn출석날짜
            // 
            this.btn출석날짜.AutoSize = true;
            this.btn출석날짜.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn출석날짜.Location = new System.Drawing.Point(15, 211);
            this.btn출석날짜.Name = "btn출석날짜";
            this.btn출석날짜.Size = new System.Drawing.Size(103, 28);
            this.btn출석날짜.TabIndex = 10;
            this.btn출석날짜.Text = "출석 날짜:";
            // 
            // dateTimePicker출석일
            // 
            this.dateTimePicker출석일.Location = new System.Drawing.Point(118, 214);
            this.dateTimePicker출석일.Name = "dateTimePicker출석일";
            this.dateTimePicker출석일.Size = new System.Drawing.Size(272, 25);
            this.dateTimePicker출석일.TabIndex = 11;
            this.dateTimePicker출석일.Value = new System.DateTime(2025, 6, 2, 19, 43, 38, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 530);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker출석일);
            this.tabPage1.Controls.Add(this.combobox학생);
            this.tabPage1.Controls.Add(this.btn출석날짜);
            this.tabPage1.Controls.Add(this.combobox출석상태);
            this.tabPage1.Controls.Add(this.btn출석저장);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "출석";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listview출석목록);
            this.tabPage2.Controls.Add(this.btn출석목록);
            this.tabPage2.Controls.Add(this.btn출석조회);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "출석조회";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView기간통계);
            this.tabPage3.Controls.Add(this.btn기간통계조회);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dateTimePicker종료일);
            this.tabPage3.Controls.Add(this.dateTimePicker시작일);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(444, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "출석통계";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn기간통계조회
            // 
            this.btn기간통계조회.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn기간통계조회.Location = new System.Drawing.Point(156, 127);
            this.btn기간통계조회.Name = "btn기간통계조회";
            this.btn기간통계조회.Size = new System.Drawing.Size(134, 36);
            this.btn기간통계조회.TabIndex = 30;
            this.btn기간통계조회.Text = "기간통계조회";
            this.btn기간통계조회.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "종료일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "시작일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker종료일
            // 
            this.dateTimePicker종료일.Location = new System.Drawing.Point(84, 85);
            this.dateTimePicker종료일.Name = "dateTimePicker종료일";
            this.dateTimePicker종료일.Size = new System.Drawing.Size(306, 25);
            this.dateTimePicker종료일.TabIndex = 27;
            // 
            // dateTimePicker시작일
            // 
            this.dateTimePicker시작일.Location = new System.Drawing.Point(84, 18);
            this.dateTimePicker시작일.Name = "dateTimePicker시작일";
            this.dateTimePicker시작일.Size = new System.Drawing.Size(306, 25);
            this.dateTimePicker시작일.TabIndex = 26;
            // 
            // listview출석목록
            // 
            this.listview출석목록.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listview출석목록.FullRowSelect = true;
            this.listview출석목록.HideSelection = false;
            this.listview출석목록.Location = new System.Drawing.Point(28, 55);
            this.listview출석목록.Name = "listview출석목록";
            this.listview출석목록.Size = new System.Drawing.Size(391, 327);
            this.listview출석목록.TabIndex = 15;
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
            // btn출석목록
            // 
            this.btn출석목록.AutoSize = true;
            this.btn출석목록.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn출석목록.Location = new System.Drawing.Point(170, 13);
            this.btn출석목록.Name = "btn출석목록";
            this.btn출석목록.Size = new System.Drawing.Size(99, 28);
            this.btn출석목록.TabIndex = 14;
            this.btn출석목록.Text = "출석 목록";
            // 
            // btn출석조회
            // 
            this.btn출석조회.BackColor = System.Drawing.Color.White;
            this.btn출석조회.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn출석조회.Location = new System.Drawing.Point(150, 418);
            this.btn출석조회.Name = "btn출석조회";
            this.btn출석조회.Size = new System.Drawing.Size(143, 69);
            this.btn출석조회.TabIndex = 13;
            this.btn출석조회.Text = "출석 조회";
            this.btn출석조회.UseVisualStyleBackColor = false;
            // 
            // dataGridView기간통계
            // 
            this.dataGridView기간통계.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView기간통계.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColAttend,
            this.ColLate,
            this.ColAbsent,
            this.ColLeave,
            this.ColRate});
            this.dataGridView기간통계.Location = new System.Drawing.Point(11, 182);
            this.dataGridView기간통계.Name = "dataGridView기간통계";
            this.dataGridView기간통계.RowHeadersWidth = 51;
            this.dataGridView기간통계.RowTemplate.Height = 27;
            this.dataGridView기간통계.Size = new System.Drawing.Size(427, 308);
            this.dataGridView기간통계.TabIndex = 31;
            this.dataGridView기간통계.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView기간통계_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "이름";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.Width = 60;
            // 
            // ColAttend
            // 
            this.ColAttend.HeaderText = "출석";
            this.ColAttend.MinimumWidth = 6;
            this.ColAttend.Name = "ColAttend";
            this.ColAttend.Width = 60;
            // 
            // ColLate
            // 
            this.ColLate.HeaderText = "지각";
            this.ColLate.MinimumWidth = 6;
            this.ColLate.Name = "ColLate";
            this.ColLate.Width = 60;
            // 
            // ColAbsent
            // 
            this.ColAbsent.HeaderText = "결석";
            this.ColAbsent.MinimumWidth = 6;
            this.ColAbsent.Name = "ColAbsent";
            this.ColAbsent.Width = 60;
            // 
            // ColLeave
            // 
            this.ColLeave.HeaderText = "조퇴";
            this.ColLeave.MinimumWidth = 6;
            this.ColLeave.Name = "ColLeave";
            this.ColLeave.Width = 60;
            // 
            // ColRate
            // 
            this.ColRate.HeaderText = "출석률";
            this.ColRate.MinimumWidth = 6;
            this.ColRate.Name = "ColRate";
            this.ColRate.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView기간통계)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox학생;
        private System.Windows.Forms.ComboBox combobox출석상태;
        private System.Windows.Forms.Button btn출석저장;
        private System.Windows.Forms.Label btn출석날짜;
        private System.Windows.Forms.DateTimePicker dateTimePicker출석일;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listview출석목록;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label btn출석목록;
        private System.Windows.Forms.Button btn출석조회;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn기간통계조회;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker종료일;
        private System.Windows.Forms.DateTimePicker dateTimePicker시작일;
        private System.Windows.Forms.DataGridView dataGridView기간통계;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAttend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRate;
    }
}

