using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notepad.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public int Working { get; set; }
    }
}