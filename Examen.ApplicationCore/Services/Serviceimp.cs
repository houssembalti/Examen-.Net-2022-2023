using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class PrestataireService : Service<Prestataire>, Iprestataires
    {
        public PrestataireService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public List<Prestataire> gettoptrois()
        {
            return GetMany(p=>p.Zone==Zone.Raoued).OrderByDescending(p => p.note).Take(3).ToList();    
        }
    }

    public class PrestationService : Service<Prestation>, IPrestation
    {
        public PrestationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double prixmoyen()
        {
            return  GetMany(p => p.PrestationTyp == Domain.Type.Coiffure).Sum(p => p.Prix) / GetMany(p => p.PrestationTyp == Domain.Type.Coiffure).ToList().Count();
        }


    }
    public class RDVService : Service<RDV>, IRDV
    {
        public RDVService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<IGrouping<DateTime,IEnumerable<RDV>>> confires (Client client)
        {
            return (IList<IGrouping<DateTime,IEnumerable<RDV>>>) GetMany(r => r.Confimration == true).Where(r => r.ClientFK == client.Id).GroupBy(r => r.DateRDv);
        }
    }
}
