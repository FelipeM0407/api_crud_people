using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class People
    {
        public int peopleId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int years { get; set; }
        public string profession { get; set; }
    }
}