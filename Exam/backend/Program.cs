using backend.Data;
using backend.Helpers.Extensions;
using backend.Helpers.Seeders;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
	{
		policy.WithOrigins("http://localhost:5174", "https://localhost:5174")
			.AllowAnyHeader()
			.AllowAnyMethod()
			.AllowCredentials();
	});
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(
	options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSeeders();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
SeedData(app);

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

void SeedData(IHost app)
{
	var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
	using (var scope = scopedFactory.CreateScope())
	{
		var testService = scope.ServiceProvider.GetService<TestSeeder>();
		testService.SeedInitialTests();
	}
}