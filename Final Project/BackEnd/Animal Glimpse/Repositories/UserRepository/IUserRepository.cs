﻿using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Repositories.UserRepository
{
    public interface IUserRepository 
    {
        Task<User>? GetUserById(Guid id);
        Task<User>? GetByUsername(string username);
        Task CreateAsync(User user);
        Task Update(User user);
        Task Delete(Guid id);
        

    }
}
