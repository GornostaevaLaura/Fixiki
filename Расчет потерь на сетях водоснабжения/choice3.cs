using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Расчет_потерь_на_сетях_водоснабжения
{
    public partial class choice3 : Form
    {
        public choice3()
        {
            InitializeComponent();
        }

        private void choice3_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "Hi - принимается равным средней величине напора воды в трубопроводе на поврежденном участке; \n при переломах и разрывах труб H принимается равным средней глубине заложения трубопровода");
            toolTip2.SetToolTip(label3, "d - диаметр трубы");
            toolTip3.SetToolTip(label4, "t - продолжительность утечки с момента обнаружения до отключения поврежденного участка\n или заделки отверстия трубопровода");
        }
        public string[] ReturnData()
        {
            string[] mas = new string[3];
            mas[0] = textBox1.Text;
            mas[1] = textBox2.Text;
            mas[2] = textBox3.Text;


            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
