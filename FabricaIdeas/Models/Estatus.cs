using System;
using System.Collections.Generic;

namespace FabricaIdeas.Models
{
    public partial class Estatus
    {
        public Estatus()
        {
            Ideas = new HashSet<Idea>();
        }

        public int IdEstatus { get; set; }
        public int? Enivel { get; set; }
        public string? Edesc { get; set; }
        public bool? Eesta { get; set; }

        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
