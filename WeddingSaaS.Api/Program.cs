using Microsoft.EntityFrameworkCore;
using WeddingSaas.Infrastructure.Data; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    
    
    options.UseSqlServer(connectionString);
});

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();