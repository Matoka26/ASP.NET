using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.EdituraRepository
{
    public class EdituraRepository: GenericRepository<Editura>, IEdituraRepository
    {
        public EdituraRepository(DatabaseContext context) : base(context) { }
    }
}
