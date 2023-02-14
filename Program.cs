using easygroceries.Configurations;
using easygroceries.Data;
using easygroceries.IRepository;
using easygroceries.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder =>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithOrigins("http://localhost:3000", "https://appname.azurestaticapps.html");
        }
        );
});


// Add services to the container.

builder.Services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source=./Data/AppDB.db"));

builder.Services.AddAutoMapper(typeof(MapperInitilizer));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CORSPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
