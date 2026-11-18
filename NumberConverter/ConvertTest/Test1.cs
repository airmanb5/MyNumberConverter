using NumberConverter;

namespace ConvertTest
{
    [TestClass]
    public sealed class ConvertTests
    {
        [TestMethod]
        public void TestConvert1ResultI()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(1);

            Assert.AreEqual("I", romanNumber);
        }
        
        [TestMethod]
        public void TestConvert3ResultIII()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(3);

            Assert.AreEqual("III", romanNumber);
        }
       
        [TestMethod]
        public void TestConvert4ResultIV()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(4);

            Assert.AreEqual("IV", romanNumber);
        }
       
        [TestMethod]
        public void TestConvert8ResultVIII()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(8);

            Assert.AreEqual("VIII", romanNumber);
        }

        [TestMethod]
        public void TestConvert9ResultIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(9);

            Assert.AreEqual("IX", romanNumber);
        }

        [TestMethod]
        public void TestConvert19ResultXIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(19);

            Assert.AreEqual("XIX", romanNumber);
        }

        [TestMethod]
        public void TestConvert3999ResultXIX()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(3999);

            Assert.AreEqual("MMMCMXCIX", romanNumber);
        }

        [TestMethod]
        public void TestConvert11ResultXI()
        {
            MyConverter converter = new MyConverter();

            string romanNumber = converter.ConvertToRomanNumber(11);

            Assert.AreEqual("XI", romanNumber);
        }
    }
}
