using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Tags { get; set; }
        public List<string> Pictures { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Priority { get; set; }
    }
}
