using Animal_Glimpse.Models.DTOs.ReactionDTO;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Services.ReactionService
{
    public interface IReactionService
    {
        Task ReactToPost(ReactionCreateDTO reaction);
    }
}
