using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }

    }
}
