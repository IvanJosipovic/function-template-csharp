using Function.SDK.CSharp;

namespace MyFunction;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateSlimBuilder(args);

        builder.ConfigureFunction(args);

        var app = builder.Build();

        app.MapFunctionService<RunFunctionService>();

        app.Run();
    }
}
