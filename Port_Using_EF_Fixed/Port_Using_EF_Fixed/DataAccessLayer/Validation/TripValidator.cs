﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DataAccessLayer.DataContextConfiguration;
using DataAccessLayer.Repository;
using FluentValidation;

namespace DataAccessLayer.Validation
{
    public class TripValidator : IValidator
    {
        private readonly IRepository<Trip> _repository;

        public TripValidator(IRepository<Trip> repository)
        {
            _repository = repository;
        }

        public bool IsValid(BaseEntity entity)
        {/*
            return entity.EndDate > entity.StartDate &&
                   ((entity.PortFromId != entity.PortToId) && (entity.PortFrom != entity.PortTo));*/
            return false;
        }
    }
}
