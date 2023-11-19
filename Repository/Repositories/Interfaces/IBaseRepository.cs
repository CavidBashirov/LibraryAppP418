﻿using Domain.Common;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        void Create(T entity);
        void Edit(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
