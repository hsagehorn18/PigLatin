using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PigLatinProject;

namespace PigLatinTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicPigLatinTest()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "hello";
            string actual = "";
            string expected = "ello-hay";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest2()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "switch";
            string actual = "";
            string expected = "itch-sway";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicPigLatinTest3()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "banana";
            string actual = "";
            string expected = "anana-bay";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicPigLatinTest4()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "climb";
            string actual = "";
            string expected = "imb-clay";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
    }
}
