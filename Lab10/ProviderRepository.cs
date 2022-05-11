using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Lab10
{
    internal class ProviderRepository
    {
        private readonly DataClassesDataContext _context;

        public ProviderRepository(DataClassesDataContext context)
        {
            _context = context;
        }

        public Table<Provider> GetAll() => _context.GetTable<Provider>();

        public Provider Create(Provider entity)
        {
            _context.Providers.InsertOnSubmit(entity);
            return entity;
        }

        public void Update(Provider entity)
        {
            var provider = GetAll().Single(p => p.Id == entity.Id);
            // this logic need to update current provider
            provider.ProviderName = entity.ProviderName;
            provider.Description = entity.Description;
        }

        public Provider Delete(Provider entity)
        {
            _context.Providers.DeleteOnSubmit(entity);
            return entity;
        }

        public void SubmitChanges()
        {
            _context.SubmitChanges();
        }
    }
}