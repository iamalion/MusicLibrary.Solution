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
        string result = newRecord.Title;
        Assert.AreEqual(title, result);
        }

        [TestMethod]

        public void GetArtist_ReturnsSameArtist_String()
        {
        string artist = "artist";
        Record newRecord = new ("title", artist, 1989);
        string result = newRecord.Artist;
        Assert.AreEqual(artist, result);
        }

        [TestMethod]

        public void GetYear_ReturnsSameYear_Year()
        {
        int year = 1989;
        Record newRecord = new ("title", "artist", 1989);
        int result = newRecord.Year;
        Assert.AreEqual(year, result);
        }
    }
}