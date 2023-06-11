using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 재고관리
{
    public partial class Form1 : Form
    {
        List<제품정보> 제품리스트 = new List<제품정보>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "재고관리";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            dateTimePicker2.Value = DateTime.Today;
       
            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;

            timer2.Interval = 100; //타이머 간격 100ms
            timer2.Start();
        }
       

        private void 추가_Click(object sender, EventArgs e)
        {
           
            try
            {
                string 제품명 = this.제품명.Text;
                int 수량 = Convert.ToInt32(this.수량.Text);
                string 유통기한 = this.유통기한.Text;
                제품정보 제품 = new 제품정보(제품명, 수량, 유통기한);
                제품리스트.Add(제품);
            }
            catch {
                MessageBox.Show("올바른 정보를 입력해주세요");
            };
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = 제품리스트;

            this.제품명.Text = "";
            this.수량.Text = "";
            this.유통기한.Text = "";

        }

        private void 검색_Click(object sender, EventArgs e)
        {
            string 검색어 = this.검색글자.Text;

            List<제품정보> 검색결과 = 제품리스트.Where(제품 => 제품.제품명.Contains(검색어)).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = 검색결과;
        }

        private void 이름정렬_Click(object sender, EventArgs e)
        {
            List<제품정보> 정렬결과 = 제품리스트.OrderBy(제품 => 제품.제품명).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = 정렬결과;
        }

        private void 날짜정렬_Click(object sender, EventArgs e)
        {
            List<제품정보> 정렬결과 = 제품리스트.OrderBy(제품 => 제품.유통기한).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = 정렬결과;
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int 선택된인덱스 = dataGridView1.SelectedRows[0].Index;
                제품리스트.RemoveAt(선택된인덱스);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = 제품리스트;
            }
        }

        private void 전체삭제_Click(object sender, EventArgs e)
        {
            제품리스트.Clear();
            dataGridView1.DataSource = null;
        }
        private void 수정_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 선택된 행의 정보를 텍스트 상자에 입력
                selectedRow.Cells["제품명"].Value= 제품명.Text;
                selectedRow.Cells["수량"].Value = int.Parse(수량.Text);
                selectedRow.Cells["유통기한"].Value = 유통기한.Text;

                Console.WriteLine(selectedRow.Cells["제품명"].Value.ToString());
                Console.WriteLine(selectedRow.Cells["수량"].Value.ToString());
                Console.WriteLine(selectedRow.Cells["유통기한"].Value.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class 제품정보
    {
        public string 제품명 { get; set; }
        public int 수량 { get; set; }
        public string 유통기한 { get; set; }

        public 제품정보(string 제품명, int 수량, string 유통기한)
        {
            this.제품명 = 제품명;
            this.수량 = 수량;
            this.유통기한 = 유통기한;
        }
    }
}
