using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Identity;
using Core.Utilities.IoC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
        {
            builder.RegisterModule(new AutofacBusinessModule());
        });

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddCors();

        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        //builder.Services.AddSingleton<IProductService, ProductManager>();
        //builder.Services.AddSingleton<IProductDal , EfProductDal>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

        app.UseAuthorization();

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.MapControllers();

        app.Run();
    }
}

