using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicLibrary.Models;
using System;

namespace MusicLibrary.Tests
{
    [TestClass]
    public class RecordTests
    {
        [TestMethod]
        public void RecordConstructor_CreatesInstanceOfRecord_Record()
        {
            Record newRecord = new Record("title", "artist", 1989);
            Assert.AreEqual(typeof(Record), newRecord.GetType());
        
        }

        [TestMethod]
        public void GetTitle_ReturnsSameTitle_String()
        {
        string title = "title";
        Record newRecord = new (title, "artist", 1989);
        string result = newRecord.Title();
        Assert.AreEqual(title, result);
        }
    }
}