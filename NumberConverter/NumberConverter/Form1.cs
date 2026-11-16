using System.ComponentModel;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ArabianNumber { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RomanNumber { get; set; }

        public Form1()
        {
            InitializeComponent();
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
            RomanNumber = ConvertToRomanNumber();

            
        }

        private string ConvertToRomanNumber()
        {
           int numberToConvert = Convert.ToInt32(buttonConvert.Text);

            return " ";
        }
    }
}
