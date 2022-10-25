using System;
using System.Collections.Generic;

namespace FabricaIdeas.Prueba
{
    public partial class Premiacion
    {
        public Premiacion()
        {
            Ideas = new HashSet<Idea>();
        }

        public int IdPremi { get; set; }
        public int? CidCat { get; set; }
        public string? Pobser { get; set; }
        public double? Pmonto { get; set; }

        public virtual Categorium? CidCatNavigation { get; set; }
        public virtual ICollection<Idea> Ideas { get; set; }
    }
}
