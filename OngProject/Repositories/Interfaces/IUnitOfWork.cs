﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public void Dispose();
        public void SaveChanges();
        public Task SaveChangesAsync();
    }
}
