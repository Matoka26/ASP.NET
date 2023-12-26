using Microsoft.EntityFrameworkCore;
using Tema4.Data;
using Tema4.Models;
using Tema4.Models.DTOs;
using Tema4.Repositories.GenericRepository;

namespace Tema4.Repositories.ClientRepository
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(Tema4Context tema4Conste) : base(tema4Conste) { }


        public List<Client> OrderByName(int name)
        {
            var clientsOrderAsc1 = _table.OrderBy(x => x.Name);
            
            /*
            var clientsOrderByMultople = _table.OrderByDescending( x => x.Name).ThenBy(x => x.Id);
            
            var clientsOrderDesc1 = _table.OrderByDescending(x => x.Name);
        
            var clientsOrderAsc2 = from s in _table
                                    orderby s.Name
                                    select s;
            var clientsOrderDesc2 = from s in _table
                                   orderby s.Name descending
                                   select s;
            */
            return clientsOrderAsc1.ToList() ;
        }

        public List<Client> GetAllWithInclude()
        {
            //var res =  _table.Include(S => S.Models2).ThenInclude(m2 => m2.Model1).ToList();
        
            return _table.Include(S => S.Models2).ToList();
        }

        public List<dynamic> GetAllWithJoin()
        {
         //   var result = _table.Join(_tema4Context.Models2, model1 => model1.id, model2 => model2.Model1Id,
         //           (model1, model2) => new({ model1, model2 }).Select(ob => ob.model1);

            return null;
        }

        public Client Where(int age)
        {
            var result1 = _table.Where(x => x.Age < age).FirstOrDefault();
            var result2 = _table.Where(x => x.Age < age);

            var result3 = from s in _table
                          where s.Age < age
                          select s;
            return result1;
        }

        public void GroupBy()
        {
            var groupedClients1 = _table.GroupBy(x => x.Name);
            
            
            var groupedClients2 = from s in _table
                                  group s by s.Name;
            foreach (var clientGroupedByName in groupedClients1)
            {
                Console.WriteLine("Client group name: " + clientGroupedByName.Key);

                foreach(var s in clientGroupedByName)
                {
                    Console.WriteLine("Client age: " + s.Age);
                }
            }

        }

        public Client FindByName(string username)
        {
            return _table.FirstOrDefault(u => u.Name.Equals(username));
        }

    }
}