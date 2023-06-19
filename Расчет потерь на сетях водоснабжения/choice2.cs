using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Расчет_потерь_на_сетях_водоснабжения
{
    public partial class choice2 : Form
    {
        public choice2()
        {
            InitializeComponent();
        }

        private void choice2_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            
            toolTip1.SetToolTip(label3, "Hi - принимается равным средней величине напора воды в трубопроводе на поврежденном участке; \n при переломах и разрывах труб H принимается равным средней глубине заложения трубопровода");
            toolTip2.SetToolTip(label4, "t - продолжительность утечки с момента обнаружения до отключения поврежденного участка\n или заделки отверстия трубопровода");
        }
        public string[] ReturnData()
        {
            string[] mas = new string[2];
            
            mas[0] = textBox2.Text;
            mas[1] = textBox3.Text;


            return mas;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
