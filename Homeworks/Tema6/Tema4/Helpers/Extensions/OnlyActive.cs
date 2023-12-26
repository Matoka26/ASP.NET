using Tema4.Models;
namespace Tema4.Helpers.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<User> GetActiveUsers(this IQueryable<User>query)
        {
            return query.Where(x => x.IsDeleted);
        }
    }
}
