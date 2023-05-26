using apiFundadores.Data;
using Microsoft.EntityFrameworkCore;
using TesteHouseEasy.Contracts;
using TesteHouseEasy.Models;
using TesteHouseEasy.Repositories;
using AutoMapper;
using TesteHouseEasy.Models.DTO;
using TesteHouseEasy.Mappings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
    );

builder.Services.AddScoped<IRepositoryBase<UserModel>, UserRepository>();
builder.Services.AddScoped<IRepositoryBase<PhoneModel>, PhoneRepository>();
builder.Services.AddScoped<IRepositoryBase<AddressModel>, AddressRepository>();
builder.Services.AddScoped<IRepositoryBase<OccupationModel>, OccupationRepository>();

var app = builder.Build();

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
