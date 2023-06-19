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
    public partial class choice1 : Form
    {
        public choice1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void choice1_Load(object sender, EventArgs e)
        {
           // toolTip1 t = new ToolTip();
            

            label1.Text = "Введите следующие данные";
            label2.Text = "Wi";
            label3.Text = "Hi";
            label4.Text = "t";

            //Всплывающая справка
            toolTip1.SetToolTip(label2, "Wi - площадь живого сечения i-го отверстия (кв. м)");
            toolTip2.SetToolTip(label3, "Hi - принимается равным средней величине напора воды в трубопроводе на поврежденном участке; \n при переломах и разрывах труб H принимается равным средней глубине заложения трубопровода");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           // toolTip1.SetToolTip(label3, "H - принимается равным средней величине напора воды в трубопроводе на поврежденном участке; \n при переломах и разрывах труб H принимается равным средней глубине заложения трубопровода\";");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
