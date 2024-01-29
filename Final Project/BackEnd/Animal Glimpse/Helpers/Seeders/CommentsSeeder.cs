using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Microsoft.AspNetCore.Identity;
using System.Runtime.Intrinsics.X86;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class CommentsSeeder
    {
        public readonly AnimalContext _context;

        public CommentsSeeder(AnimalContext context)
        {
            _context = context;
        }

        public void SeedInitialComments()
        {
            if(!_context.Commentss.Any())
            {
                var comms = new List<Comments>()
                {
                    new Comments()
                    {
                        PostId = new Guid("075E9080-43B1-42B7-FF17-08DC1143FD5C"),
                        UserId = new Guid("A777C9F3-6811-4BB6-BB20-352BDD9F00A1"),
                        Content = "Jeeeeeez"
                    },

                    new Comments()
                    {
                        PostId = new Guid("075E9080-43B1-42B7-FF17-08DC1143FD5C"),
                        UserId = new Guid("AEB1D17A-F966-4089-A5B8-F28CE98D4E28"),
                        Content = "Sa ma bata mama...."
                    },

                    new Comments()
                    {
                        PostId = new Guid("D266D694-B14B-4493-FF18-08DC1143FD5C"),
                        UserId = new Guid("3CC80F65-2FC3-407D-B9D5-7BE0B1439A08"),
                        Content = "Nu mai pot cu proiectu asta.."
                    },

                    new Comments()
                    {
                        PostId = new Guid("D266D694-B14B-4493-FF18-08DC1143FD5C"),
                        UserId = new Guid("A777C9F3-6811-4BB6-BB20-352BDD9F00A1"),
                        Content = "Hi mom!"
                    },

                    new Comments()
                    {
                        PostId = new Guid("D266D694-B14B-4493-FF18-08DC1143FD5C"),
                        UserId = new Guid("3CC80F65-2FC3-407D-B9D5-7BE0B1439A08"),
                        Content = "What is cox?"
                    }
                };
                _context.Commentss.AddRange(comms);
                
                _context.SaveChanges();
            }
        }
    }
}
