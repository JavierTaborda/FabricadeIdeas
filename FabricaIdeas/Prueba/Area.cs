using System;
using System.Collections.Generic;

namespace FabricaIdeas.Prueba
{
    public partial class Area
    {
        public Area()
        {
            Ideas = new HashSet<Idea>();
            Zonas = new HashSet<Zona>();
        }

        public int IdArea { get; set; }
        public string? Anombre { get; set; }
        public string? Adescri { get; set; }
        public bool? Aesta { get; set; }

        public virtual ICollection<Idea> Ideas { get; set; }
        public virtual ICollection<Zona> Zonas { get; set; }
    }
}
