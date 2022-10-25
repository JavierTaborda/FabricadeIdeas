using System;
using System.Collections.Generic;

namespace FabricaIdeas.Prueba
{
    public partial class Idea
    {
        public Idea()
        {
            Objetivos = new HashSet<Objetivo>();
        }

        public int IdIdea { get; set; }
        public int? AidArea { get; set; }
        public int? EidEsta { get; set; }
        public int? PidPremi { get; set; }
        public int? RidRespon { get; set; }
        public string? Inombre { get; set; }
        public string? Iecarga { get; set; }
        public string? Idesc { get; set; }
        public string? Isolu { get; set; }
        public string? Ifacti { get; set; }
        public string? Iesta { get; set; }
        public bool? Iacti { get; set; }

        public virtual Area? AidAreaNavigation { get; set; }
        public virtual Estatus? EidEstaNavigation { get; set; }
        public virtual Premiacion? PidPremiNavigation { get; set; }
        public virtual Respon? RidResponNavigation { get; set; }
        public virtual ICollection<Objetivo> Objetivos { get; set; }
    }
}
