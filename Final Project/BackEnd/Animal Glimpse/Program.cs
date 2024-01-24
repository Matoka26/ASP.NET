using Animal_Glimpse.Data;
using Animal_Glimpse.Helpers.Extensions;
using Animal_Glimpse.Helpers.Seeders;
using Animal_Glimpse.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var reactService = scope.ServiceProvider.GetService<ReactSeeder>();
        reactService.SeedInitialReact();

     
        var userService = scope.ServiceProvider.GetService<UserSeeder>();
        userService.SeedInitialUser();

        var roleService = scope.ServiceProvider.GetService<RolesSeeder>();
        roleService.SeedInitialRoles();

        var userRolesService = scope.ServiceProvider.GetService<UserRoleSeeder>();
        userRolesService.SeedInitialUserRoles();

        var commService = scope.ServiceProvider.GetService<CommentsSeeder>();
        commService.SeedInitialComments();
    }
}



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AnimalContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, IdentityRole<Guid>>()
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<AnimalContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 8;
    opt.User.RequireUniqueEmail = true;
    opt.SignIn.RequireConfirmedAccount = false;
    opt.SignIn.RequireConfirmedEmail = false;
    opt.SignIn.RequireConfirmedPhoneNumber = false;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();
builder.Services.AddRepositories();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSeeders();

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