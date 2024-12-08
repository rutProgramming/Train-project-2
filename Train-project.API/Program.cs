using Microsoft.EntityFrameworkCore;
using Train_project.Core.IRepositories;
using Train_project.Core.IServices;
using Train_project.Data;
using Train_project.Data.Repositories;
using Train_project.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/* ---------Repositories----------*/
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<IPublicInquiryRepository, PublicInquiryRepository>();
builder.Services.AddScoped<IStationRepository, StationRepository>();
builder.Services.AddScoped<ITrainRepository, TrainRepository>();
builder.Services.AddScoped<ITrainRouteRepository, TrainRouteRepository>();
/* ---------Services----------*/
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IPublicInquiryService, PublicInquiryService>();
builder.Services.AddScoped<IStationService, StationService>();
builder.Services.AddScoped<ITrainService, TrainService>();
builder.Services.AddScoped<ITrainRouteService, TrainRouteService>();
/* ---------DataContext----------*/
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer("Data Source=LAPTOP-KOM2Q8SQ\\SQLEXPRESS;Initial Catalog=Train_project_DB;Integrated Security=true; ");
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
