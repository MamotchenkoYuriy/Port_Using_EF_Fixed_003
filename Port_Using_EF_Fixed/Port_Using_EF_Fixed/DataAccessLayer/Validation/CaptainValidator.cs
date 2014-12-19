using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.DataContextConfiguration;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Validation
{
    public class CaptainValidator :IValidator
    {
        private readonly IRepository<Captain> _repository;

        public CaptainValidator(IRepository<Captain> repository)
        {
            _repository = repository;
        }

        public bool IsValid(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
