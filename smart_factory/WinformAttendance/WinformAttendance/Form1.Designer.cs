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
            this.listBox출석목록 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "출석상태:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combobox학생
            // 
            this.combobox학생.FormattingEnabled = true;
            this.combobox학생.Location = new System.Drawing.Point(120, 40);
            this.combobox학생.Name = "combobox학생";
            this.combobox학생.Size = new System.Drawing.Size(200, 23);
            this.combobox학생.TabIndex = 4;
            // 
            // combobox출석상태
            // 
            this.combobox출석상태.FormattingEnabled = true;
            this.combobox출석상태.Location = new System.Drawing.Point(120, 90);
            this.combobox출석상태.Name = "combobox출석상태";
            this.combobox출석상태.Size = new System.Drawing.Size(200, 23);
            this.combobox출석상태.TabIndex = 5;
            // 
            // btn출석저장
            // 
            this.btn출석저장.BackColor = System.Drawing.Color.White;
            this.btn출석저장.Location = new System.Drawing.Point(120, 150);
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
            this.btn출석조회.Location = new System.Drawing.Point(120, 210);
            this.btn출석조회.Name = "btn출석조회";
            this.btn출석조회.Size = new System.Drawing.Size(120, 35);
            this.btn출석조회.TabIndex = 7;
            this.btn출석조회.Text = "출석 조회";
            this.btn출석조회.UseVisualStyleBackColor = false;
            this.btn출석조회.Click += new System.EventHandler(this.btn출석조회_Click);
            // 
            // listBox출석목록
            // 
            this.listBox출석목록.HideSelection = false;
            this.listBox출석목록.Location = new System.Drawing.Point(30, 260);
            this.listBox출석목록.Name = "listBox출석목록";
            this.listBox출석목록.Size = new System.Drawing.Size(320, 120);
            this.listBox출석목록.TabIndex = 8;
            this.listBox출석목록.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.listBox출석목록);
            this.Controls.Add(this.btn출석조회);
            this.Controls.Add(this.btn출석저장);
            this.Controls.Add(this.combobox출석상태);
            this.Controls.Add(this.combobox학생);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox학생;
        private System.Windows.Forms.ComboBox combobox출석상태;
        private System.Windows.Forms.Button btn출석저장;
        private System.Windows.Forms.Button btn출석조회;
        private System.Windows.Forms.ListView listBox출석목록;
    }
}

