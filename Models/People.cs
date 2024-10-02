using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAPI.Models
{
    public class People
    {
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Years { get; set; }
        public string Profission { get; set; }
    }

}