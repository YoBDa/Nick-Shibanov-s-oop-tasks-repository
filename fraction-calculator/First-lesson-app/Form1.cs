using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_lesson_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFraction.Text = "";
            int Numerator1 = 0;
            int Numerator2 = 0;
            int Denominator1 = 0;
            int Denominator2 = 0;
            if (!Int32.TryParse(tbNumerator1.Text, out Numerator1))
            {
                MessageBox.Show("1st numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbNumerator2.Text, out Numerator2))
            {
                MessageBox.Show("2nd numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator1.Text, out Denominator1))
            {
                MessageBox.Show("1st denominator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator2.Text, out Denominator2))
            {
                MessageBox.Show("2nd denominator is wrong");
                return;
            }
            try
            {
                Frac f1 = new Frac(Numerator1, Denominator1);
                Frac f2 = new Frac(Numerator2, Denominator2);
                Frac f3 = f1 + f2;
                tbFraction.Text = f3.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbFraction.Text = "";
            int Numerator1 = 0;
            int Numerator2 = 0;
            int Denominator1 = 0;
            int Denominator2 = 0;
            if (!Int32.TryParse(tbNumerator1.Text, out Numerator1))
            {
                MessageBox.Show("1st numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbNumerator2.Text, out Numerator2))
            {
                MessageBox.Show("2nd numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator1.Text, out Denominator1))
            {
                MessageBox.Show("1st denominator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator2.Text, out Denominator2))
            {
                MessageBox.Show("2nd denominator is wrong");
                return;
            }
            try
            {
                Frac f1 = new Frac(Numerator1, Denominator1);
                Frac f2 = new Frac(Numerator2, Denominator2);
                Frac f3 = f1 * f2;
                tbFraction.Text = f3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbFraction.Text = "";
            int Numerator1 = 0;
            int Numerator2 = 0;
            int Denominator1 = 0;
            int Denominator2 = 0;
            if (!Int32.TryParse(tbNumerator1.Text, out Numerator1))
            {
                MessageBox.Show("1st numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbNumerator2.Text, out Numerator2))
            {
                MessageBox.Show("2nd numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator1.Text, out Denominator1))
            {
                MessageBox.Show("1st denominator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator2.Text, out Denominator2))
            {
                MessageBox.Show("2nd denominator is wrong");
                return;
            }
            try
            {
                Frac f1 = new Frac(Numerator1, Denominator1);
                Frac f2 = new Frac(Numerator2, Denominator2);
                Frac f3 = f1-f2;
                tbFraction.Text = f3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbFraction.Text = "";
            int Numerator1 = 0;
            int Numerator2 = 0;
            int Denominator1 = 0;
            int Denominator2 = 0;
            if (!Int32.TryParse(tbNumerator1.Text, out Numerator1))
            {
                MessageBox.Show("1st numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbNumerator2.Text, out Numerator2))
            {
                MessageBox.Show("2nd numerator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator1.Text, out Denominator1))
            {
                MessageBox.Show("1st denominator is wrong");
                return;
            }
            if (!Int32.TryParse(tbDenominator2.Text, out Denominator2))
            {
                MessageBox.Show("2nd denominator is wrong");
                return;
            }
            try
            {
                Frac f1 = new Frac(Numerator1, Denominator1);
                Frac f2 = new Frac(Numerator2, Denominator2);
                Frac f3 = f1 / f2;
                tbFraction.Text = f3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
