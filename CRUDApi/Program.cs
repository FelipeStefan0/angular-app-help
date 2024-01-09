using Microsoft.EntityFrameworkCore;
using CRUDApi.models;
using Microsoft.AspNetCore.Authentication.Negotiate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração de autenticação windows no banco
/*builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();
builder.Services.AddAuthorization();
builder.Services.AddRazorPages();*/

builder.Services.AddDbContext<Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDB"))
)
;

var app = builder.Build();

app.UseHttpsRedirection();


app.UseRouting();

// Uso de autenticação e a autenticação configurada
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints (endpoints => {
    endpoints.MapControllers ();
});

app.Run();


