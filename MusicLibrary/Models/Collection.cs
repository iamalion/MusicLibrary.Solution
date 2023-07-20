using System.Collections.Generic;
namespace MusicLibrary.Models {
    
    public class Collection
    {
        public string Name { get; set; }
        public Collection(string name)
        {
            Name = name;
        }

    }
}