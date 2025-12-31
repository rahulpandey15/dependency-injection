
using dependency_injection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

       builder.Services.AddTransient<IEmployeeService, EmployeeService>();


       builder.Services.AddScoped<ICustomerService, CustomerService>();



        builder.Services.AddKeyedScoped<
            INotificationService, EmailNotification>("Email");

        builder.Services.AddKeyedScoped<
            INotificationService, SMSNotification>("SMS");


        builder.Services.AddSwaggerGen();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
