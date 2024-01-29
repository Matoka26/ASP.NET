﻿using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.ReactionDTO;
using Animal_Glimpse.Repositories.PostRepository;
using Animal_Glimpse.Repositories.ReactionRepository;
using Animal_Glimpse.Repositories.ReactRepository;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;

namespace Animal_Glimpse.Services.ReactionService
{
    public class ReactionService : IReactionService
    {
        public IReactionRepository _reactionRepository;
        public IUserRepository _userRepository;
        public IPostRepository _postRepository;
        public IReactRepository _reactRepository;
        public IMapper _mapper;

        public ReactionService(IReactionRepository reactionRepository,
                               IUserRepository userRepository,
                               IPostRepository postRepository,
                               IReactRepository reactRepository,
                               IMapper mapper)
        {
            _reactionRepository = reactionRepository;
            _userRepository = userRepository;
            _postRepository = postRepository;
            _reactRepository = reactRepository;
            _mapper = mapper;
        }

        public async Task ReactToPost(ReactionCreateDTO reaction)
        {
            var existingUser = await _userRepository.GetUserById(reaction.UserId);
            if (existingUser == null)
            {
                throw new Exception("Invalid User");
            }

            var existingPost = _postRepository.FindById(reaction.PostId);
            if (existingPost == null)
            {
                throw new Exception("Invalid Post");
            }

            var existingReact = _reactRepository.FindById(reaction.ReactId);
            if(existingReact == null)
            {
                throw new Exception("Invalid React");
            }

            var newReaction = _mapper.Map<Reaction>(reaction);
            newReaction.User = existingUser;
            newReaction.Post = existingPost;
            newReaction.React = existingReact;

            await _reactionRepository.CreateAsync(newReaction);
            await _reactionRepository.SaveAsync();
        }
    }
}
