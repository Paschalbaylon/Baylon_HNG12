using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

//Add Services
builder.Services.AddAuthorization();
builder.Services.AddControllers();
//Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>{
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
