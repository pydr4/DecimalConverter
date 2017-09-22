using System;
using System.Windows.Forms;

namespace DecToOctBinConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertToOctal_Click(object sender, EventArgs e)
        {

            if (long.TryParse(textBox1.Text, out long decValue)) {
                long octalValue = NumberingSystemConverter.DecimalToBaseSystem(decValue, (int) NumberingSystemConverter.NumberBase.OCTAL);
                labelResult.Text = "Octal Value is " + octalValue.ToString();
            }
            else{
                labelResult.Text = "Please Enter a Number";
            }

        }

        private void btnConvertToBinary_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBox1.Text, out long decValue))
            {
                long octalValue = NumberingSystemConverter.DecimalToBaseSystem(decValue, (int)NumberingSystemConverter.NumberBase.BINARY);
                labelResult.Text = "Binary Value is " + octalValue.ToString();
            }
            else
            {
                labelResult.Text = "Please Enter a Number";
            }
        }
    }
}
