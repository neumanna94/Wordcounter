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

        [TestMethod]
        public void RepeatCounter_SplitterTest()
        {
            RepeatCounter one = new RepeatCounter("thisisaword", "thisisaSentence thisisAnotherSentence Test");

            List<string> splitter = one.Splitter();

            Console.WriteLine("Splitter Result Word One: " + splitter[0]);
            Console.WriteLine("Splitter Result Word Two: " + splitter[1]);
            Console.WriteLine("Splitter Result Word Three: " + splitter[2]);
            Assert.AreEqual("thisisaSentence", splitter[0]);
            Assert.AreEqual("thisisAnotherSentence", splitter[1]);
            Assert.AreEqual("Test", splitter[2]);
        }
        [TestMethod]
        public void RepeatCounter_WordCountTest()
        {
            RepeatCounter one = new RepeatCounter("Sentence", "Sentence Sentence sentence sentence");
            RepeatCounter two = new RepeatCounter("SenTence", "Sentence Sentence sentence sentence");

            one.WordCount();
            two.WordCount();

            Assert.AreEqual(2, one.GetWordCount());
            Assert.AreEqual(0, two.GetWordCount());

        }


      }
}
