using System;
using System.Collections.Generic;

namespace LDSGems.Models
{
    public partial class DailyGems
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string RawDescription { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
        public string LdsOrgUrl { get; set; }
        public string Topic { get; set; }
        public string SourceRss { get; set; }
        public DateTime? PubDate { get; set; }
        public string LangCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
