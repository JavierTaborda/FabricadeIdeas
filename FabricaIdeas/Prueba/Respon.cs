using System;
using System.Collections.Generic;

namespace FabricaIdeas.Prueba
{
    public partial class Respon
    {
        public Respon()
        {
            Ideas = new HashSet<Idea>();
        }

        public int IdRespon { get; set; }
        public string? Rficha { get; set; }
        public string? Rnombre { get; set; }
        public int? Rnum { get; set; }
        public bool? Resta { get; set; }

        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
