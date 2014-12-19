using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Validation
{
    public class ShipValidator :IValidator
    {
        private readonly IRepository<Ship> _repository;

        public ShipValidator(IRepository<Ship> repository)
        {
            _repository = repository;
        }

        public bool IsValid(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
