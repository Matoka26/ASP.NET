using Animal_Glimpse.Models;

namespace Animal_Glimpse.Services.CommentsService
{
    public interface IUserService
    {
        List<User> GetAllSorted();
    }
}
