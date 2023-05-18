using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
     public enum Zone
    {
        Raoued,
        ArianaVille,
        Lasoukra
    }
    public class Prestataire
    {
        [Range(0,5)]
        public int note { get; set; }
        public string PageInstagram { get; set; }

        public int PrestataireId { get; set; }
        
        public string PrestataireNom { get; set; }

        public string prestataireTel { get; set; }
        public Zone Zone { get; set; }

        public virtual IList<Prestation > PrestationsList { get; set; }


    }
}
