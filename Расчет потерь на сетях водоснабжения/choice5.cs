using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расчет_потерь_на_сетях_водоснабжения
{
    public partial class choice5 : Form
    {
        public choice5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void choice5_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "u - доля арматуры, имеющей утечки в долях единиц");
            toolTip2.SetToolTip(label3, "n - общее количество сетевой арматуры");
            toolTip3.SetToolTip(label4, "q - средний расход при утечке через уплотнения сетевой арматуры (куб. м/сутки); \n При отсутствии фактических данных средний расход при утечке через уплотнения сетевой арматуры допускается принимать\n равным 4,3 куб. м/сутки на 1 ед. сетевой арматуры, равным 0,02;");
            toolTip3.SetToolTip(label5, "z - расчетный период (количество суток).");
        }
        public string[] ReturnData()
        {
            string[] mas = new string[4];
            mas[0] = textBox1.Text;
            mas[1] = textBox2.Text;
            mas[2] = textBox3.Text;
            mas[3] = textBox4.Text;


            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
