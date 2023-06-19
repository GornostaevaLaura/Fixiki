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
    public partial class choice7 : Form
    {
        public choice7()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        private void choice7_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "H - средний напор воды принимается равным средней величине напора воды в трубопроводе;");
            toolTip2.SetToolTip(label3, "w -  площадь живого сечения i-го отверстия (кв. м) = PI * d^2 / 4 = 3,14 * 0.0001");
            toolTip3.SetToolTip(label4, "t - продолжительность утечки по фактическим данным 6 сек = 0,0017 час");
            toolTip4.SetToolTip(label5, "k - количество включений водоразборной колонки в сутки - 20");
            toolTip5.SetToolTip(label6, "n - количество водоразборных колонок");
            toolTip6.SetToolTip(label7, "z - расчетный период (количество суток)");
        }

        public string[] ReturnData()
        {
            string[] mas = new string[6];
            mas[0] = textBox1.Text;
            mas[1] = textBox2.Text;
            mas[2] = textBox3.Text;
            mas[3] = textBox4.Text;
            mas[4] = textBox5.Text;
            mas[5] = textBox6.Text;
            


            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


    }
}
