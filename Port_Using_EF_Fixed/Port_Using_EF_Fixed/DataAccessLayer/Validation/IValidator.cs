using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Validation
{
    public interface IValidator
    {
        //IValidator<T>(IRepository<T> repository); 
        bool IsValid(BaseEntity entity);
    }
}
