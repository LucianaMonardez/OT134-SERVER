﻿using OngProject.Core.Interfaces;
using OngProject.Entities;
using OngProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Business
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActivitiesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Activities> GetAll()
        {
            throw new NotImplementedException();
        }

        public Activities GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Activities activities)
        {
            throw new NotImplementedException();
        }

        public void Update(Activities activities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Activities activities)
        {
            throw new NotImplementedException();
        }
    }
}