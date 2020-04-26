using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunTODOModels.Individual
{
    public class User:IIndividual
    {
        public int ID { get; set; }
        public String UserID { get; set; }
        public String UserName { get; set; }
    }
}
