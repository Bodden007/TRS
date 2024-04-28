using Serilog;
using TRS.src.Models.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        //FIXME Logger Serilog seated to the console, need set out to file!!!!
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Console(outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss.fff zzz} " +
           "[{Level:u3}] [{SourceContext}] {Message:lj}{NewLine}{Exception}")
            .CreateLogger();

        var log=Log.ForContext<Program>();

        log.Information("Main");


        //TODO Точка Входа
    }
}