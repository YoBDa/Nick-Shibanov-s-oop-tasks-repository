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
        Exception InvalidFractionException = new Exception("Invalid fraction elements found.");
        public Form1()
        {
            InitializeComponent();
            
        }
        private void MakeFractions(out Frac f1, out Frac f2)
        {
            f1 = new Frac(0, 1);
            f2 = new Frac(0, 1);

            tbFraction.Text = "";
            int Numerator1 = 0;
            int Numerator2 = 0;
            int Denominator1 = 0;
            int Denominator2 = 0;
            if (!Int32.TryParse(tbNumerator1.Text, out Numerator1))
            {
                throw InvalidFractionException;
            }
            if (!Int32.TryParse(tbNumerator2.Text, out Numerator2))
            {
                throw InvalidFractionException;
            }
            if (!Int32.TryParse(tbDenominator1.Text, out Denominator1))
            {
                throw InvalidFractionException;
            }
            if (!Int32.TryParse(tbDenominator2.Text, out Denominator2))
            {
                throw InvalidFractionException;
            }
            f1 = new Frac(Numerator1, Denominator1);
            f2 = new Frac(Numerator2, Denominator2);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Frac f1, f2;
                MakeFractions(out f1, out f2);
                Frac f3 = f1 + f2;
                tbFraction.Text = f3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            try
            {
                Frac f1, f2;
                MakeFractions(out f1, out f2);
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

            try
            {
                Frac f1, f2;
                MakeFractions(out f1, out f2);
                Frac f3 = f1 - f2;
                tbFraction.Text = f3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                Frac f1, f2;
                MakeFractions(out f1, out f2);
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
