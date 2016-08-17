using DemonstrationProject.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrationProject.Adaptors
{
    public interface ICustomerDataServiceAdaptor
    {
        object ProvideCustomerBill();
        object ProvideFilmShowTimes(string dateOfShowings);
    }
}
