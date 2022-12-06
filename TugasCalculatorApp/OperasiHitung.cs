using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculatorApp
{
    public partial class OperasiHitung : Form
    {
        public delegate void CreateUpdateEventHandler(Perhitungan calc);
        public event CreateUpdateEventHandler OnCreate;
        private bool isNewData = true;

        private Perhitungan calc;
        public OperasiHitung()
        {
            InitializeComponent();
        }

        private int Penambahan(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Pengurangan(int num1, int num2)
        {
            return num1 - num2;
        }

        private int Perkalian(int num1, int num2)
        {
            return num1 * num2;
        }
        private int Pembagian(int num1, int num2)
        {
            return num1 / num2;
        }

        private void prosesBtn_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(formNilaiA.Text);
            var num2 = int.Parse(formNilaiB.Text);
            if (isNewData) calc = new Perhitungan();


            if (operasiDropDown.Text == "Penjumlahan")
            {
                calc.hasil = "Hasil Penjumlahan " + formNilaiA.Text + " + " + formNilaiB.Text + " = " + String.Format("{0}", Penambahan(num1, num2));
            }
            else if (operasiDropDown.Text == "Pengurangan")
            {
                calc.hasil = "Hasil Pengurangan " + formNilaiA.Text + " - " + formNilaiB.Text + " = " + String.Format("{0}", Pengurangan(num1, num2));
            }
            else if (operasiDropDown.Text == "Perkalian")
            {
                calc.hasil = "Hasil Perkalian " + formNilaiA.Text + " x " + formNilaiB.Text + " = " + String.Format("{0}", Perkalian(num1, num2));
            }
            else if (operasiDropDown.Text == "Pembagian")
            {
                calc.hasil = "Hasil Pembagian " + formNilaiA.Text + " : " + formNilaiB.Text + " = " + String.Format("{0}", Pembagian(num1, num2));
            }
            else
            {
                MessageBox.Show("Operasi belum dipilih. Silahkan pilih operasi!");
            }

            if (isNewData)
            {
                OnCreate(calc);
            }
        }
    }
}
