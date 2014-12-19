using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Validation
{
    public class CargoTypeValidator :IValidator
    {
        private readonly IRepository<CargoType> _repository;

        public CargoTypeValidator(IRepository<CargoType> repository)
        {
            _repository = repository;
        }


        public bool IsValid(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
