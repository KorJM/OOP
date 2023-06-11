namespace 재고관리
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.제품명 = new System.Windows.Forms.TextBox();
            this.수량 = new System.Windows.Forms.TextBox();
            this.유통기한 = new System.Windows.Forms.TextBox();
            this.추가 = new System.Windows.Forms.Button();
            this.검색글자 = new System.Windows.Forms.TextBox();
            this.검색 = new System.Windows.Forms.Button();
            this.이름정렬 = new System.Windows.Forms.Button();
            this.날짜정렬 = new System.Windows.Forms.Button();
            this.삭제 = new System.Windows.Forms.Button();
            this.전체삭제 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(586, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // 제품명
            // 
            this.제품명.Location = new System.Drawing.Point(12, 69);
            this.제품명.Name = "제품명";
            this.제품명.Size = new System.Drawing.Size(100, 21);
            this.제품명.TabIndex = 1;
            // 
            // 수량
            // 
            this.수량.Location = new System.Drawing.Point(139, 69);
            this.수량.Name = "수량";
            this.수량.Size = new System.Drawing.Size(100, 21);
            this.수량.TabIndex = 2;
            // 
            // 유통기한
            // 
            this.유통기한.Location = new System.Drawing.Point(266, 69);
            this.유통기한.Name = "유통기한";
            this.유통기한.Size = new System.Drawing.Size(100, 21);
            this.유통기한.TabIndex = 3;
            // 
            // 추가
            // 
            this.추가.Location = new System.Drawing.Point(394, 69);
            this.추가.Name = "추가";
            this.추가.Size = new System.Drawing.Size(75, 23);
            this.추가.TabIndex = 4;
            this.추가.Text = "추가";
            this.추가.UseVisualStyleBackColor = true;
            this.추가.Click += new System.EventHandler(this.추가_Click);
            // 
            // 검색글자
            // 
            this.검색글자.Location = new System.Drawing.Point(12, 23);
            this.검색글자.Name = "검색글자";
            this.검색글자.Size = new System.Drawing.Size(100, 21);
            this.검색글자.TabIndex = 5;
            // 
            // 검색
            // 
            this.검색.Location = new System.Drawing.Point(130, 23);
            this.검색.Name = "검색";
            this.검색.Size = new System.Drawing.Size(75, 23);
            this.검색.TabIndex = 6;
            this.검색.Text = "검색";
            this.검색.UseVisualStyleBackColor = true;
            this.검색.Click += new System.EventHandler(this.검색_Click);
            // 
            // 이름정렬
            // 
            this.이름정렬.Location = new System.Drawing.Point(220, 23);
            this.이름정렬.Name = "이름정렬";
            this.이름정렬.Size = new System.Drawing.Size(75, 23);
            this.이름정렬.TabIndex = 7;
            this.이름정렬.Text = "이름정렬";
            this.이름정렬.UseVisualStyleBackColor = true;
            this.이름정렬.Click += new System.EventHandler(this.이름정렬_Click);
            // 
            // 날짜정렬
            // 
            this.날짜정렬.Location = new System.Drawing.Point(301, 23);
            this.날짜정렬.Name = "날짜정렬";
            this.날짜정렬.Size = new System.Drawing.Size(75, 23);
            this.날짜정렬.TabIndex = 8;
            this.날짜정렬.Text = "날짜정렬";
            this.날짜정렬.UseVisualStyleBackColor = true;
            this.날짜정렬.Click += new System.EventHandler(this.날짜정렬_Click);
            // 
            // 삭제
            // 
            this.삭제.Location = new System.Drawing.Point(382, 23);
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(75, 23);
            this.삭제.TabIndex = 9;
            this.삭제.Text = "삭제";
            this.삭제.UseVisualStyleBackColor = true;
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // 전체삭제
            // 
            this.전체삭제.Location = new System.Drawing.Point(463, 23);
            this.전체삭제.Name = "전체삭제";
            this.전체삭제.Size = new System.Drawing.Size(135, 23);
            this.전체삭제.TabIndex = 10;
            this.전체삭제.Text = "전체 삭제";
            this.전체삭제.UseVisualStyleBackColor = true;
            this.전체삭제.Click += new System.EventHandler(this.전체삭제_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 691);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 21);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "재고이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "수량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "유통기한";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 697);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "검색";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "나가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.전체삭제);
            this.Controls.Add(this.삭제);
            this.Controls.Add(this.날짜정렬);
            this.Controls.Add(this.이름정렬);
            this.Controls.Add(this.검색);
            this.Controls.Add(this.검색글자);
            this.Controls.Add(this.추가);
            this.Controls.Add(this.유통기한);
            this.Controls.Add(this.수량);
            this.Controls.Add(this.제품명);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "체중관리프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox 제품명;
        private System.Windows.Forms.TextBox 수량;
        private System.Windows.Forms.TextBox 유통기한;
        private System.Windows.Forms.Button 추가;
        private System.Windows.Forms.TextBox 검색글자;
        private System.Windows.Forms.Button 검색;
        private System.Windows.Forms.Button 이름정렬;
        private System.Windows.Forms.Button 날짜정렬;
        private System.Windows.Forms.Button 삭제;
        private System.Windows.Forms.Button 전체삭제;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}
