using System.ComponentModel;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ArabianNumber { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RomanNumber { get; set; }

        MyConverter Converter;

        public Form1()
        {
            InitializeComponent();

            Converter = new MyConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textArabianNumbers_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textArabianNumbers.Text, out int number))
            {
                ArabianNumber = number;
                buttonConvert.Enabled = true;
            }
            else
            {
                buttonConvert.Enabled = false;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (radioButtonToArabian.Checked)
            {
                textArabianNumbers.Text = Converter.ConvertToArabianNumber(RomanNumber).ToString();
            }
            else
            { 
                textRomanNumbers.Text = Converter.ConvertToRomanNumber(ArabianNumber);
            }

        }

        private void radioButtonToArabian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToArabian.Checked)
            {
                textArabianNumbers.Enabled = false;
                textRomanNumbers.Enabled = true;
            }
        }

        private void radioButtonToRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToRoman.Checked)
            {
                textArabianNumbers.Enabled = true;
                textRomanNumbers.Enabled = false;
            }
        }

        private void textRomanNumbers_TextChanged(object sender, EventArgs e)
        {
            string romanValues = "MCDXLVI";

            foreach (char letter in textRomanNumbers.Text)
            {
                if (!romanValues.Contains(letter))
                {
                    buttonConvert.Enabled = false;

                    break;
                }
                else
                {
                    buttonConvert.Enabled = true;

                    RomanNumber = textRomanNumbers.Text;
                }
            }
        }
    }
}
