using Microsoft.EntityFrameworkCore;
using ModelBuilderExtensions.Database;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<DatabaseContext>(o => 
                                                   o.UseMySql(
                                                              connectionString,
                                                              new MySqlServerVersion(new Version(10,0,0))
                                                             ));

app.Run();