using MilitaryApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryApp.Domain
{
    public class Military
    {
        public Military()
        {
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public King King { get; set; }
    }

    public class King
    {
        public int Id { get; set; }
        public string KingName { get; set; }
    }



    public class Quote
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Military Military { get; set; }

        public int MilitaryId { get; set; }
    }
}
