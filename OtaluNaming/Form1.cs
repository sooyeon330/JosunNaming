using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtaluNaming
{
    public partial class Form1 : Form
    {
        private string Dname;
        private string Mname;

        public Form1()
        {
            InitializeComponent();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.m1.Checked) Mname = "웅";
            else if (this.m2.Checked) Mname = "쇠";
            else if (this.m3.Checked) Mname = "돌";
            else if (this.m4.Checked) Mname = "만";
            else if (this.m5.Checked) Mname = "용";
            else if (this.m6.Checked) Mname = "육";
            else if (this.m7.Checked) Mname = "칠";
            else if (this.m8.Checked) Mname = "쌍";
            else if (this.m9.Checked) Mname = "삼";
            else if (this.m10.Checked) Mname = "언";
            else if (this.m11.Checked) Mname = "개";
            else if (this.m12.Checked) Mname = "순";

            if (this.d1.Checked) Dname = "식";
            else if (this.d2.Checked) Dname = "구";
            else if (this.d3.Checked) Dname = "삼";
            else if (this.d4.Checked) Dname = "석";
            else if (this.d5.Checked) Dname = "놈";
            else if (this.d6.Checked) Dname = "년";
            else if (this.d7.Checked) Dname = "꽃";
            else if (this.d8.Checked) Dname = "돌";
            else if (this.d9.Checked) Dname = "민";
            else if (this.d10.Checked) Dname = "것";
            else if (this.d11.Checked) Dname = "돌";
            else if (this.d12.Checked) Dname = "복";
            else if (this.d13.Checked) Dname = "단";
            else if (this.d14.Checked) Dname = "냥";
            else if (this.d15.Checked) Dname = "똥";
            else if (this.d16.Checked) Dname = "갑";
            else if (this.d17.Checked) Dname = "숙";
            else if (this.d18.Checked) Dname = "단";
            else if (this.d19.Checked) Dname = "창";
            else if (this.d20.Checked) Dname = "박";
            else if (this.d21.Checked) Dname = "손";
            else if (this.d22.Checked) Dname = "룡";
            else if (this.d23.Checked) Dname = "방";
            else if (this.d24.Checked) Dname = "득";
            else if (this.d25.Checked) Dname = "국";
            else if (this.d26.Checked) Dname = "포";
            else if (this.d27.Checked) Dname = "래";
            else if (this.d28.Checked) Dname = "걸";
            else if (this.d29.Checked) Dname = "양";
            else if (this.d30.Checked) Dname = "정";
            else if (this.d31.Checked) Dname = "슴";

            MessageBox.Show("당신의 이름은? " + Mname + " " + Dname, "결과");

        }
    }
}
