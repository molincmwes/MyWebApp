using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Managers
{
    public class StartUpManager
    {
        public Index Execute()
        {
            return new Index()
            {
                PageTitle = "Carlos' First From Scratch Website",
                TitleContent = "Some cool stuff will be here",
                Links = new List<Links>
                {
                    new Links { Name = "Need Google?", Url = "https://www.google.com" },
                    new Links { Name = "Need Gmail?", Url = "https://www.gmail.com"},
                    new Links { Name = "Need Facebook?", Url = "https://www.facebook.com" }
                }
            };
        }
    }
}
