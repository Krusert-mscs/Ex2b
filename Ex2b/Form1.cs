using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal Canada = Convert.ToDecimal(0.76140989);
            decimal UK = Convert.ToDecimal(1.1511001);
            decimal Japan = Convert.ToDecimal(0.007131922);
            decimal Europe = Convert.ToDecimal(0.99535511);

            decimal canadaBooty = Convert.ToDecimal(txtCanada.Text);
            decimal ukHeavies = Convert.ToDecimal(txtUK.Text);
            decimal japanWeebWannabes = Convert.ToDecimal(txtJapan.Text);
            decimal EuroCrisps = Convert.ToDecimal(txtEurope.Text);

            decimal canadaCnvt = Canada * canadaBooty;
            decimal ukCnvt = UK * ukHeavies;
            decimal japanCnvt = Japan * japanWeebWannabes;
            decimal europeCnvt = Europe * EuroCrisps;

            txtConvert1.Text = canadaCnvt.ToString("0.00");
            txtConvert2.Text = ukCnvt.ToString("0.00");
            txtConvert3.Text = japanCnvt.ToString("0.00");
            txtConvert4.Text = europeCnvt.ToString("0.00");

            txtTotalUS.Text = (canadaCnvt + ukCnvt + japanCnvt + europeCnvt).ToString("0.00");

        }

        private void txtCanada_TextChanged(object sender, EventArgs e)
        {
            decimal Canada = Convert.ToDecimal(0.76140989);
            decimal UK = Convert.ToDecimal(1.1511001);
            decimal Japan = Convert.ToDecimal(0.007131922);
            decimal Europe = Convert.ToDecimal(0.99535511);

            decimal canadaBooty = Convert.ToDecimal(txtCanada.Text);
            decimal ukHeavies = Convert.ToDecimal(txtUK.Text);
            decimal japanWeebWannabes = Convert.ToDecimal(txtJapan.Text);
            decimal EuroCrisps = Convert.ToDecimal(txtEurope.Text);

            decimal canadaCnvt = Canada * canadaBooty;
            decimal ukCnvt = UK * ukHeavies;
            decimal japanCnvt = Japan * japanWeebWannabes;
            decimal europeCnvt = Europe * EuroCrisps;

            txtConvert1.Text = canadaCnvt.ToString("0.00");
            txtConvert2.Text = ukCnvt.ToString("0.00");
            txtConvert3.Text = japanCnvt.ToString("0.00");
            txtConvert4.Text = europeCnvt.ToString("0.00");

            txtTotalUS.Text = (canadaCnvt + ukCnvt + japanCnvt + europeCnvt).ToString("0.00");
        }

        private void txtUK_TextChanged(object sender, EventArgs e)
        {
            decimal Canada = Convert.ToDecimal(0.76140989);
            decimal UK = Convert.ToDecimal(1.1511001);
            decimal Japan = Convert.ToDecimal(0.007131922);
            decimal Europe = Convert.ToDecimal(0.99535511);

            decimal canadaBooty = Convert.ToDecimal(txtCanada.Text);
            decimal ukHeavies = Convert.ToDecimal(txtUK.Text);
            decimal japanWeebWannabes = Convert.ToDecimal(txtJapan.Text);
            decimal EuroCrisps = Convert.ToDecimal(txtEurope.Text);

            decimal canadaCnvt = Canada * canadaBooty;
            decimal ukCnvt = UK * ukHeavies;
            decimal japanCnvt = Japan * japanWeebWannabes;
            decimal europeCnvt = Europe * EuroCrisps;

            txtConvert1.Text = canadaCnvt.ToString("0.00");
            txtConvert2.Text = ukCnvt.ToString("0.00");
            txtConvert3.Text = japanCnvt.ToString("0.00");
            txtConvert4.Text = europeCnvt.ToString("0.00");

            txtTotalUS.Text = (canadaCnvt + ukCnvt + japanCnvt + europeCnvt).ToString("0.00");
        }

        private void txtJapan_TextChanged(object sender, EventArgs e)
        {
            decimal Canada = Convert.ToDecimal(0.76140989);
            decimal UK = Convert.ToDecimal(1.1511001);
            decimal Japan = Convert.ToDecimal(0.007131922);
            decimal Europe = Convert.ToDecimal(0.99535511);

            decimal canadaBooty = Convert.ToDecimal(txtCanada.Text);
            decimal ukHeavies = Convert.ToDecimal(txtUK.Text);
            decimal japanWeebWannabes = Convert.ToDecimal(txtJapan.Text);
            decimal EuroCrisps = Convert.ToDecimal(txtEurope.Text);

            decimal canadaCnvt = Canada * canadaBooty;
            decimal ukCnvt = UK * ukHeavies;
            decimal japanCnvt = Japan * japanWeebWannabes;
            decimal europeCnvt = Europe * EuroCrisps;

            txtConvert1.Text = canadaCnvt.ToString("0.00");
            txtConvert2.Text = ukCnvt.ToString("0.00");
            txtConvert3.Text = japanCnvt.ToString("0.00");
            txtConvert4.Text = europeCnvt.ToString("0.00");

            txtTotalUS.Text = (canadaCnvt + ukCnvt + japanCnvt + europeCnvt).ToString("0.00");
        }

        private void txtEurope_TextChanged(object sender, EventArgs e)
        {
            decimal Canada = Convert.ToDecimal(0.76140989);
            decimal UK = Convert.ToDecimal(1.1511001);
            decimal Japan = Convert.ToDecimal(0.007131922);
            decimal Europe = Convert.ToDecimal(0.99535511);

            decimal canadaBooty = Convert.ToDecimal(txtCanada.Text);
            decimal ukHeavies = Convert.ToDecimal(txtUK.Text);
            decimal japanWeebWannabes = Convert.ToDecimal(txtJapan.Text);
            decimal EuroCrisps = Convert.ToDecimal(txtEurope.Text);

            decimal canadaCnvt = Canada * canadaBooty;
            decimal ukCnvt = UK * ukHeavies;
            decimal japanCnvt = Japan * japanWeebWannabes;
            decimal europeCnvt = Europe * EuroCrisps;

            txtConvert1.Text = canadaCnvt.ToString("0.00");
            txtConvert2.Text = ukCnvt.ToString("0.00");
            txtConvert3.Text = japanCnvt.ToString("0.00");
            txtConvert4.Text = europeCnvt.ToString("0.00");

            txtTotalUS.Text = (canadaCnvt + ukCnvt + japanCnvt + europeCnvt).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCanada.Text = "0.00";
            txtUK.Text = "0.00";
            txtJapan.Text = "0.00";
            txtEurope.Text = "0.00";
            txtConvert1.Text = "0.00";
            txtConvert2.Text = "0.00";
            txtConvert3.Text = "0.00";
            txtConvert4.Text = "0.00";
            txtTotalUS.Text = "";
        }
    }
}
