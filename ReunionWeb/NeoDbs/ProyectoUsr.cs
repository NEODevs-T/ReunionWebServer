using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class ProyectoUsr
    {
        public ProyectoUsr()
        {
            Nivels = new HashSet<Nivel>();
        }

        public int IdProyecto { get; set; }
        public string Pnombre { get; set; } = null!;
        public bool Pestado { get; set; }

        public virtual ICollection<Nivel> Nivels { get; set; }
    }
}
