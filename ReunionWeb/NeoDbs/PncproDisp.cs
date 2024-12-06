using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class PncproDisp
    {
        public PncproDisp()
        {
            ProNoCons = new HashSet<ProNoCon>();
        }

        public int IdProDisp { get; set; }
        public string Pdnombre { get; set; } = null!;
        public string? Pddescri { get; set; }
        public bool Pdestado { get; set; }

        public virtual ICollection<ProNoCon> ProNoCons { get; set; }
    }
}
