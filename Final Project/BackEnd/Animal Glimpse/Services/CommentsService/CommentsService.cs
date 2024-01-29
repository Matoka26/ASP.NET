using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;
using Animal_Glimpse.Repositories.CommentsRepository;
using Animal_Glimpse.Repositories.PostRepository;
using Animal_Glimpse.Repositories.UserRepository;
using AutoMapper;
using Microsoft.OpenApi.Validations;

namespace Animal_Glimpse.Services.CommentsService
{
    public class CommentsService : ICommentsService
    {
        public ICommentsRepository _commentsRepository;
        public IUserRepository _userRepository;
        public IPostRepository _postRepository;
        public IMapper _mapper;

        public CommentsService(ICommentsRepository commentsRepository,
                               IUserRepository userRepository,
                               IPostRepository postRepository,
                               IMapper mapper)
        {
            _commentsRepository = commentsRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _postRepository = postRepository;
        }

        public async Task AddComment(CommentCreateDTO comm)
        {
            var existingUser = await _userRepository.GetUserById(comm.UserId);
            if (existingUser == null)
            {
                throw new Exception("Invalid User");
            }

            var existingPost = await _postRepository.FindByIdAsync(comm.PostId);
            if (existingPost == null)
            {
                throw new Exception("Invalid Post");
            }

            await _commentsRepository.CreateAsync(_mapper.Map<Comments>(comm));
            await _commentsRepository.SaveAsync();
        }

        public async Task DeleteComment(Guid id)
        {
            var existingComment = _commentsRepository.FindById(id);
            if (existingComment == null)
            {
                throw new Exception("Invalid Post");
            }

            _commentsRepository.Delete(existingComment);
            await _commentsRepository.SaveAsync();
        }

        public async Task<List<CommentGetUsersDTO>> GetCommsOfPost(Guid postId)
        {
            var existingPost = _postRepository.FindById(postId);
            if (existingPost == null)
            {
                throw new Exception("Invalid Post");
            }

            var CommentWithUserName = await _commentsRepository.GetCommsOfPost(postId);

            return CommentWithUserName;
        }

        public async Task<List<CommentGetPostsDTO>> GetCommsOfUser(Guid userId)
        {
            var existingUser = _userRepository.GetUserById(userId);
            if (existingUser == null)
            {
                throw new Exception("Invalid User");
            }

            var CommentWithPostId = await _commentsRepository.GetCommsOfUser(userId);

            return CommentWithPostId;
        }

        public async Task UpdateComment(CommentUpdateDTO comm)
        {
            var existingComment = _commentsRepository.FindById(comm.CommentId);

            if (existingComment == null)
            {
                throw new Exception("Invalid Comment");
            }

            if (comm.Content != null && comm.Content != "")
            {
                existingComment.LastModifiedTime = DateTime.Now;
                existingComment.Content = comm.Content;

                _commentsRepository.Update(existingComment);
                await _commentsRepository.SaveAsync();
            }
        }
    }
}
