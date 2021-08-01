using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZochitaApi.Models
{
    public class Todo
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Completed { get; set; }
    }
}
