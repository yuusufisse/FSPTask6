using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask6.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public int? PassportNumber { get; set; }
        public DateTime? ValidDate { get; set; }
        public int PassengerId { get; set; }
        public Passenger? Passenger { get; set; }
    }
}
