using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_web.Models
{
    public class Book
    {
        public int id
        {
            get;
            set;
        }
        public string Titre
        {
            get;
            set;
        }
        public string Auteur
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Price
        {
            get;
            set;
        }
        public string Quantity{ get;set; }
        public string image
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }
        public string avail
        {
            get;
            set;
        }


    }
}
