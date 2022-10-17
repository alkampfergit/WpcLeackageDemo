using Microsoft.Extensions.Configuration;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var configurationBuilder = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration Configuration = configurationBuilder.Build();

var secret = Configuration.GetValue<string>("Secret");

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"My secret is: {secret}");
Console.ReadKey();
