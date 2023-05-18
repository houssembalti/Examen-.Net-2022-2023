using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class RDV
    {
        public bool Confimration { get; set; }
        public DateTime DateRDv { get; set; }

        public virtual Prestation Prestation { get; set; }

        public int PrestationFK { get; set; }

        public virtual Client Client { get; set; }

        public int ClientFK { get; set; }

    }
}
