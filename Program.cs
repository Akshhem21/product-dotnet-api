using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        });
    })
    .Build();

host.Run();
