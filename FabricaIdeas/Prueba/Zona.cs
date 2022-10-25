using System;
using System.Collections.Generic;

namespace FabricaIdeas.Prueba
{
    public partial class Zona
    {
        public int IdZona { get; set; }
        public int? AidArea { get; set; }
        public string? Znombre { get; set; }
        public string? Zcentro { get; set; }
        public bool? Zesta { get; set; }

        public virtual Area? AidAreaNavigation { get; set; }
    }
}
