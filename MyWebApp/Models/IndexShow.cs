using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class IndexShow
    {
        public string PageTitle { get; set; }
        public string TitleContent { get; set; }
        public List<Links> Links { get; set; }
    }
}