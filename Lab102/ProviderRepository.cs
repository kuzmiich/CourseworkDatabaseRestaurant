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
    }
}