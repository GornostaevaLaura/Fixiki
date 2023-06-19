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
    public partial class choice10 : Form
    {
        public choice10()
        {
            InitializeComponent();
        }

        private void choice10_Load(object sender, EventArgs e)
        {
            //Всплывающая справка
            toolTip1.SetToolTip(label2, "Wотп - объем воды, отпускаемой абонентам.");
            toolTip2.SetToolTip(label5, "K - отношение объема отпущенной воды по показанию приборов (узлов) учета абонентов к общему объему отпущенной воды (коэффициент приборного учета).");
            toolTip3.SetToolTip(label3, "Wпод - объем воды, поданной в сеть;");
            toolTip4.SetToolTip(label8, "Wпол - суммарный объем расходов воды;");
            toolTip5.SetToolTip(label9, "Wпот - объем потерь при повреждениях из водопроводных сетей;");
            toolTip6.SetToolTip(label4, "G - объем потерь воды за счет естественной убыли.");
        }
        public string[] ReturnData()
        {
            string[] mas = new string[6];
            mas[0] = textBox1.Text;
            mas[1] = textBox4.Text;
            mas[2] = textBox2.Text;
            mas[3] = textBox7.Text;
            mas[4] = textBox8.Text;
            mas[5] = textBox3.Text;


            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
