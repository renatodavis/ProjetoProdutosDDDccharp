﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProdutosDDD.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Dispose();


    }
}
