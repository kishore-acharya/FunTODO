using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess
{
    public interface IIndividualDataAccess<IIndividual>
    {
        IIndividual GetByUsername(string username);
        IIndividual GetByID(int iD);
        bool DeleteIndividualByUserName(string userName);
        bool SetIndividualDetials(IIndividual individual);
        bool UpdateIndividualDetails(IIndividual individual);
    }
}
