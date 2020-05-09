using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODORepository.Entities
{
    public interface IEntityRepository<T,IIndividual>
    {
        T Get(string identification,IIndividual individual);
        IEnumerable<T> GetAll(IIndividual individual);
        T Set(T entity,IIndividual individual);
        T Update(T entity, IIndividual individual);
        bool Delete(string identification, IIndividual individual);
    }

}
