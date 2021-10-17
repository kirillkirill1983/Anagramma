using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;

namespace TestAnagrama
{
    [TestClass]
    public class AnagramaTest
    {
        [TestMethod]
        public void ReverseAnagram()
        {
            var anagrama = new Anagrama();
            string myWord1 = "abcd efgh";
            string myWord2 = "a1bcd efg!h";

            string NotError1 = "dcba hgfe";
            string NotError2 = "d1cba hgf!e";

            string succesful1 = anagrama.Reverse(myWord1);
            string succesful2 = anagrama.Reverse(myWord2);

            Assert.AreEqual(NotError1, succesful1);
            Assert.AreEqual(NotError2, succesful2);
        }

        [TestMethod]
        public void ReverseAnagram_Space()
        {
            var anagrama = new Anagrama();
            string myWord = "kirill    kirill";
            string NotError = "llirik    llirik";
            string succesful = anagrama.Reverse(myWord);
            Assert.AreEqual(NotError, succesful);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseAnagram_Empty_Returns_Exception()
        {
            var anagrama = new Anagrama();
            string input = "";
            anagrama.Reverse(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseAnagram_Null_Returns_Exception()
        {
            var anagrama = new Anagrama();
            string input = null;
            anagrama.Reverse(input);
        }

        [TestMethod]
        public void ReverseAnagram_space_before_word()
        {
            var anagrama = new Anagrama();
            string myWord = "    kirill    ";
            string NotError = "    llirik    ";
            string succesful = anagrama.Reverse(myWord);
            Assert.AreEqual(NotError, succesful);
        }
    }
}
