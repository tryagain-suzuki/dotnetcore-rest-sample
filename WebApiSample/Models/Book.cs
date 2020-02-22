using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool isRent { get; set; }
    }
}
