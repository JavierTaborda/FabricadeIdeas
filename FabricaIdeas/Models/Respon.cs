using System;
using System.Collections.Generic;

namespace FabricaIdeas.Models
{
    public partial class Respon
    {
        public int IdRespon { get; set; }
        public int? IidIdea { get; set; }
        public string? Rficha { get; set; }
        public string? Rnombre { get; set; }
        public int? Rnum { get; set; }
        public bool? Resta { get; set; }

        public virtual Idea? IidIdeaNavigation { get; set; }
    }
}
