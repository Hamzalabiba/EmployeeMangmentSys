using Domain.Data;
using Infrastrcture.EmployeeSys.EmployeeRepo;
using Infrastructre.EmployeeSys;
using Microsoft.EntityFrameworkCore;
using Repositroy.EmployeeSys;
using ServaceLayer.EmployeeDtoSys.EmployeeDtoServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// inject service 

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped<IEmployee, EmployeeRepo>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddDbContext<EmpMangementSysContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"),
        b=>b.MigrationsAssembly(typeof(EmpMangementSysContext).Assembly.FullName));
});
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
