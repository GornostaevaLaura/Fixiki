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
    public partial class choice9 : Form
    {
        public choice9()
        {
            InitializeComponent();
        }
        bool flag;
        double[] sum1 = new double[100];
        int countDatf1 = 0;

        double[] sum2 = new double[100];
        int countDatf2 = 0;

        double Sum1 = 0;
        double Sum2 = 0;
        private void choice8_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "N - количество участков ВС постоянного диаметра и материала.");
            toolTip2.SetToolTip(label11, "d - внутренний диаметр трубопровода, мм");
            toolTip3.SetToolTip(label4, "t - продолжительность расчетного периода, ч;");
            toolTip4.SetToolTip(label6, "li - протяженность i-го участка водоснабжения постоянного диаметра и материала, км;");

            toolTip5.SetToolTip(label12, "N - количество РЧВ.");
            toolTip6.SetToolTip(label10, "t - продолжительность работы i-го РЧВ за расчетный период, ч;");
            toolTip7.SetToolTip(label8, "Fi - площадь смоченной поверхности i-го РЧВ. Площадь смоченной поверхности определяется при наполнении резервуара до половины рабочей глубины;" +
                "0,125 - норма естественной убыли воды при хранении в РЧВ, кг/м2 ч,");

        }


        public string[,] ReturnData()
        {
            if (Material.SelectedIndex == -1)
                MessageBox.Show("Выберите тип повреждения из списка");

            //Считывания массива данных для суммирования
            string s1 = textBox5.Text;
            string[] arrstring1 = new string[1];
            if (s1 != "")
            {
                arrstring1 = s1.Split(' ');
            }
            if (Convert.ToInt32(textBox1.Text) != arrstring1.Length)
                MessageBox.Show("Количество данных в li не соответсвует заявленному");

            for (int i = 0; i < arrstring1.Length; i++)
                {
                    Sum1 += Convert.ToInt32(arrstring1[i]);
                }

            string s2 = textBox8.Text;
            string[] arrstring2 = new string[1];
            if (s2 != "")
            {
                arrstring2 = s2.Split(' ');
            }
            if (Convert.ToInt32(textBox12.Text) != arrstring2.Length)
                    MessageBox.Show("Количество данных в Fi не соответсвует заявленному");

            for (int i = 0; i < arrstring2.Length; i++)
            {
                Sum2 += Convert.ToInt32(arrstring2[i]);
            }

           /* for (int i = 0; i < countDatf1; i++)
                Sum1 += sum1[i];

            for (int i = 0; i < countDatf2; i++)
                Sum2 += sum2[i]; */

            string[,] mas = new string[2, 5];

            mas[0,0] = textBox1.Text;
            mas[0,1] = Convert.ToString(Material.SelectedIndex);
            mas[0,2] = textBox2.Text;
            mas[0,3] = textBox3.Text;
            mas[0,4] = Convert.ToString(Sum1);


            mas[1, 0] = textBox12.Text;
            mas[1, 1] = textBox10.Text;
           // mas[1, 2] = textBox3.Text;
            mas[1, 2] = Convert.ToString(Sum2);

            return mas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Material_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
