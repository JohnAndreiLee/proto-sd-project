using Consultation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Consultation.Domain;
using Microsoft.AspNetCore.Identity;
using FlutterAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Database configuration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity configuration
builder.Services.AddIdentity<Users, IdentityRole>(opts => {
    opts.Password.RequireDigit = true;
    opts.Password.RequiredLength = 10;
    opts.Password.RequireNonAlphanumeric = false;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Password hasher service
builder.Services.AddScoped<IPasswordHasher<Users>, PasswordHasher<Users>>();

// Controller services
builder.Services.AddControllers();

// API Explorer for Swagger
builder.Services.AddEndpointsApiExplorer();

// Enhanced Swagger configuration
builder.Services.ConfigureSwagger(builder.Configuration);

var app = builder.Build();

// Development environment configuration
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Enhanced Swagger UI configuration
app.ConfigureSwaggerUI(builder.Configuration);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
