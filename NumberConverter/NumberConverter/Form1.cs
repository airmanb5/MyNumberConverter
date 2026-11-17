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
            RomanNumber = Converter.ConvertToRomanNumber(ArabianNumber);

            textRomanNumbers.Text = RomanNumber;
        }        
    }
}
