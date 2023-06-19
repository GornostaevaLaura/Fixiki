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
    public partial class choice6 : Form
    {
        public choice6()
        {
            InitializeComponent();
        }

        private void choice6_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "u - доля водоразборных колонок, имеющих утечки в долях единиц");
            toolTip2.SetToolTip(label3, "n - общее количество водоразборных колонок");
            toolTip3.SetToolTip(label4, "q - средний расход при утечке через водоразборную колонку (куб. м/сутки).\n При отсутствии фактических данных допускается принимать\nq = 0.25 л/сек;\nq = 21.6 м3/сут;\n");
            toolTip4.SetToolTip(label5, "z - расчетный период (количество суток).");
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
