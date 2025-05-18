
using Serilog;

namespace MagicVilla_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var logConfig = new ConfigurationBuilder().AddJsonFile($"appsettings.{environment}.json").Build();

            Log.Logger = new LoggerConfiguration()
                       .ReadFrom.Configuration(logConfig)   
                       .CreateLogger();

            builder.Host.UseSerilog();  




            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            try
            {
                Log.Information("Maggic API has started");
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {

                Log.Error(ex, "Fatai API not starting");
            }
            finally
            {
                Log.CloseAndFlushAsync();

            }
        }
    }
}
