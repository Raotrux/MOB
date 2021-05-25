using System;

namespace MobTestApp.Models
{
    // This is the "interface" for the VideoCard. I didn't change the file name because of code thats hidden in deep files.
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
    }
}