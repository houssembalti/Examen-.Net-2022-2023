using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface Iprestataires :IService<Prestataire>
    {
    }
    public interface IPrestation : IService<Prestation>
    {
    }

    public interface IRDV : IService<RDV>
    {
    }
}
