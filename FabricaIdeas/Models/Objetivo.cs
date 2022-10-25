using System;
using System.Collections.Generic;

namespace FabricaIdeas.Models
{
    public partial class Objetivo
    {
        public int IdObje { get; set; }
        public int? IidIdea { get; set; }
        public int? Onivel { get; set; }
        public string? Odesc { get; set; }
        public bool? Oesta { get; set; }

        public virtual Idea? IidIdeaNavigation { get; set; }
    }
}
