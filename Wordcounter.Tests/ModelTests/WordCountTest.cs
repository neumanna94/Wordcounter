using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordcounter.Models;
namespace Wordcounter.Tests
{
    [TestClass]
    public class WordcounterTests
    {
        [TestMethod]
        public void RepeatCounter_SettersTests()
        {
            RepeatCounter one = new RepeatCounter();

            one.SetWord("TestWord");
            one.SetSentence("TestSentence");

            Assert.AreEqual("TestWord", one.GetWord());
            Assert.AreEqual("TestSentence", one.GetSentence());
            Assert.AreEqual(0, one.GetWordCount());

        }
        [TestMethod]
        public void RepeatCounter_GettersTests()
        {
            RepeatCounter one = new RepeatCounter("thisisaword", "thisisaSentence");

            string word = one.GetWord();
            string sentence = one.GetSentence();

            Assert.AreEqual("thisisaword", word);
            Assert.AreEqual("thisisaSentence", sentence);
            Assert.AreEqual(0, one.GetWordCount());
        }
      }
}
