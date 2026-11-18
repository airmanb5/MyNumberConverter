using NumberConverter;

namespace ConvertTest
{
    [TestClass]
    public sealed class ConvertTests
    {
        [TestMethod]
        public void TestConvertToRoman1ResultI()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(1);

            Assert.AreEqual("I", romanNumber);
        }
        
        [TestMethod]
        public void TestConvertToRoman3ResultIII()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(3);

            Assert.AreEqual("III", romanNumber);
        }
       
        [TestMethod]
        public void TestConvertToRoman4ResultIV()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(4);

            Assert.AreEqual("IV", romanNumber);
        }
       
        [TestMethod]
        public void TestConvertToRoman8ResultVIII()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(8);

            Assert.AreEqual("VIII", romanNumber);
        }

        [TestMethod]
        public void TestConvertToRoman9ResultIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(9);

            Assert.AreEqual("IX", romanNumber);
        }

        [TestMethod]
        public void TestConvertToRoman19ResultXIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(19);

            Assert.AreEqual("XIX", romanNumber);
        }

        [TestMethod]
        public void TestConvertToRoman3999ResultXIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(3999);

            Assert.AreEqual("MMMCMXCIX", romanNumber);
        }

        [TestMethod]
        public void TestConvertToRoman11ResultXI()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(11);

            Assert.AreEqual("XI", romanNumber);
        }

        [TestMethod]
        public void TestConvertToArabianIResult1()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("I");

            Assert.AreEqual(1, arabianNumber);
        }

        [TestMethod]
        public void TestConvertToArabianIVResult4()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("IV");

            Assert.AreEqual(4, arabianNumber);
        }

        [TestMethod]
        public void TestConvertToArabianIXResult9()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("IX");

            Assert.AreEqual(9, arabianNumber);
        }

        [TestMethod]
        public void TestConvertToArabianXIResult11()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("XI");

            Assert.AreEqual(11, arabianNumber);
        }

        [TestMethod]
        public void TestConvertToArabianCDXCIXResult499()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("CDXCIX");

            Assert.AreEqual(499, arabianNumber);
        }

        [TestMethod]
        public void TestConvertToArabianMMMCMXCIXResult3999()
        {
            MyConverter converter = new MyConverter();

            int arabianNumber = converter.ConvertToArabianNumber("MMMCMXCIX");

            Assert.AreEqual(3999, arabianNumber);
        }
    }
}
