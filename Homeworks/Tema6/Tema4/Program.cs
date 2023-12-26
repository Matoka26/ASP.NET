using Microsoft.EntityFrameworkCore;
using Tema4.Data;
using Tema4.Helpers.Extensions;
using Tema4.Helpers.Seeders;
using Tema4.Repositories.ClientRepository;
using Tema4.Repositories.UserRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Tema4Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<IUserRepository, UserRepository>();
//builder.Services.AddTransient<IClientRepository, ClientRepository>();

builder.Services.AddRepositories();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddServices();
var app = builder.Build();
SeedData(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void SeedData(IHost app)
{
    var scopeFactory = app.Services.GetService<IServiceScopeFactory>();
    using(var scope = scopeFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<UsersSeeder>();
        service.SeedInitialUsers();
    }
}
