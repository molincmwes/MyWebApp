using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Index
    {
        public string PageTitle { get; set; }
        public string TitleContent { get; set; }
        public IEnumerable<Links> Links { get; set; }
    }
}
