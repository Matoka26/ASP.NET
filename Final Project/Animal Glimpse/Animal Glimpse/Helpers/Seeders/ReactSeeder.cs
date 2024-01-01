using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Helpers.Seeders
{
    public class ReactSeeder
    {
        public readonly AnimalContext _context;

        public ReactSeeder(AnimalContext context)
        {
            _context = context;
        }

        public void SeedInitialReact() 
        { 
            if (!_context.Reacts.Any())
            {
                var like = new React
                {
                    Name = "Like",
                    Color = 0x0100b4,
                    Logo = "Images/Reacts/Like Cat.jpeg"
                };

                var love = new React
                {
                    Name = "Love",
                    Color = 0xff2264,
                    Logo = "Images/Reacts/Love Cat.jpeg"
                };

                var upset = new React
                {
                    Name = "Upset",
                    Color = 0xff2222,
                    Logo = "Images/Reacts/Upset Dog.jpeg"
                };

                _context.Reacts.Add(like);
                _context.Reacts.Add(love);
                _context.Reacts.Add(upset);

                _context.SaveChanges();
            }   
        }
    }
}
