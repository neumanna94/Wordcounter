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
            Assert.AreEqual("thisisasentence", splitter[0]);
            Assert.AreEqual("thisisanothersentence", splitter[1]);
            Assert.AreEqual("test", splitter[2]);
        }
        [TestMethod]
        public void RepeatCounter_WordCountTest()
        {
            RepeatCounter one = new RepeatCounter("Sentence", "Sentence Sentence sentence sentence");
            RepeatCounter two = new RepeatCounter("SenTence", "Sentence Sentence sentenc sentence");
            RepeatCounter three = new RepeatCounter("sentence", "sentence? sentence. sentence! sentence");
            RepeatCounter four = new RepeatCounter("TEST", "TEST test t es t");

            one.WordCount();
            two.WordCount();
            three.WordCount();
            four.WordCount();

            Assert.AreEqual(4, one.GetWordCount());
            Assert.AreEqual(3, two.GetWordCount());
            Assert.AreEqual(4, three.GetWordCount());
            Assert.AreEqual(2, four.GetWordCount());
            Assert.AreEqual("Sentence", one.GetWord());
            Assert.AreEqual("Sentence Sentence sentence sentence", one.GetSentence());

        }


      }
}
