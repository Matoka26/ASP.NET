using Animal_Glimpse.Models;
using Animal_Glimpse.Repositories.CommentsRepository;
using Animal_Glimpse.Repositories.PostRepository;
using Animal_Glimpse.Repositories.ProfileRepository;
using Animal_Glimpse.Repositories.ReactionRepository;
using Animal_Glimpse.Repositories.ReactRepository;
using Animal_Glimpse.Services.ProfileService;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Animal_Glimpse.Services.ProfileService;
using Animal_Glimpse.Services.ReactService;
using Animal_Glimpse.Services.PostService;
using Animal_Glimpse.Services.ReactionService;
using Animal_Glimpse.Services.CommentsService;
using Animal_Glimpse.Helpers.Seeders;
using Animal_Glimpse.Controllers;

namespace Animal_Glimpse.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<IReactRepository, ReactRepository>();
            services.AddTransient<IPostRepository, PostRepository>();

            //This one might need CRUD
            services.AddTransient<IReactionRepository, ReactionRepository>();

            //Associatives that idk what will happen for sure
            services.AddTransient<ICommentsRepository, CommentsRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<IReactService, ReactService>();
            services.AddTransient<IPostService, PostService>();

            //This one might need CRUD
            services.AddTransient<IReactionService, ReactionService>();

            //Associatives that idk what will happen for sure
            services.AddTransient<ICommentsService, CommentsService>();

            return services;
        }

        public static IServiceCollection AddSeeders (this IServiceCollection services)
        {
            services.AddTransient<ReactSeeder>();
            services.AddTransient<UserSeeder>();
            services.AddTransient<RolesSeeder>();
            services.AddTransient<UserRoleSeeder>();

            return services;
        }
    }
}
// IF YOU DONT NEED CRUD ON THEM JUST DELETE THOSE AT THE END,
// MADE FOR ALL JUST IN CASE 