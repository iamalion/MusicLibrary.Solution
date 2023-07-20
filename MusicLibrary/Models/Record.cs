using System.Collections.Generic;

namespace MusicLibrary.Models 
{ 
    public class Record
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public static List<Record> instances = new List<Record> { };
        public Record(string title, string artist, int year)
        {
            Title = title;
            Artist = artist;
            Year = year;
        }

        public string GetTitle()
        {
            return Title;
        }

    }
}


















    // public string Title { get; set; }
    // private static List<Record> _instances = new List<Record> { };

    // public Record(string title)
    // {
    //   Title = title;
    //   _instances.Add(this);
    // }

    // public static List<Record> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
