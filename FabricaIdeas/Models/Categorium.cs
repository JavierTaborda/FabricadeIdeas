using System;
using System.Collections.Generic;

namespace FabricaIdeas.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Premiacions = new HashSet<Premiacion>();
        }

        public int IdCate { get; set; }
        public string? Cdescrip { get; set; }
        public int? Crango { get; set; }
        public bool? Cesta { get; set; }

        public virtual ICollection<Premiacion> Premiacions { get; set; }
    }
}
