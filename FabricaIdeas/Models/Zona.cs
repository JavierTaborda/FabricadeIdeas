using System;
using System.Collections.Generic;

namespace FabricaIdeas.Models
{
    public partial class Zona
    {
        public Zona()
        {
            Ideas = new HashSet<Idea>();
        }

        public int IdZona { get; set; }
        public int? AidArea { get; set; }
        public string? Znombre { get; set; }
        public string? Zcentro { get; set; }
        public bool? Zesta { get; set; }

        public virtual Area? AidAreaNavigation { get; set; }
        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
