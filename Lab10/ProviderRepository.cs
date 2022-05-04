using System;
using System.Data.Linq;

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

        public Provider Update(Provider entity)
        {
            _context.Providers.Attach(entity);
            return entity;
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