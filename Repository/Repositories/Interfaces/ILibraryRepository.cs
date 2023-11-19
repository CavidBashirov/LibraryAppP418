﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface ILibraryRepository : IBaseRepository<Library>
    {
        List<Library> GetLibrariesByName(string name);
        int GetCount();
    }
}
