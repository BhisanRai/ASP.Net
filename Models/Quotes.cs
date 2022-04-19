using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesWebApp.Models
{
    public class Quotes
    {
        public int ID { get; set; }
        public string Quote { get; set; }

        public string Author { get; set; }

        public Quotes()
        {

        }
    }
}
