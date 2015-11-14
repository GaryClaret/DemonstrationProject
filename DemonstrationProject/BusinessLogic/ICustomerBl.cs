using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemonstrationProject.DomainObjects;
using DemonstrationProject.Models;

namespace DemonstrationProject.BusinessLogic
{
    public interface ICustomerBl
    {
        DmCustomerBill ProvideCustomerBill();
    }
}
