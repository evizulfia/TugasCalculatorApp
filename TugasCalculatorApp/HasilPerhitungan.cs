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
    public partial class HasilPerhitungan : Form
    {
        private IList<Perhitungan> listOfPerhitungan = new List<Perhitungan>();
        public HasilPerhitungan()
        {
            InitializeComponent();
        }

        private void OperasiHitung_OnCreate(Perhitungan calc)
        {
            listOfPerhitungan.Clear();
            listOfPerhitungan.Add(calc);
            listHasil.Items.Add(calc.hasil);
        }

        private void hitungBtn_Click(object sender, EventArgs e)
        {
            OperasiHitung formHasil = new OperasiHitung();
            formHasil.OnCreate += OperasiHitung_OnCreate;
            formHasil.ShowDialog();
        }
    }
}
