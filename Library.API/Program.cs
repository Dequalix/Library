using Library.API;
using Microsoft.EntityFrameworkCore;
using Library.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options => 
  options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));


builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<Library.API.DataContext>();
    context.Database.EnsureCreated();
}

//Bind(IBookRepository).to(BookRepository);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
