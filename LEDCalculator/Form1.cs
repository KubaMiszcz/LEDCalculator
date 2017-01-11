using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDCalculator
{
    public partial class Form1: Form
    {
        private float Current;
        private float LEDdrop;
        private float CustomVoltage;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Compute();
        }

        void Compute()
        {
            try
            {
                errorProvider1.Clear();
                Current = float.Parse(tbCurrent.Text) * 0.001f;
                CustomVoltage = float.Parse(tbCustomVoltage.Text);
                LEDdrop = float.Parse(tbLEDdrop.Text);
                tbR33.Text = ((int)((3.3 - LEDdrop) / Current)).ToString();
                tbR50.Text = ((int)((5.0 - LEDdrop) / Current)).ToString();
                tbR60.Text = ((int)((6.0 - LEDdrop) / Current)).ToString();
                tbR12.Text = ((int)((12.0 - LEDdrop) / Current)).ToString();
                tbCustomResistance.Text = ((int)((CustomVoltage - LEDdrop) / Current)).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Check Data...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tbCurrent_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void tbLEDdrop_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void tbCustomVoltage_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }
    }
}
